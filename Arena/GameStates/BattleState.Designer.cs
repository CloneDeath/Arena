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
			this.label2 = new System.Windows.Forms.Label();
			this.lblActionPoints = new System.Windows.Forms.Label();
			this.btnHeal = new System.Windows.Forms.Button();
			this.lblAttackInfo = new System.Windows.Forms.Label();
			this.lblHealInfo = new System.Windows.Forms.Label();
			this.lblReviveInfo = new System.Windows.Forms.Label();
			this.btnRevive = new System.Windows.Forms.Button();
			this.lblFierceAttackInfo = new System.Windows.Forms.Label();
			this.btnFierceAttack = new System.Windows.Forms.Button();
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 338);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Action Points:";
			// 
			// lblActionPoints
			// 
			this.lblActionPoints.AutoSize = true;
			this.lblActionPoints.Location = new System.Drawing.Point(338, 338);
			this.lblActionPoints.Name = "lblActionPoints";
			this.lblActionPoints.Size = new System.Drawing.Size(71, 13);
			this.lblActionPoints.TabIndex = 9;
			this.lblActionPoints.Text = "#actionpoints";
			// 
			// btnHeal
			// 
			this.btnHeal.Location = new System.Drawing.Point(316, 366);
			this.btnHeal.Name = "btnHeal";
			this.btnHeal.Size = new System.Drawing.Size(93, 23);
			this.btnHeal.TabIndex = 10;
			this.btnHeal.Text = "Heal";
			this.btnHeal.UseVisualStyleBackColor = true;
			this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
			// 
			// lblAttackInfo
			// 
			this.lblAttackInfo.AutoSize = true;
			this.lblAttackInfo.Location = new System.Drawing.Point(121, 371);
			this.lblAttackInfo.Name = "lblAttackInfo";
			this.lblAttackInfo.Size = new System.Drawing.Size(115, 13);
			this.lblAttackInfo.TabIndex = 11;
			this.lblAttackInfo.Text = "AP Cost: 1, Damage: 1";
			// 
			// lblHealInfo
			// 
			this.lblHealInfo.AutoSize = true;
			this.lblHealInfo.Location = new System.Drawing.Point(415, 371);
			this.lblHealInfo.Name = "lblHealInfo";
			this.lblHealInfo.Size = new System.Drawing.Size(111, 13);
			this.lblHealInfo.TabIndex = 12;
			this.lblHealInfo.Text = "AP Cost: 3, Heals 3hp";
			// 
			// lblReviveInfo
			// 
			this.lblReviveInfo.AutoSize = true;
			this.lblReviveInfo.Location = new System.Drawing.Point(415, 400);
			this.lblReviveInfo.Name = "lblReviveInfo";
			this.lblReviveInfo.Size = new System.Drawing.Size(174, 13);
			this.lblReviveInfo.TabIndex = 14;
			this.lblReviveInfo.Text = "AP Cost: 8, Revives and Heals 3hp";
			// 
			// btnRevive
			// 
			this.btnRevive.Location = new System.Drawing.Point(316, 395);
			this.btnRevive.Name = "btnRevive";
			this.btnRevive.Size = new System.Drawing.Size(93, 23);
			this.btnRevive.TabIndex = 13;
			this.btnRevive.Text = "Revive";
			this.btnRevive.UseVisualStyleBackColor = true;
			this.btnRevive.Click += new System.EventHandler(this.btnRevive_Click);
			// 
			// lblFierceAttackInfo
			// 
			this.lblFierceAttackInfo.AutoSize = true;
			this.lblFierceAttackInfo.Location = new System.Drawing.Point(121, 400);
			this.lblFierceAttackInfo.Name = "lblFierceAttackInfo";
			this.lblFierceAttackInfo.Size = new System.Drawing.Size(178, 13);
			this.lblFierceAttackInfo.TabIndex = 16;
			this.lblFierceAttackInfo.Text = "AP Cost: 5, HP Cost: 6, Damage: 10";
			// 
			// btnFierceAttack
			// 
			this.btnFierceAttack.Location = new System.Drawing.Point(22, 395);
			this.btnFierceAttack.Name = "btnFierceAttack";
			this.btnFierceAttack.Size = new System.Drawing.Size(93, 23);
			this.btnFierceAttack.TabIndex = 15;
			this.btnFierceAttack.Text = "Fierce Attack";
			this.btnFierceAttack.UseVisualStyleBackColor = true;
			this.btnFierceAttack.Click += new System.EventHandler(this.btnFierceAttack_Click);
			// 
			// BattleState
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblFierceAttackInfo);
			this.Controls.Add(this.btnFierceAttack);
			this.Controls.Add(this.lblReviveInfo);
			this.Controls.Add(this.btnRevive);
			this.Controls.Add(this.lblHealInfo);
			this.Controls.Add(this.lblAttackInfo);
			this.Controls.Add(this.btnHeal);
			this.Controls.Add(this.lblActionPoints);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbPlayers);
			this.Controls.Add(this.lbPlayerHealth);
			this.Controls.Add(this.lbPlayerName);
			this.Controls.Add(this.pbPlayerHealth);
			this.Controls.Add(this.btnAttack);
			this.Controls.Add(this.lblDragonHealth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbDragonHealth);
			this.Name = "BattleState";
			this.Size = new System.Drawing.Size(621, 461);
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblActionPoints;
		private System.Windows.Forms.Button btnHeal;
		private System.Windows.Forms.Label lblAttackInfo;
		private System.Windows.Forms.Label lblHealInfo;
		private System.Windows.Forms.Label lblReviveInfo;
		private System.Windows.Forms.Button btnRevive;
		private System.Windows.Forms.Label lblFierceAttackInfo;
		private System.Windows.Forms.Button btnFierceAttack;
	}
}
