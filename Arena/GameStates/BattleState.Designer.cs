namespace Arena.GameStates
{
	partial class BattleState
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
			this.pbDragonHealth = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDragonHealth = new System.Windows.Forms.Label();
			this.btnAttack = new System.Windows.Forms.Button();
			this.lbPlayerHealth = new System.Windows.Forms.Label();
			this.lbPlayerName = new System.Windows.Forms.Label();
			this.pbPlayerHealth = new System.Windows.Forms.ProgressBar();
			this.lbPlayers = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// pbDragonHealth
			// 
			this.pbDragonHealth.Location = new System.Drawing.Point(22, 45);
			this.pbDragonHealth.Name = "pbDragonHealth";
			this.pbDragonHealth.Size = new System.Drawing.Size(564, 23);
			this.pbDragonHealth.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dragon";
			// 
			// lblDragonHealth
			// 
			this.lblDragonHealth.AutoSize = true;
			this.lblDragonHealth.Location = new System.Drawing.Point(538, 71);
			this.lblDragonHealth.Name = "lblDragonHealth";
			this.lblDragonHealth.Size = new System.Drawing.Size(48, 13);
			this.lblDragonHealth.TabIndex = 2;
			this.lblDragonHealth.Text = "100/100";
			// 
			// btnAttack
			// 
			this.btnAttack.Location = new System.Drawing.Point(22, 366);
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.Size = new System.Drawing.Size(93, 23);
			this.btnAttack.TabIndex = 3;
			this.btnAttack.Text = "Attack";
			this.btnAttack.UseVisualStyleBackColor = true;
			this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
			// 
			// lbPlayerHealth
			// 
			this.lbPlayerHealth.AutoSize = true;
			this.lbPlayerHealth.Location = new System.Drawing.Point(175, 338);
			this.lbPlayerHealth.Name = "lbPlayerHealth";
			this.lbPlayerHealth.Size = new System.Drawing.Size(36, 13);
			this.lbPlayerHealth.TabIndex = 6;
			this.lbPlayerHealth.Text = "10/10";
			// 
			// lbPlayerName
			// 
			this.lbPlayerName.AutoSize = true;
			this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPlayerName.Location = new System.Drawing.Point(18, 296);
			this.lbPlayerName.Name = "lbPlayerName";
			this.lbPlayerName.Size = new System.Drawing.Size(107, 20);
			this.lbPlayerName.TabIndex = 5;
			this.lbPlayerName.Text = "#Player Name";
			// 
			// pbPlayerHealth
			// 
			this.pbPlayerHealth.Location = new System.Drawing.Point(22, 319);
			this.pbPlayerHealth.Name = "pbPlayerHealth";
			this.pbPlayerHealth.Size = new System.Drawing.Size(189, 16);
			this.pbPlayerHealth.TabIndex = 4;
			// 
			// lbPlayers
			// 
			this.lbPlayers.FormattingEnabled = true;
			this.lbPlayers.Location = new System.Drawing.Point(22, 114);
			this.lbPlayers.Name = "lbPlayers";
			this.lbPlayers.Size = new System.Drawing.Size(480, 160);
			this.lbPlayers.TabIndex = 7;
			// 
			// BattleState
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbPlayers);
			this.Controls.Add(this.lbPlayerHealth);
			this.Controls.Add(this.lbPlayerName);
			this.Controls.Add(this.pbPlayerHealth);
			this.Controls.Add(this.btnAttack);
			this.Controls.Add(this.lblDragonHealth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbDragonHealth);
			this.Name = "BattleState";
			this.Size = new System.Drawing.Size(621, 405);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar pbDragonHealth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDragonHealth;
		private System.Windows.Forms.Button btnAttack;
		private System.Windows.Forms.Label lbPlayerHealth;
		private System.Windows.Forms.Label lbPlayerName;
		private System.Windows.Forms.ProgressBar pbPlayerHealth;
		private System.Windows.Forms.ListBox lbPlayers;
	}
}
