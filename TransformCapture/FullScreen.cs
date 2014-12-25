using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformCapture
{

	public partial class FullScreen : Form
	{
		Result Res = null;
		public Bitmap savedImage = null;
		
		Point lastPoint = new Point(-1, -1);
		private Boolean first = false;
		private int count = 0;	//Count for the Timer, Check for great FS image
		private Point[] pos = new Point[4];	//Point array to save 4 position
		public int ClickTime = -1;	//Make sure there is only 4 position

		public FullScreen()
		{
			InitializeComponent();
		}

		// if mouse move, call DrawLine
		private void PB_FS_MouseMove(object sender, MouseEventArgs e)
		{
			if(first)
			{
				if (lastPoint.X >= 0)
					DrawReversibleLine(lastPoint);
				lastPoint = e.Location;
				DrawReversibleLine(lastPoint);
			}
			else
			{
				Timer_sleep.Enabled = true;
			}
		}

		// Draw the Line that is cross
		private void DrawReversibleLine(Point p)
		{
			ControlPaint.DrawReversibleLine(
				PB_FS.PointToScreen(new Point(0, p.Y)),
				PB_FS.PointToScreen(new Point(PB_FS.Width, p.Y)),
				Color.Red);
			ControlPaint.DrawReversibleLine(
				PB_FS.PointToScreen(new Point(p.X, 0)),
				PB_FS.PointToScreen(new Point(p.X, PB_FS.Height)),
				Color.Red);
		}

		//I have to sure there is a full picture without wrong cross
		private void Timer_sleep_Tick(object sender, EventArgs e)
		{
			count++;
			if (count == 5)
			{
				first = true;
				Timer_sleep.Enabled = false;
			}
		}

		//When it collect 4 click, display the 4 point location
		private void PB_FS_Click(object sender, EventArgs e)
		{
			MouseEventArgs me = (MouseEventArgs)e;
			ClickTime++;
			pos[ClickTime] = me.Location;
			PB_FS.Invalidate();
			if(ClickTime == 3)
			{
				ActivateResForm();
				//this.Close();
			}
		}

		private void ActivateResForm()
		{
			if(Res != null && !Res.IsDisposed)
			{
				if (Res.WindowState == FormWindowState.Minimized)
					Res.WindowState = FormWindowState.Normal;
				Res.Activate();
			}
			else
			{
				int startx, starty;
				startx = SPX(pos);
				starty = SPY(pos);
				Res = new Result();
				Res.Show();
				Res.WindowState = FormWindowState.Normal;
				Rectangle r = new Rectangle(startx, starty, maxwidth(pos), maxheight(pos));
				Res.Width = r.Width;
				Res.Height =r.Height+65;
				Res.Location = new Point((int)(Screen.PrimaryScreen.Bounds.Height * 0.2), (int)(Screen.PrimaryScreen.Bounds.Height * 0.2));
				Res.oimage = CutImage(savedImage, r);
				Res.PB_res.Width = r.Width;
				Res.PB_res.Height = r.Height;
				Res.PB_res.Location = new Point(0,Res.MS.Height);
				Res.PB_res.Image = Res.oimage;
				for (int i = 0; i < 4; i++ )
				{
					Res.pos[i].X = pos[i].X - startx;
					Res.pos[i].Y = pos[i].Y - starty;
				}
					Res.transform();
			}
		}
		
		/////Get the zone for cutted image 
		private Bitmap CutImage(Bitmap src, Rectangle section)
		{
			Bitmap cutted = new Bitmap(section.Width, section.Height);
			Graphics g = Graphics.FromImage(cutted);
			g.DrawImage(src, 0, 0, section, GraphicsUnit.Pixel);
			return cutted;
		}

		//calc the output size should be
		private int maxwidth(Point[] pos)
		{
			int min = pos[0].X, max = pos[0].X;
			for (int i = 1; i < 4; i++ )
			{
				if (pos[i].X < min)
					min = pos[i].X;
				if (pos[i].X > max)
					max = pos[i].X;
			}
				return (max - min);
		}
		private int maxheight(Point[] pos)
		{
			int min = pos[0].Y, max = pos[0].Y;
			for (int i = 1; i < 4; i++)
			{
				if (pos[i].Y < min)
					min = pos[i].Y;
				if (pos[i].Y > max)
					max = pos[i].Y;
			}
			return (max - min);
		}
		private int SPX(Point[] pos)
		{
			int startX = pos[0].X;
			for(int i = 1; i<4; i++)
			{
				if (pos[i].X < startX)
					startX = pos[i].X;
			}
			return startX;
		}
		private int SPY(Point[] pos)
		{
			int startY = pos[0].Y;
			for(int i = 1; i<4; i++)
			{
				if (pos[i].Y < startY)
					startY = pos[i].Y;
			}
			return startY;
		}
		
		private void PB_FS_Paint(object sender, PaintEventArgs e)
		{
			Pen p = new Pen(Color.Red);
			if(ClickTime>0)
			{
				for(int i = 0; i<ClickTime; i++)
				{
					e.Graphics.DrawLine(p, pos[i], pos[i+1]);
				}
			}
			if(ClickTime==3)
			{
				var m = MessageBox.Show("!!");
				e.Graphics.DrawLine(p, pos[0], pos[3]);
			}
		}
	}
}
