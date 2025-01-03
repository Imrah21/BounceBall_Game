using BounceBall.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BounceBall
{
	public partial class FormMain : Form
	{
		//Media player for bg music
		WindowsMediaPlayer player = new WindowsMediaPlayer();

		//Location Variables
		private int cpuDirection = 5;
		private int ballXCoordinate = 5;
		private int ballYCoordinate = 5;

		//Score Variables
		private int playerScore = 0;
		private int cpuScore = 0;

		//Size Variables
		private int bottomBoundary;
		private int centrePoint;
		private int xMidpoint;
		private int yMidpoint;

		// Detection Variables
		bool playerDetectedUp;
		bool playerDetectedDown;

		// Special Keys
		int spaceBarClicked = 0;
		//------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		///  Default Constructor
		/// </summary>
		public FormMain()
		{
			InitializeComponent();

			bottomBoundary = ClientSize.Height - player1.Height;
			xMidpoint = ClientSize.Width / 2;
			yMidpoint = ClientSize.Height / 2;

			// Use double buffering to reduce flicker.
			this.SetStyle(
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.DoubleBuffer,
				true);
			this.UpdateStyles();

			// Subscribe to the FormClosing event
			this.FormClosing += PingPong_FormClosing;
		}
		//----------------------------------------------------------------------------------------------------------------//
		/// <summary>
		///  Play the star whoosh sound file resource.
		/// </summary>
		private void StarWhooshSound()
		{
			using (var player = new SoundPlayer(Properties.Resources.Star_Whoosh))
			{
				player.Play();
				return;
			}
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Event handler for the FormClosing event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PingPong_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Check if the closing form is not the main form
			if (this != Application.OpenForms[0])
			{
				// Stop the application from running
				Application.Exit();
			}
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Event handler for user clicking up key event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormMain_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				playerDetectedUp = false;
			}
			if (e.KeyCode == Keys.Down)
			{
				playerDetectedDown = false;
			}
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Event handler for user clicking down key event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormMain_KeyDown(object sender, KeyEventArgs e)
		{
			// If player presses the up arrow, move paddle upwards
			if (e.KeyCode == Keys.Up)
			{
				playerDetectedUp = true;
			}

			// If player presses the down arrow, move paddle downwards
			if (e.KeyCode == Keys.Down)
			{
				playerDetectedDown = true;
			}

			// If player presses the H key, open the Home screen
			if (e.KeyCode == Keys.H)
			{
				playerScore = 0;
				cpuScore = 0;
				Form home = new HomeForm();
				home.Owner = this;
				pongTimer.Stop();
				this.Hide();
				home.Show();
			}

			// If player presses space bar, pause the game
			if (e.KeyCode == Keys.Space)
			{
				if (spaceBarClicked % 2 == 0)
				{
					pongTimer.Stop();
				}
				else
				{
					pongTimer.Start();
				}
			}
			spaceBarClicked++;
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Event handler for timer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PongTimer_Tick(object sender, EventArgs e)
		{
			Random newBallSpot = new Random();
			int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);

			// Adjust where the ball is
			starBall.Top -= ballYCoordinate;
			starBall.Left -= ballXCoordinate;

			// Make the CPU move
			cpuPlayer.Top += cpuDirection;

			// Make CPU better at the game, the higher the playerScore
			if (playerScore > 5)
			{
				cpuPlayer.Top = starBall.Top + 30;
			}

			// Check if CPU has reached the top or the bottom
			if (cpuPlayer.Top < 0 || cpuPlayer.Top > bottomBoundary)
			{
				cpuDirection = -cpuDirection;
				StarWhooshSound();
			}

			// Check if the ball has exited the left side of the screen
			if (starBall.Left < 0)
			{
				//soundEffect.Play();
				starBall.Left = xMidpoint;
				starBall.Top = newSpot;
				ballXCoordinate = -ballXCoordinate;

				if (playerScore < 5)
				{
					ballXCoordinate -= 1;
				}

				cpuScore++;
				cpuScoreLbl.Text = cpuScore.ToString();

				StarWhooshSound();
			}

			// Check if the ball has exited the right side of the screen
			if (starBall.Left + starBall.Width > ClientSize.Width)
			{
				starBall.Left = xMidpoint;
				starBall.Top = newSpot;
				ballXCoordinate = -ballXCoordinate;

				if (playerScore < 5)
				{
					ballXCoordinate += 1;
				}
				playerScore++;
				playerScoreLbl.Text = playerScore.ToString();

				StarWhooshSound();
			}

			// Ensure the ball is within the boundaries of the screen
			if (starBall.Top < 0 || starBall.Top + starBall.Height > ClientSize.Height)
			{
				ballYCoordinate = -ballYCoordinate;
			}

			// Check if the ball hits the player or CPU paddle
			if (starBall.Bounds.IntersectsWith(player1.Bounds) || starBall.Bounds.IntersectsWith(cpuPlayer.Bounds))
			{
				// Send ball opposite direction
				ballXCoordinate = -ballXCoordinate;
			}

			// Move player up
			if (playerDetectedUp == true && player1.Top > 0)
			{
				player1.Top -= 10;
			}

			// Move player down
			if (playerDetectedDown == true && player1.Top < bottomBoundary)
			{
				player1.Top += 10;
			}

			// Check for winner
			if (playerScore >= 10)
			{
				playerScore = 0;
				cpuScore = 0;
				pongTimer.Stop();

				string message = "Congratulations! You Won!!🥳🥳 \n Would you like to restart?";
				string title = "Game Over";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);

				if (result == DialogResult.Yes)
				{
					cpuScore = 0;
					playerScore = 0;
					pongTimer.Start();
				}
				else
				{
					this.Hide();
					HomeForm home = new HomeForm();
					home.Show();
				}

			}

			// Check for winner
			if (cpuScore >= 10)
			{
				pongTimer.Stop();

				string message = "Womp womp woomp! ☹ You lost ☹ \n Would you like to restart?";
				string title = "Game Over";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);

				if (result == DialogResult.Yes)
				{
					cpuScore = 0;
					playerScore = 0;
					pongTimer.Start();
				}
				else
				{
					this.Hide();
					HomeForm home = new HomeForm();
					home.Show();
				}
			}


		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//	}
	}
}
///---------------------------------------------...ooo000 END OF FILE 000ooo...--------------------------------------------//
