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
	public partial class Game_Over_Wörm : Form
	{
		public Game_Over_Wörm()
		{
			InitializeComponent();
		}

		private void Game_Over_Wörm_Load(object sender, EventArgs e)
		{
			try
			{
				this.CenterToScreen();
			}
			catch
			{

			}
		}
		#region BACK BUTTON (Mouse Click/Enter and Leave)
		private void Back_button_Click(object sender, EventArgs e)
		{
			try
			{
				WörmSecretGame m_GameFormWörm = new WörmSecretGame();
				m_GameFormWörm.Show();
				this.Close();
				// If WörmGame Apples and Speed form is open, this will close it
				WörmGameApplesAndSpeedForm m_WörmGameApplesAndSpeedForm = (WörmGameApplesAndSpeedForm)Application.OpenForms["WörmGameApplesAndSpeedForm"];
				m_WörmGameApplesAndSpeedForm.Close();
			}
			catch
			{

			}
		}
		private void Back_button_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Back_button.BackColor = Color.Red;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Back_button_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Back_button.BackColor = Color.White;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		#endregion


	}
}
