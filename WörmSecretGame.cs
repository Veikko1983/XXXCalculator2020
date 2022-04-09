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
	public partial class WörmSecretGame : Form
	{
		readonly WindowsMediaPlayer m_MusicPlayer = new WindowsMediaPlayer();
		
		public WörmSecretGame()
		{
			InitializeComponent();
			this.CenterToScreen();  //puts this form to CenterToScreen
			//Cursor.Show();
			WörmStart_gif.Visible = false;
			WörmQuit_gif.Visible = false;
			m_MusicPlayer.URL = "LowBazzTrack.mp3";
			m_MusicPlayer.settings.playCount = 1;
			m_MusicPlayer.settings.setMode("Loop", true);  // Infinite Loop to Music Track
			m_MusicPlayer.settings.volume = 70;
			m_MusicPlayer.controls.play();
		}
		
		private void WörmSecretGame_Load(object sender, EventArgs e)
		{
			try
			{

			}
			catch
			{

			}
		}
		#region ALL BUTTONS(mouse click,leave and enter)
		private void StartGamebutton_Click(object sender, EventArgs e)
		{
			try
			{
				m_MusicPlayer.controls.stop();
				WörmPanel.Dispose(); //HINT!! when panel is disposed, all other objects that are on it will disposed too.

				//StartGamebutton.Dispose();
				//QuitGamebutton.Dispose();
				//WörmMainM1_gif.Dispose();
				//WörmMainM_gif.Dispose();
				//WörmMainM34_gif.Dispose();


				
				this.Close();
				WörmSecretGameTheGameForm m_TheSecretGameWörmForm = new WörmSecretGameTheGameForm();
				m_TheSecretGameWörmForm.Show();

			}
			catch
			{

			}
		}
		private void StartGamebutton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				StartGamebutton.BackColor = Color.Green;
				WörmStart_gif.Visible = true;
			}
			catch
			{

			}
		}

		private void StartGamebutton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				StartGamebutton.BackColor = Color.Black;
				WörmStart_gif.Visible = false;
			}
			catch
			{

			}
		}
		private void QuitGamebutton_Click(object sender, EventArgs e)
		{
			try
			{
				m_MusicPlayer.controls.stop();
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
				this.Close();

			}
			catch
			{

			}
		}
		private void QuitGamebutton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				QuitGamebutton.BackColor = Color.Red;
				WörmQuit_gif.Visible = true;
			}
			catch
			{

			}
		}

		private void QuitGamebutton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				QuitGamebutton.BackColor = Color.Black;
				WörmQuit_gif.Visible = false;
			}
			catch
			{

			}
		}
		#endregion

		

		
	}
}
