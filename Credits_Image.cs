using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace XXXCalculator2020
{
	public partial class Credits_Image : Form
	{
		readonly WindowsMediaPlayer m_Music = new WindowsMediaPlayer();

		public Credits_Image()
		{
			InitializeComponent();
			CenterToParent();

			m_Music.URL = "CreditsSong.mp3";
			m_Music.settings.playCount = 1;
			m_Music.settings.setMode("Loop", true);
			m_Music.controls.play();
            

		}
		#region CLOSE_FORM_BUTTON, Mouse_Enter/Leave

		private void Credits_CloseButtonClick(object sender, EventArgs e)  //Close this Form
		{
			try
			{

				m_Music.controls.stop();
				this.Close();
				MainMenuForm M_MainMenuForm = new MainMenuForm();
				M_MainMenuForm.Show();
			}
			catch
			{

			}
		}

		private void CreditsButtonCloseMouEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				Credits_CloseButton.BackColor = Color.Red;
				Back_textBox.Visible = true;
			}
			catch
			{

			}
		}

		private void CreditsButtonCloseMouLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				Credits_CloseButton.BackColor = Color.White;
				Back_textBox.Visible = false;
			}
			catch
			{

			}
		}
		#endregion
	}
}
