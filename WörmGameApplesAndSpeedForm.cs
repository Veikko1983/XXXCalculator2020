using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XXXCalculator2020
{
	public partial class WörmGameApplesAndSpeedForm : Form
	{
		public WörmGameApplesAndSpeedForm()
		{
			InitializeComponent();
		}

		private void WörmGameApplesAndSpeedForm_Load(object sender, EventArgs e)
		{
			try
			{
				this.Location = new Point(0,0); // form location when load
			}
			catch
			{

			}
		}
	}
}
