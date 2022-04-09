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
	public partial class HowToPlayForm : Form
	{
		//readonly MainMenuForm m_MainMenuForm = new MainMenuForm();  // if this is here it will start it automatically in background(Music.ech...)
		readonly WindowsMediaPlayer m_MusicPlayer = new WindowsMediaPlayer();
		public HowToPlayForm()
		{
			InitializeComponent();
			this.CenterToScreen();  // puts this form center to screen when this form is activate
			MusicPlayer();
		}

		#region Exit Button (Click,Mouse Enter/Leave)

		private void CloseFormButton_Click(object sender, EventArgs e)
		{
			try
			{
				m_MusicPlayer.controls.stop();
				this.Close();
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
				ItsDancePartyForm m_ItsDancePartyForm = (ItsDancePartyForm)Application.OpenForms["ItsDancePartyForm"];
				m_ItsDancePartyForm.Close();
				ItsDanceParty2Form m_ItsDanceParty2Form = (ItsDanceParty2Form)Application.OpenForms["ItsDanceParty2Form"];
				m_ItsDanceParty2Form.Close();
			}
			catch
			{

			}
		}

		private void CloseFormButton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				CloseFormButton.BackColor = Color.Red;
				Back_textBox.Visible = true;
			}
			catch
			{

			}
		}

		private void CloseFormButton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				CloseFormButton.BackColor = Color.White;
				Back_textBox.Visible = false;
			}
			catch
			{

			}
		}
		#endregion

		#region MusicPlayer
		private void MusicPlayer()
		{
			try
			{
				m_MusicPlayer.URL = "HowToPlayMusic.mp3";
				m_MusicPlayer.settings.playCount = 1;
				m_MusicPlayer.settings.setMode("Loop", true);
				m_MusicPlayer.settings.volume = 90;
				m_MusicPlayer.controls.play();
			}
			catch
			{

			}
		}

		#endregion
	}
}
