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
	
	public partial class WarningTextForm : Form
	{
		int m_TimerNumbers = 64;
		readonly Timer m_TimerToMainMenuForm = new Timer();
		readonly Timer m_TimerToTimerNumber = new Timer();
		readonly WindowsMediaPlayer m_WelcomeToCalcSound = new WindowsMediaPlayer();
		public WarningTextForm()
		{
			InitializeComponent();
			this.CenterToScreen();  // form location on windowns desktop

			Cursor.Position = new Point(750, 400);
			Cursor.Show();
			TimerToTimerNumber();
			#region Timer before this form close

			m_TimerToMainMenuForm.Interval = 64000;   // time, how long time will last (1000 = 1 sec.)
			m_TimerToMainMenuForm.Tick += new EventHandler(Timer_Tick);
			m_TimerToMainMenuForm.Start();
			

			void Timer_Tick(object sender, EventArgs e)
			{
					
									
				m_TimerToMainMenuForm.Stop();
				m_TimerToTimerNumber.Stop();
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
				//Cursor.Show();
				m_WelcomeToCalcSound.URL = "WelcomeToXXX.mp3";
				m_WelcomeToCalcSound.controls.play();
				m_WelcomeToCalcSound.settings.playCount = 1;
				m_WelcomeToCalcSound.settings.volume = 90;
				LoadingBox_gif.Dispose();
				
				this.Close();


			}
		}
		#endregion

		#region Timer To TimerNumber
		private void TimerToTimerNumber()
		{
			try
			{
				m_TimerToTimerNumber.Interval = 1000;   // time, how long time will last (1000 = 1 sec.)
				m_TimerToTimerNumber.Tick += new EventHandler(Timer_Tick2);
				m_TimerToTimerNumber.Start();

				void Timer_Tick2(object sender, EventArgs e)
				{

					m_TimerNumbers -= 1;
					Timer_textbox.Text = m_TimerNumbers.ToString();

					

				}
			}
			catch
			{

			}
		}

				
		
		#endregion                          
		private void MainMenu_Button_Click(object sender, EventArgs e)
		{
			try
			{
				m_TimerToMainMenuForm.Stop();
				m_TimerToTimerNumber.Stop();
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
				//Cursor.Show();
				m_WelcomeToCalcSound.URL = "WelcomeToXXX.mp3";
				m_WelcomeToCalcSound.controls.play();
				m_WelcomeToCalcSound.settings.playCount = 1;
				m_WelcomeToCalcSound.settings.volume = 90;
				LoadingBox_gif.Dispose();

				this.Close();
			}
			catch
			{

			}
	    }

		private void MainMenu_Button_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				MainMenu_Button.BackColor = Color.Red;
				Cursor = Cursors.Hand;
				Skip_textBox.Visible = true;
			}
			catch
			{

			}
		}

		private void MainMenu_Button_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				MainMenu_Button.BackColor = Color.Black;
				Cursor = Cursors.Default;
				Skip_textBox.Visible = false;
			}
			catch
			{

			}
		}
	}
}
