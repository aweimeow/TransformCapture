using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace TransformCapture
{
    public partial class Form1 : Form
    {
		// Import Dll file to Get a real fullScreen ////////////
		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(int hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
		[DllImport("user32.dll")]
		public static extern int GetSystemMetrics(int screensize);
		public const int SM_CXSCREEN = 0;
		public const int SM_CYSCREEN = 1;
		private static IntPtr HWND_TOP = IntPtr.Zero;
		private const int SWP_SHOWWINDOW = 64;
		////////////////////////////////////////////////////////
		private Bitmap savedImage = null;
		FullScreen FS = null;

        public Form1()
        {
            InitializeComponent();
        }
		//If press on Btn_Capture Call Create FullScreen Form
        private void Btn_Capture_Click(object sender, EventArgs e)
        {
			ActivateFSForm();
        }

		//Use this function to get Full Screen Image
		private void GetFullScreen()
		{
			Bitmap myImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			Graphics g = Graphics.FromImage(myImage);
			g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)); 
			try
			{
				savedImage = myImage;
				FS.BackgroundImage = myImage;
				FS.ClickTime = -1;
				FS.PB_FS.BackColor = Color.Transparent;
				FS.savedImage = myImage;
			}
			catch
			{
				var result = MessageBox.Show("Error Happened, Try it again !");
			}
		}

		//Create FullScreen Form
		private void ActivateFSForm()
		{
			if(FS != null && !FS.IsDisposed)
			{
				if(FS.WindowState == FormWindowState.Minimized)
					FS.WindowState = FormWindowState.Normal;
				FS.Activate();
			}
			else
			{
				FS = new FullScreen();
				FS.Show();
				FS.WindowState = FormWindowState.Normal;
				FS.FormBorderStyle = FormBorderStyle.None;
				SetWindowPos((int)FS.Handle, HWND_TOP, 0, 0, GetSystemMetrics(SM_CXSCREEN), GetSystemMetrics(SM_CYSCREEN), SWP_SHOWWINDOW);
				FS.PB_FS.Location = FS.Location;
				FS.PB_FS.Width = FS.Width;
				FS.PB_FS.Height = FS.Height;
				GetFullScreen();
			}
		}

		//Do a for loop to close all opened Form
        private void Btn_End_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            for (int i = 0; i < forms.Count; i++)
                forms[i].Close();
        }
    }
}
