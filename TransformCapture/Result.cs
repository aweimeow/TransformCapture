using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TransformCapture
{
	public partial class Result : Form
	{
		public int width = 0;
		public int height = 0;
		public Point[] pos = new Point[4];
		public Bitmap oimage = null;
		public Bitmap nimage = null;
		public Result()
		{
			InitializeComponent();
		}

		private void Result_Load(object sender, EventArgs e)
		{
			this.Location = new Point(0, 0);
		}

		public void dotransform()
		{
			nimage = new Bitmap(oimage.Width, oimage.Height);
			for(int i = 0; i<nimage.Width; i++)
			{
				for(int j = 0; j<nimage.Height; j++)
				{
					nimage.SetPixel(i, j, getColor(i, j));
				}
			}
			PB_res.Width = nimage.Width;
			PB_res.Height = nimage.Height;
			PB_res.Image = nimage;
			
		}
		private Color getColor(int posX, int posY)
		{
			Point x1, x2, ans; // 2 point linked to a line
			//double x1tox2; //long for x1 to x2
			Color ret;
			x1 = new Point((pos[0].X+(int)(((double)posX / nimage.Width) * (pos[1].X - pos[0].X))), (pos[0].Y+(int)(((double)posX / nimage.Width) * (pos[1].Y - pos[0].Y))));
			x2 = new Point((pos[3].X+(int)(((double)posX / nimage.Width) * (pos[2].X - pos[3].X))), (pos[3].Y+(int)(((double)posX / nimage.Width) * (pos[2].Y - pos[3].Y))));
			//x1tox2 = Math.Pow((Math.Pow((x2.X-x1.X), 2)+Math.Pow((x2.Y-x1.Y), 2)), 0.5);
			ans = new Point((x1.X+(int)(((double)posY / nimage.Height) * (x2.X - x1.X))), (x1.Y+(int)(((double)posY / nimage.Height) * (x2.Y - x1.Y))));
			ret = oimage.GetPixel(ans.X, ans.Y);
			return ret;
		}

		private void MSI_save_Click(object sender, EventArgs e)
		{
			SaveFileDialog SFD = new SaveFileDialog();
			SFD.Filter = "Jpeg Image|*.jpg";
			SFD.Title = "Where you want to save Picture ?";
			if(SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				PB_res.Image.Save(SFD.FileName, ImageFormat.Jpeg);
			}
			
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormCollection forms = Application.OpenForms;
			for (int i = 0; i < forms.Count; i++)
				forms[i].Close();
		}
	}
}
