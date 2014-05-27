namespace Arena
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.msTopBar = new System.Windows.Forms.MenuStrip();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uiGameArea = new Arena.GameAreaUserControl();
			this.msTopBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// msTopBar
			// 
			this.msTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
			this.msTopBar.Location = new System.Drawing.Point(0, 0);
			this.msTopBar.Name = "msTopBar";
			this.msTopBar.Size = new System.Drawing.Size(605, 24);
			this.msTopBar.TabIndex = 0;
			this.msTopBar.Text = "msTopBar";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToolStripMenuItem,
            this.connectToolStripMenuItem});
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.newGameToolStripMenuItem.Text = "New Game";
			// 
			// hostToolStripMenuItem
			// 
			this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
			this.hostToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.hostToolStripMenuItem.Text = "Host...";
			this.hostToolStripMenuItem.Click += new System.EventHandler(this.hostToolStripMenuItem_Click);
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.connectToolStripMenuItem.Text = "Connect...";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// uiGameArea
			// 
			this.uiGameArea.Arena = null;
			this.uiGameArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiGameArea.Location = new System.Drawing.Point(0, 24);
			this.uiGameArea.Name = "uiGameArea";
			this.uiGameArea.Size = new System.Drawing.Size(605, 481);
			this.uiGameArea.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 505);
			this.Controls.Add(this.uiGameArea);
			this.Controls.Add(this.msTopBar);
			this.MainMenuStrip = this.msTopBar;
			this.Name = "MainForm";
			this.Text = "Arena";
			this.msTopBar.ResumeLayout(false);
			this.msTopBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msTopBar;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private GameAreaUserControl uiGameArea;
	}
}

