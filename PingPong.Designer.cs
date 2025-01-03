
namespace BounceBall
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.player1 = new System.Windows.Forms.PictureBox();
			this.cpuPlayer = new System.Windows.Forms.PictureBox();
			this.playerScoreLbl = new System.Windows.Forms.Label();
			this.cpuScoreLbl = new System.Windows.Forms.Label();
			this.starBall = new System.Windows.Forms.PictureBox();
			this.pongTimer = new System.Windows.Forms.Timer(this.components);
			this.ScoreLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.starBall)).BeginInit();
			this.SuspendLayout();
			// 
			// player1
			// 
			this.player1.BackColor = System.Drawing.Color.Transparent;
			this.player1.BackgroundImage = global::BounceBall.Properties.Resources.P1_pink_cloud_1;
			this.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.player1.ErrorImage = global::BounceBall.Properties.Resources.P1_pink_cloud_1;
			this.player1.InitialImage = global::BounceBall.Properties.Resources.P1_pink_cloud_1;
			this.player1.Location = new System.Drawing.Point(13, 131);
			this.player1.Name = "player1";
			this.player1.Size = new System.Drawing.Size(67, 111);
			this.player1.TabIndex = 4;
			this.player1.TabStop = false;
			// 
			// cpuPlayer
			// 
			this.cpuPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cpuPlayer.BackColor = System.Drawing.Color.Transparent;
			this.cpuPlayer.BackgroundImage = global::BounceBall.Properties.Resources.P2_dark_purple_cloud;
			this.cpuPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cpuPlayer.ErrorImage = global::BounceBall.Properties.Resources.P2_dark_purple_cloud;
			this.cpuPlayer.InitialImage = global::BounceBall.Properties.Resources.P2_dark_purple_cloud;
			this.cpuPlayer.Location = new System.Drawing.Point(710, 131);
			this.cpuPlayer.Name = "cpuPlayer";
			this.cpuPlayer.Size = new System.Drawing.Size(67, 111);
			this.cpuPlayer.TabIndex = 5;
			this.cpuPlayer.TabStop = false;
			// 
			// playerScoreLbl
			// 
			this.playerScoreLbl.BackColor = System.Drawing.Color.Transparent;
			this.playerScoreLbl.Font = new System.Drawing.Font("Bread Smile", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerScoreLbl.ForeColor = System.Drawing.Color.Pink;
			this.playerScoreLbl.Location = new System.Drawing.Point(310, 19);
			this.playerScoreLbl.Name = "playerScoreLbl";
			this.playerScoreLbl.Size = new System.Drawing.Size(45, 54);
			this.playerScoreLbl.TabIndex = 6;
			this.playerScoreLbl.Text = "0";
			this.playerScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cpuScoreLbl
			// 
			this.cpuScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cpuScoreLbl.BackColor = System.Drawing.Color.Transparent;
			this.cpuScoreLbl.Font = new System.Drawing.Font("Bread Smile", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpuScoreLbl.ForeColor = System.Drawing.Color.Indigo;
			this.cpuScoreLbl.Location = new System.Drawing.Point(439, 19);
			this.cpuScoreLbl.Name = "cpuScoreLbl";
			this.cpuScoreLbl.Size = new System.Drawing.Size(45, 54);
			this.cpuScoreLbl.TabIndex = 7;
			this.cpuScoreLbl.Text = "0";
			this.cpuScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// starBall
			// 
			this.starBall.BackColor = System.Drawing.Color.Transparent;
			this.starBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.starBall.Image = global::BounceBall.Properties.Resources.Nyan_BalloonBlue;
			this.starBall.Location = new System.Drawing.Point(383, 112);
			this.starBall.Name = "starBall";
			this.starBall.Size = new System.Drawing.Size(57, 75);
			this.starBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.starBall.TabIndex = 8;
			this.starBall.TabStop = false;
			// 
			// pongTimer
			// 
			this.pongTimer.Enabled = true;
			this.pongTimer.Interval = 10;
			this.pongTimer.Tick += new System.EventHandler(this.PongTimer_Tick);
			// 
			// ScoreLbl
			// 
			this.ScoreLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ScoreLbl.BackColor = System.Drawing.Color.Transparent;
			this.ScoreLbl.Font = new System.Drawing.Font("Bread Smile", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScoreLbl.ForeColor = System.Drawing.Color.HotPink;
			this.ScoreLbl.Location = new System.Drawing.Point(349, 9);
			this.ScoreLbl.Name = "ScoreLbl";
			this.ScoreLbl.Size = new System.Drawing.Size(91, 54);
			this.ScoreLbl.TabIndex = 9;
			this.ScoreLbl.Text = "Scores";
			this.ScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BounceBall.Properties.Resources.Game_background_V2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ScoreLbl);
			this.Controls.Add(this.playerScoreLbl);
			this.Controls.Add(this.starBall);
			this.Controls.Add(this.cpuScoreLbl);
			this.Controls.Add(this.cpuPlayer);
			this.Controls.Add(this.player1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cloud Pong";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cpuPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.starBall)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.PictureBox player1;
		private System.Windows.Forms.PictureBox cpuPlayer;
		private System.Windows.Forms.Label playerScoreLbl;
		private System.Windows.Forms.Label cpuScoreLbl;
		private System.Windows.Forms.PictureBox starBall;
		private System.Windows.Forms.Timer pongTimer;
		private System.Windows.Forms.Label ScoreLbl;
	}
}

