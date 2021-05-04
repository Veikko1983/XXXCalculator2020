using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace XXXCalculator2020
{
	public partial class Lightshow : Form
	{
		readonly WindowsMediaPlayer m_Music = new WindowsMediaPlayer();
		
		public Lightshow()
		{
			InitializeComponent();

			m_Music.controls.stop();
			m_Music.URL = "Lightshow.mp3";
			m_Music.settings.playCount = 60;
			m_Music.controls.play();

		}

		           
		#region BackButton Mouse Click/Enter and Leave
		private void BackButtonClick(object sender, EventArgs e)
		{
						
			try
			{
				//HelloForm m_HelloForm = new HelloForm();
				//MainMenuForm m_MainMenuF = new MainMenuForm();
				//m_Music.controls.stop();
								
				//this.Hide();
				//m_MainMenuF.Show();
				//m_HelloForm.Hide();

				Application.Restart();
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
