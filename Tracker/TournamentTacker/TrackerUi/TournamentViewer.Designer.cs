namespace TrackerUi
{
	partial class TournamentViewer
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
			this.HeaderLabel = new System.Windows.Forms.Label();
			this.TournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.RoundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCkeckBox = new System.Windows.Forms.CheckBox();
			this.MatchUpListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// HeaderLabel
			// 
			this.HeaderLabel.AutoSize = true;
			this.HeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
			this.HeaderLabel.Location = new System.Drawing.Point(23, 34);
			this.HeaderLabel.Name = "HeaderLabel";
			this.HeaderLabel.Size = new System.Drawing.Size(133, 25);
			this.HeaderLabel.TabIndex = 0;
			this.HeaderLabel.Text = "Tournament:";
			// 
			// TournamentName
			// 
			this.TournamentName.AutoSize = true;
			this.TournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
			this.TournamentName.Location = new System.Drawing.Point(216, 34);
			this.TournamentName.Name = "TournamentName";
			this.TournamentName.Size = new System.Drawing.Size(84, 25);
			this.TournamentName.TabIndex = 1;
			this.TournamentName.Text = "<none>";
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roundLabel.Location = new System.Drawing.Point(22, 80);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(94, 31);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "Round";
			// 
			// RoundDropDown
			// 
			this.RoundDropDown.FormattingEnabled = true;
			this.RoundDropDown.Location = new System.Drawing.Point(128, 78);
			this.RoundDropDown.Name = "RoundDropDown";
			this.RoundDropDown.Size = new System.Drawing.Size(240, 33);
			this.RoundDropDown.TabIndex = 3;
			// 
			// unplayedOnlyCkeckBox
			// 
			this.unplayedOnlyCkeckBox.AutoSize = true;
			this.unplayedOnlyCkeckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.unplayedOnlyCkeckBox.Location = new System.Drawing.Point(128, 131);
			this.unplayedOnlyCkeckBox.Name = "unplayedOnlyCkeckBox";
			this.unplayedOnlyCkeckBox.Size = new System.Drawing.Size(172, 29);
			this.unplayedOnlyCkeckBox.TabIndex = 4;
			this.unplayedOnlyCkeckBox.Text = "Unplayed Only";
			this.unplayedOnlyCkeckBox.UseVisualStyleBackColor = true;
			// 
			// MatchUpListBox
			// 
			this.MatchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MatchUpListBox.FormattingEnabled = true;
			this.MatchUpListBox.ItemHeight = 25;
			this.MatchUpListBox.Location = new System.Drawing.Point(28, 178);
			this.MatchUpListBox.Name = "MatchUpListBox";
			this.MatchUpListBox.Size = new System.Drawing.Size(340, 302);
			this.MatchUpListBox.TabIndex = 5;
			// 
			// TournamentViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(794, 631);
			this.Controls.Add(this.MatchUpListBox);
			this.Controls.Add(this.unplayedOnlyCkeckBox);
			this.Controls.Add(this.RoundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.TournamentName);
			this.Controls.Add(this.HeaderLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "TournamentViewer";
			this.Text = "TournamentViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label HeaderLabel;
		private System.Windows.Forms.Label TournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox RoundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCkeckBox;
		private System.Windows.Forms.ListBox MatchUpListBox;
	}
}