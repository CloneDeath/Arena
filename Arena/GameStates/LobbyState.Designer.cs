namespace Arena.GameStates
{
	partial class LobbyState
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
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbPlayers = new System.Windows.Forms.ListBox();
			this.btnReady = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.gbClasses = new System.Windows.Forms.GroupBox();
			this.rbClassHealer = new System.Windows.Forms.RadioButton();
			this.rbClassKnight = new System.Windows.Forms.RadioButton();
			this.tbPlayerName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbClasses.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbPlayers
			// 
			this.lbPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.lbPlayers.FormattingEnabled = true;
			this.lbPlayers.Location = new System.Drawing.Point(4, 4);
			this.lbPlayers.Name = "lbPlayers";
			this.lbPlayers.Size = new System.Drawing.Size(216, 342);
			this.lbPlayers.TabIndex = 0;
			// 
			// btnReady
			// 
			this.btnReady.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReady.Location = new System.Drawing.Point(476, 117);
			this.btnReady.Name = "btnReady";
			this.btnReady.Size = new System.Drawing.Size(75, 23);
			this.btnReady.TabIndex = 1;
			this.btnReady.Text = "Ready";
			this.btnReady.UseVisualStyleBackColor = true;
			this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Enabled = false;
			this.btnStart.Location = new System.Drawing.Point(476, 325);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Start!";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// gbClasses
			// 
			this.gbClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gbClasses.Controls.Add(this.rbClassHealer);
			this.gbClasses.Controls.Add(this.rbClassKnight);
			this.gbClasses.Location = new System.Drawing.Point(223, 36);
			this.gbClasses.Name = "gbClasses";
			this.gbClasses.Size = new System.Drawing.Size(325, 75);
			this.gbClasses.TabIndex = 7;
			this.gbClasses.TabStop = false;
			this.gbClasses.Text = "Class";
			// 
			// rbClassHealer
			// 
			this.rbClassHealer.AutoSize = true;
			this.rbClassHealer.Location = new System.Drawing.Point(6, 42);
			this.rbClassHealer.Name = "rbClassHealer";
			this.rbClassHealer.Size = new System.Drawing.Size(56, 17);
			this.rbClassHealer.TabIndex = 1;
			this.rbClassHealer.Text = "Healer";
			this.rbClassHealer.UseVisualStyleBackColor = true;
			this.rbClassHealer.CheckedChanged += new System.EventHandler(this.rbClassHealer_CheckedChanged);
			// 
			// rbClassKnight
			// 
			this.rbClassKnight.AutoSize = true;
			this.rbClassKnight.Checked = true;
			this.rbClassKnight.Location = new System.Drawing.Point(6, 19);
			this.rbClassKnight.Name = "rbClassKnight";
			this.rbClassKnight.Size = new System.Drawing.Size(55, 17);
			this.rbClassKnight.TabIndex = 0;
			this.rbClassKnight.TabStop = true;
			this.rbClassKnight.Text = "Knight";
			this.rbClassKnight.UseVisualStyleBackColor = true;
			this.rbClassKnight.CheckedChanged += new System.EventHandler(this.rbClassKnight_CheckedChanged);
			// 
			// tbPlayerName
			// 
			this.tbPlayerName.Location = new System.Drawing.Point(304, 10);
			this.tbPlayerName.Name = "tbPlayerName";
			this.tbPlayerName.Size = new System.Drawing.Size(154, 20);
			this.tbPlayerName.TabIndex = 6;
			this.tbPlayerName.Text = "New Player";
			this.tbPlayerName.TextChanged += new System.EventHandler(this.tbPlayerName_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(228, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Player Name:";
			// 
			// LobbyState
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbClasses);
			this.Controls.Add(this.tbPlayerName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnReady);
			this.Controls.Add(this.lbPlayers);
			this.Name = "LobbyState";
			this.Size = new System.Drawing.Size(554, 351);
			this.gbClasses.ResumeLayout(false);
			this.gbClasses.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbPlayers;
		private System.Windows.Forms.Button btnReady;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.GroupBox gbClasses;
		private System.Windows.Forms.RadioButton rbClassHealer;
		private System.Windows.Forms.RadioButton rbClassKnight;
		private System.Windows.Forms.TextBox tbPlayerName;
		private System.Windows.Forms.Label label1;
	}
}
