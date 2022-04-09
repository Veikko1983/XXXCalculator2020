using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;


namespace XXXCalculator2020
{
	public partial class Lightshow : Form
	{
		readonly WindowsMediaPlayer m_Music = new WindowsMediaPlayer();
		//readonly HelloForm m_HelloForm = new HelloForm();
		public Lightshow()
		{
			InitializeComponent();
			this.CenterToScreen();
			m_Music.controls.stop();
			m_Music.URL = "Lightshow.mp3";
			m_Music.settings.playCount = 1;
			m_Music.settings.setMode("Loop", true);
			m_Music.controls.play();

		}

		           
		#region BackButton Mouse Click/Enter and Leave
		private void BackButtonClick(object sender, EventArgs e)
		{
						
			try
			{
				m_Music.controls.stop();
								
				this.Close();
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
				
				//Application.Restart();

			}
			catch
			{

			}
		}

		private void BackButtonMouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				BackButton.BackColor = Color.Red;
			}
			catch
			{

			}
		}

		private void BackButtonMouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				BackButton.BackColor = Color.White;
			}
			catch
			{

			}
		}
		#endregion
	}
}
