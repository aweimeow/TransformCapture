namespace TransformCapture
{
	partial class Result
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
			this.PB_res = new System.Windows.Forms.PictureBox();
			this.MS = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MSI_save = new System.Windows.Forms.ToolStripMenuItem();
			this.exutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.PB_res)).BeginInit();
			this.MS.SuspendLayout();
			this.SuspendLayout();
			// 
			// PB_res
			// 
			this.PB_res.Location = new System.Drawing.Point(0, 33);
			this.PB_res.Name = "PB_res";
			this.PB_res.Size = new System.Drawing.Size(100, 50);
			this.PB_res.TabIndex = 0;
			this.PB_res.TabStop = false;
			// 
			// MS
			// 
			this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.MS.Location = new System.Drawing.Point(0, 0);
			this.MS.Name = "MS";
			this.MS.Size = new System.Drawing.Size(278, 32);
			this.MS.TabIndex = 1;
			this.MS.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSI_save});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 28);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// MSI_save
			// 
			this.MSI_save.Name = "MSI_save";
			this.MSI_save.Size = new System.Drawing.Size(198, 28);
			this.MSI_save.Text = "Save";
			this.MSI_save.Click += new System.EventHandler(this.MSI_save_Click);
			// 
			// exutToolStripMenuItem
			// 
			this.exutToolStripMenuItem.Name = "exutToolStripMenuItem";
			this.exutToolStripMenuItem.Size = new System.Drawing.Size(12, 28);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Result
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(278, 244);
			this.Controls.Add(this.PB_res);
			this.Controls.Add(this.MS);
			this.Name = "Result";
			this.Text = "Result";
			this.Load += new System.EventHandler(this.Result_Load);
			((System.ComponentModel.ISupportInitialize)(this.PB_res)).EndInit();
			this.MS.ResumeLayout(false);
			this.MS.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.PictureBox PB_res;
		public System.Windows.Forms.MenuStrip MS;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MSI_save;
		private System.Windows.Forms.ToolStripMenuItem exutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

	}
}