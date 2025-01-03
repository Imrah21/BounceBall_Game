using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BounceBall
{
	public partial class HomeForm : Form
	{
		//Variables

		//Media player for bg music
		WindowsMediaPlayer player = new WindowsMediaPlayer();

		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Default Constructor
		/// </summary>
		public HomeForm()
		{
			InitializeComponent();
			player.URL = "NyanCat.mp3";
		}
		//----------------------------------------------------------------------------------------------------------------//
		/// <summary>
		///  Play the start sound file resource.
		/// </summary>
		private void StartSound()
		{
			using (var player = new SoundPlayer(Properties.Resources.Start_Sound))
			{
				player.Play();
				return;
			}
		}
		//----------------------------------------------------------------------------------------------------------------//
		/// <summary>
		///  Play the help sound file resource.
		/// </summary>
		private void HelpSound()
		{
			using (var player = new SoundPlayer(Properties.Resources.Help_Sound))
			{
				player.Play();
				return;
			}
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Starts game
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoadGame(object sender, EventArgs e)
		{
			FormMain gameScreen = new FormMain();
			this.Hide();//Hides current form
			gameScreen.Show();
			StartSound();
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Opens help screen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HelpBtn_Click(object sender, EventArgs e)
		{
			HelpForm helpScreen = new HelpForm();
			helpScreen.Show();
			HelpSound();
		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
		/// <summary>
		/// Plays Background Music
		/// </summary>
		private void BgMusic(object sender, EventArgs e)
		{

			// Set the full computer volume
			player.settings.volume = 100;

			// Play song
			player.controls.play();

		}
		//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
	}
}
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//