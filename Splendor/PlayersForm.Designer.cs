namespace Splendor
{
	partial class PlayersForm
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
			this.lstPlayers = new System.Windows.Forms.ListBox();
			this.txtBox = new System.Windows.Forms.TextBox();
			this.cmdRemovePlayer = new System.Windows.Forms.Button();
			this.cmdEndPlayer = new System.Windows.Forms.Button();
			this.cmdAddPlayer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstPlayers
			// 
			this.lstPlayers.FormattingEnabled = true;
			this.lstPlayers.Location = new System.Drawing.Point(13, 13);
			this.lstPlayers.Name = "lstPlayers";
			this.lstPlayers.Size = new System.Drawing.Size(296, 316);
			this.lstPlayers.TabIndex = 0;
			this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
			// 
			// txtBox
			// 
			this.txtBox.Location = new System.Drawing.Point(13, 353);
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(215, 20);
			this.txtBox.TabIndex = 1;
			this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			// 
			// cmdRemovePlayer
			// 
			this.cmdRemovePlayer.Enabled = false;
			this.cmdRemovePlayer.Location = new System.Drawing.Point(234, 352);
			this.cmdRemovePlayer.Name = "cmdRemovePlayer";
			this.cmdRemovePlayer.Size = new System.Drawing.Size(75, 23);
			this.cmdRemovePlayer.TabIndex = 2;
			this.cmdRemovePlayer.Text = "Supprimer";
			this.cmdRemovePlayer.UseVisualStyleBackColor = true;
			this.cmdRemovePlayer.Click += new System.EventHandler(this.cmdRemovePlayer_Click);
			// 
			// cmdEndPlayer
			// 
			this.cmdEndPlayer.Location = new System.Drawing.Point(13, 412);
			this.cmdEndPlayer.Name = "cmdEndPlayer";
			this.cmdEndPlayer.Size = new System.Drawing.Size(296, 23);
			this.cmdEndPlayer.TabIndex = 3;
			this.cmdEndPlayer.Text = "Terminé";
			this.cmdEndPlayer.UseVisualStyleBackColor = true;
			this.cmdEndPlayer.Click += new System.EventHandler(this.cmdEndPlayer_Click);
			// 
			// cmdAddPlayer
			// 
			this.cmdAddPlayer.Enabled = false;
			this.cmdAddPlayer.Location = new System.Drawing.Point(12, 382);
			this.cmdAddPlayer.Name = "cmdAddPlayer";
			this.cmdAddPlayer.Size = new System.Drawing.Size(296, 23);
			this.cmdAddPlayer.TabIndex = 4;
			this.cmdAddPlayer.Text = "Ajouter";
			this.cmdAddPlayer.UseVisualStyleBackColor = true;
			this.cmdAddPlayer.Click += new System.EventHandler(this.cmdAddPlayer_Click);
			// 
			// PlayersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 447);
			this.Controls.Add(this.cmdAddPlayer);
			this.Controls.Add(this.cmdEndPlayer);
			this.Controls.Add(this.cmdRemovePlayer);
			this.Controls.Add(this.txtBox);
			this.Controls.Add(this.lstPlayers);
			this.Name = "PlayersForm";
			this.Text = "PlayersForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayersForm_FormClosed);
			this.Load += new System.EventHandler(this.PlayersForm_Load);
			this.Shown += new System.EventHandler(this.PlayersForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstPlayers;
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.Button cmdRemovePlayer;
		private System.Windows.Forms.Button cmdEndPlayer;
		private System.Windows.Forms.Button cmdAddPlayer;
	}
}