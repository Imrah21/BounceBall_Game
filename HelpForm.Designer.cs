namespace BounceBall
{
	partial class HelpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			this.HelpLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// HelpLbl
			// 
			this.HelpLbl.BackColor = System.Drawing.Color.Pink;
			this.HelpLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.HelpLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpLbl.ForeColor = System.Drawing.Color.IndianRed;
			this.HelpLbl.Location = new System.Drawing.Point(137, 44);
			this.HelpLbl.Name = "HelpLbl";
			this.HelpLbl.Size = new System.Drawing.Size(514, 494);
			this.HelpLbl.TabIndex = 0;
			this.HelpLbl.Text = resources.GetString("HelpLbl.Text");
			this.HelpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BounceBall.Properties.Resources.HelpScreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(780, 592);
			this.Controls.Add(this.HelpLbl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "HelpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "How to Play";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label HelpLbl;
	}
}