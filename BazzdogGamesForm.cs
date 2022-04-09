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
	public partial class BazzdogGamesForm : Form
	{
		readonly Timer m_TimeUntilMainMenuStarts = new Timer();
		readonly WindowsMediaPlayer m_BazzDogGamesTune = new WindowsMediaPlayer();
		
		[STAThread]    // Form that starts first (MainForm)Project/XXXCalculator2020Properties/Application/StartUpObject
		static void Main()
		{

			Application.Run(new BazzdogGamesForm());
			//IMPORTANT TO KNOW!!!!
			// Bug or feature? If gamer is using multible monitors, game will start monitor where the mouse is located. 
		}
		public BazzdogGamesForm()
		{
			InitializeComponent();
			//this.TopMost = true;  // Uses only default screen(didn`t work )
			CenterToScreen();
			//Cursor.Clip = this.Bounds;  // mouse can`t leave form bounds
			Cursor.Position = new Point(750, 400);
			Cursor.Hide();
			// try to do infinite loop to windowns cursor so the user can`t move it
						
			m_BazzDogGamesTune.URL = "BazzDogGames.mp3";
			m_BazzDogGamesTune.settings.playCount = 1;
			m_BazzDogGamesTune.controls.play();
			m_BazzDogGamesTune.settings.volume = 90;

			m_TimeUntilMainMenuStarts.Interval = 10000;   // time, how long time will last (1000 = 1 sec.)
			m_TimeUntilMainMenuStarts.Tick += new EventHandler(Timer_Tick);
			m_TimeUntilMainMenuStarts.Start();  

			void Timer_Tick(object sender, EventArgs e)
			{
				m_TimeUntilMainMenuStarts.Stop();
				m_BazzDogGamesTune.controls.stop();
				Bazzdog_gif1.Dispose();
				Bazzdog_gif2.Dispose();
				Bazzdog_Gif3.Dispose();
				this.Hide(); // U can`t close the main form, only hide it.
				//MainMenuForm m_MainMenuForm = new MainMenuForm();
				//m_MainMenuForm.Show();
				//Cursor.Show();
				WarningTextForm m_WarningTextForm = new WarningTextForm();
				m_WarningTextForm.Show();
				
				//m_WelcomeToCalcSound.URL = "WelcomeToXXX.mp3";
				//m_WelcomeToCalcSound.controls.play();
				//m_WelcomeToCalcSound.settings.playCount = 1;
				//m_WelcomeToCalcSound.settings.volume = 90;

			}
		}
	}
}
