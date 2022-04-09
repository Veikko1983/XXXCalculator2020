using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XXXCalculator2020
{
	

	//This Class is the player wörm
	class Piece : PictureBox
	{
		                          
		public Piece(int x , int y)  // 800, 400 mid point
		{
			//Creating Picturebox
			Location = new System.Drawing.Point(x , y);
			Size = new System.Drawing.Size(20, 20);
			Image = Properties.Resources.wormbody;
			SizeMode = PictureBoxSizeMode.StretchImage;
			BringToFront();       
			Enabled = false;
			
		}
	}

	
}
