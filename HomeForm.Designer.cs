namespace BounceBall
{
	partial class HomeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
			this.StartLbl = new System.Windows.Forms.Label();
			this.StartBtn = new System.Windows.Forms.Button();
			this.HelpBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// StartLbl
			// 
			this.StartLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.StartLbl.AutoSize = true;
			this.StartLbl.BackColor = System.Drawing.Color.Transparent;
			this.StartLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartLbl.Font = new System.Drawing.Font("Bread Smile", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartLbl.ForeColor = System.Drawing.Color.MidnightBlue;
			this.StartLbl.Location = new System.Drawing.Point(100, 56);
			this.StartLbl.Name = "StartLbl";
			this.StartLbl.Size = new System.Drawing.Size(615, 74);
			this.StartLbl.TabIndex = 0;
			this.StartLbl.Text = "Welcome to Cloud Pong!";
			// 
			// StartBtn
			// 
			this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.StartBtn.BackColor = System.Drawing.Color.LightPink;
			this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.StartBtn.Font = new System.Drawing.Font("Lucky Skirt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartBtn.ForeColor = System.Drawing.Color.IndianRed;
			this.StartBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.StartBtn.Location = new System.Drawing.Point(498, 185);
			this.StartBtn.Name = "StartBtn";
			this.StartBtn.Size = new System.Drawing.Size(173, 122);
			this.StartBtn.TabIndex = 1;
			this.StartBtn.Text = "Start";
			this.StartBtn.UseVisualStyleBackColor = false;
			this.StartBtn.Click += new System.EventHandler(this.LoadGame);
			// 
			// HelpBtn
			// 
			this.HelpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.HelpBtn.BackColor = System.Drawing.Color.LightSteelBlue;
			this.HelpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.HelpBtn.Font = new System.Drawing.Font("Lucky Skirt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpBtn.ForeColor = System.Drawing.Color.MidnightBlue;
			this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.HelpBtn.Location = new System.Drawing.Point(158, 185);
			this.HelpBtn.Name = "HelpBtn";
			this.HelpBtn.Size = new System.Drawing.Size(173, 122);
			this.HelpBtn.TabIndex = 2;
			this.HelpBtn.Text = "How to Play";
			this.HelpBtn.UseVisualStyleBackColor = false;
			this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BounceBall.Properties.Resources.Game_background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.HelpBtn);
			this.Controls.Add(this.StartBtn);
			this.Controls.Add(this.StartLbl);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "HomeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cloud Pong";
			this.Load += new System.EventHandler(this.BgMusic);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label StartLbl;
		private System.Windows.Forms.Button StartBtn;
		private System.Windows.Forms.Button HelpBtn;
	}
}