using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XXXCalculator2020
{
	class PieceBody : PictureBox
	{
		public PieceBody(int x, int y)
		{
			Location = new System.Drawing.Point(x, y);
			Size = new System.Drawing.Size(20, 20);
			Image = Properties.Resources.wormbody;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BringToFront();
			Enabled = false;
		}
		
	}
}
