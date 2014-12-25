namespace TransformCapture
{
	partial class FullScreen
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
			this.PB_FS = new System.Windows.Forms.PictureBox();
			this.Timer_sleep = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.PB_FS)).BeginInit();
			this.SuspendLayout();
			// 
			// PB_FS
			// 
			this.PB_FS.BackColor = System.Drawing.Color.Transparent;
			this.PB_FS.Location = new System.Drawing.Point(36, 28);
			this.PB_FS.Name = "PB_FS";
			this.PB_FS.Size = new System.Drawing.Size(299, 121);
			this.PB_FS.TabIndex = 0;
			this.PB_FS.TabStop = false;
			this.PB_FS.Click += new System.EventHandler(this.PB_FS_Click);
			this.PB_FS.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_FS_Paint);
			this.PB_FS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_FS_MouseMove);
			// 
			// Timer_sleep
			// 
			this.Timer_sleep.Tick += new System.EventHandler(this.Timer_sleep_Tick);
			// 
			// FullScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 307);
			this.Controls.Add(this.PB_FS);
			this.Name = "FullScreen";
			this.Text = "FullScreen";
			((System.ComponentModel.ISupportInitialize)(this.PB_FS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.PictureBox PB_FS;
		private System.Windows.Forms.Timer Timer_sleep;

	}
}