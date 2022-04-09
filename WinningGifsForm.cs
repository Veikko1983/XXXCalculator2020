using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
namespace XXXCalculator2020
{
	public partial class WinningGifsForm : Form
	{
		
		readonly WindowsMediaPlayer m_MediaPlayer = new WindowsMediaPlayer();
		public WinningGifsForm()
		{
			InitializeComponent();
			this.CenterToScreen();

			m_MediaPlayer.URL = "UWin.mp3";
			m_MediaPlayer.settings.playCount = 80;
			m_MediaPlayer.controls.play();

		}
		#region Quit and Restart Button Clicks and Mouse Enter/Leave
		private void MainMenu_Button_Click(object sender, EventArgs e)
		{
			try
			{
				m_MediaPlayer.controls.stop();
				this.Close();
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
			}
			catch
			{

			}
		}

		private void MainMenu_Button_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				MainMenu_Button.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void MainMenu_Button_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				MainMenu_Button.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}
		private void Quit_Button_Click(object sender, EventArgs e)
		{
			try
			{
				Application.Exit();
			}
			catch
			{

			}
		}

		private void Quit_Button_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				MainMenu_Button.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Quit_Button_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				MainMenu_Button.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}
		#endregion


	}
}
