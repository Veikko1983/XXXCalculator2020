using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib; // WindowsMediaPlayer


namespace XXXCalculator2020
{


	public partial class NormalModeForm : Form
	{
		public int m_Count;   // button answer,bonus and dice score. ++ means 1 point. m_Count++; 
		public bool m_WasExecuted = false;
		readonly WindowsMediaPlayer m_mediaPlayer = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer MediaPlayerClick = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer LoadingScreenSound = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer m_CompletedSound = new WindowsMediaPlayer();
		readonly ButtonGifs m_ButtonGifs = new ButtonGifs();
		readonly WinningGifsForm m_WinningGifForm = new WinningGifsForm();
		readonly CompletedForm m_CompletedGif = new CompletedForm();
		readonly Timer m_Timer = new Timer();
		//readonly MainMenuForm m_MainMenuForm = new MainMenuForm();
		//readonly NormalModeForm m_NormalMode = new NormalModeForm();

		#region Program Starts, Loadscreen and Timer
		// Startup Object in Project/XXXCalculator2020 properties
		//[STAThread]

		//static void Main()
		//{

		//	Application.Run(new NormalModeForm());

		//}

		public NormalModeForm()
					
		{
			
			InitializeComponent();
			
			LoadScreenTimer.Start();
						
			LoadingScreenSound.URL = "WelcomeNormalRobot.mp3";
			LoadingScreenSound.settings.playCount = 1;
			LoadingScreenSound.controls.play();
			LoadingScreenSound.settings.volume = 70;

			CenterToParent();    // Centers this form with Startgameform

			Cursor.Position = new Point(0,0);  // Puts Cursor 0,0 position on your Windowsdesktop
			Cursor.Hide();

			MusicVolume.Visible = false;
			MusicVolumeText.Visible = false;

			GreenBox1.Visible = false;
			GreenBox2.Visible = false;
			GreenBox3.Visible = false;
			GreenBox4.Visible = false;
			GreenBox5.Visible = false;
			GreenBox6.Visible = false;

			Progressball1.Visible = false;
			Progressball2.Visible = false;
			Progressball3.Visible = false;
			Progressball4.Visible = false;
			Progressball5.Visible = false;
			Progressball6.Visible = false;

			ScoreBoard.Visible = false;
				
			SpaceBackRoundGif.Visible = false;
				
			Lights2Gif.Visible = false;
			pictureBox1.Visible = false;
			MusicStopBoy.Visible = false;
			MusicPlayBoy.Visible = false;
			Bonus.Visible = false;
			IconText.Visible = false;
			Restart.Visible = false;
			Quit_Button.Visible = false;  // quit button
			answer.Visible = false;
			
			Clear_Button.Visible = false;
			Penis.Visible = false;
			Vagina.Visible = false;
			Anal.Visible = false;
			Fart.Visible = false;
			Fist.Visible = false;
			Mouth.Visible = false;
			Finger.Visible = false;
			Wet.Visible = false;
			Shit.Visible = false;
			Urine.Visible = false;
			Blood.Visible = false;
			Sweat.Visible = false;
			Dice.Visible = false;
			
			Bonus.Visible = false;
			
			m_Timer.Interval = 7000;   // time
			m_Timer.Tick += new EventHandler(Timer_Tick);
			m_Timer.Start();  // timer start
			GarbageCollector();
			void Timer_Tick(object sender, EventArgs e)
			{
				
				
				m_Timer.Stop(); // timer stop and loadscreen IsNotActive
				
				Cursor.Position = new Point(0, 0);  // Puts Cursor 0,0 position in your Windows
				Cursor.Show();

				
				MusicVolume.Visible = true;
				MusicVolumeText.Visible = true;

				m_mediaPlayer.URL = "bazzdog.mp3";
				m_mediaPlayer.controls.play();
				m_mediaPlayer.settings.playCount = 100;
				
				

				Lights2Gif.Visible = true;
				SpaceBackRoundGif.Visible = true;

				
				Loading_Gif.Dispose();
				LoadingScreenGif.Dispose();
				BlackSticker.Dispose();


				ScoreBoard.Text = "Score";
				answer.Text = "<3 Welcome & Enjoy <3";

				ScoreBoard.Visible = true;
				
				
				
				SpaceBackRoundGif.Visible = true;
				
				
				Lights2Gif.Visible = true;
				pictureBox1.Visible = true;
				MusicStopBoy.Visible = true;
				MusicPlayBoy.Visible = true;
				Bonus.Visible = true;
				IconText.Visible = true;
				Restart.Visible = true;
				Quit_Button.Visible = true;  
				answer.Visible = true;
				
				Clear_Button.Visible = true;
				Penis.Visible = true;
				Vagina.Visible = true;
				Anal.Visible = true;
				Fart.Visible = true;
				Fist.Visible = true;
				Mouth.Visible = true;
				Finger.Visible = true;
				Wet.Visible = true;
				Shit.Visible = true;
				Urine.Visible = true;
				Blood.Visible = true;
				Sweat.Visible = true;
				Dice.Visible = true;
				
				Progressball1.Visible = true;
				Progressball2.Visible = true;
				Progressball3.Visible = true;
				Progressball4.Visible = true;
				Progressball5.Visible = true;
				Progressball6.Visible = true;

				GarbageCollector();
			}
			
		}
		#endregion

		#region Button Answers and Score to Scoreboard
		public void Penis_Click(object sender, EventArgs e)
		{
			
			try  // Error checker, for the cleaner code
			{
				
				m_Count += 3;   
				
				

				MediaPlayerClick.URL = "Penis.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Penis_Gif_Form.Visible = true;
				
								
				if (answer.Text == "Vagina")
				{
					answer.Text = "Hetero Fucking";
					
					ScoreBoard.Text = m_Count.ToString();  // convert double to string
				}

				else if (answer.Text == "Finger")
				{
					answer.Text = "Tickling The Penis";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Penis Crushing";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Anal Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Blowjob";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Thats a Sex Killer";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Wet Cock";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Scat Style";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Man Pissing";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Reaper Style";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Slipery Cock";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				
				else if ((answer.Text == "Penis") && (answer.Text == "Penis"))
				{
					answer.Text = "Gay Action";
					m_Count-= 5;
															
					//ScoreBoard.Text = ScoreBoard.Text + m_Score;
					//ScoreBoard.Text = (m_Score + double.Parse(ScoreBoard.Text)).ToString();


					ScoreBoard.Text = m_Count.ToString();

					
					
					



				}
				else if (m_mediaPlayer.enabled == false)
				{
					m_ButtonGifs.Enabled = false;
					MediaPlayerClick.controls.stop();
					answer.Clear();
					StopCounting();
				}
				
				else
				{
					answer.Text = "Penis";
				}
               

			}
			catch //Errors goes here
			{

			}

		}

		public void Vagina_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Vagina.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Vagina_Gif_Form.Visible = true;

				if (answer.Text == "Penis")

				{
					answer.Text = "Hetero Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Fart")
				{
					answer.Text = "Pussy Fart";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Brown Hole Riding";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Vagina Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Pussy Licking";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Finger Fucking";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "OOO Wet Vagina";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Brown Pussy OOO";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Menses";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Woman Pissing";
						
					ScoreBoard.Text = m_Count.ToString();

				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Slipery Pussy";
							
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Vagina") && (answer.Text == "Vagina"))
				{
					answer.Text = "Lesbian Action";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (m_mediaPlayer.enabled == false)
				{
					m_ButtonGifs.Enabled = false;
					answer.Clear();
					MediaPlayerClick.controls.stop();
					StopCounting();
				}
				
				else
				{
					answer.Text = "Vagina";
				}
				
				
			}
			catch
			{

			}


		}
		public void Anal_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Anal.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Anal_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Anal Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Brown Hole Riding";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Mega Fart";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Anal Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Ass To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Anal Massage";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Slipery Hole";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Doing Shit";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Golden Hole";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Parasites";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Slipery And Wet";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Anal") && answer.Text == "Anal")
				{
					answer.Text = "Diarrhea";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
				
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Anal";
				}

			}
			catch
			{

			}

		}
		public void Fart_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Fart.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Fart_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Thats a Sex Killer";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Pussy Fart";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Mega Fart";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Smelly Fist";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Dangerous Gas";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Kabooom";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Wet Slipery Poop";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Before The Pooping";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Before The Shitting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Damaged Guts";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Sauna";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Fart") && answer.Text == "Fart")
				{
					answer.Text = "Shit In The Pants";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Fart";
				}
			}
			catch
			{

			}

		}

		public void Fist_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Fist.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Fist_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Penis Crushing";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Vagina Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Anal Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Smelly Fist";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Fist Kisser";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Lot´s Of Pain";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Ready For Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "End Of Anal Fun";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Golden Fist";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "End Of The Battle";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "In Battle";
						
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Fist") && answer.Text == "Fist")
				{
					answer.Text = "Angry";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
				
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Fist";
				}
			}



			catch



			{

			}

		}
		public void Mouth_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Mouth.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Mouth_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Blowjob";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Pussy Licking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Ass To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Dangerous Gas";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Fist Kisser";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Finger Licking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Spitting To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Shitting To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Pissing To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "After The Battle";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Salty Taste";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Mouth") && answer.Text == "Mouth")
				{
					answer.Text = "Kissing";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
				
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Mouth";
				}

			}
			catch
			{

			}

		}
		public void Finger_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Finger.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 60;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Finger_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Tickling The Penis";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Finger Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Anal Massage";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Kabooom";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Lot´s Of Pain";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Finger Licking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Slipery Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Brown Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Golden Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Wounded Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "After Fingering";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Finger") && answer.Text == "Finger")
				{
					answer.Text = "Fingers Cross";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Finger";
				}
			}
			catch
			{

			}

		}
		public void Wet_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Wet.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Wet_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Wet Cock";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "OOO Wet Vagina";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Slipery Hole";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Wet Slipery Poop";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Ready For Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Spitting To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Slipery Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Flabby Poop";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Many Liters";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Sex Games On";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Too Much Sex";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Wet") && (answer.Text == "Wet"))
				{
					answer.Text = "It´s a Rainy Day";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Wet";
				}
			}
			catch
			{

			}

		}
		public void Shit_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Shit.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Shit_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Scat Style";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Brown Pussy OOO";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Doing Shit";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Before The Pooping";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "End Of Anal Fun";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Shitting To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Brown Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Flabby Poop";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Emergency";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Bad Diarrhea";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Long Pooping Time";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Shit") && answer.Text == "Shit")
				{
					answer.Text = "The Pile Of Poop";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Shit";
				}
			}
			catch
			{

			}

		}
		public void Urine_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Urine.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Urine_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Man Pissing";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Woman Pissing";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Golden Hole";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Before The Shitting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "Golden Fist";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Pissing To Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Golden Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Many Liters";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Emergency";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Urinary Tract Inflammation";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Inflamed Urethra";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Urine") && (answer.Text == "Urine"))
				{
					answer.Text = "Golden Shower";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Urine";
				}
			}
			catch
			{

			}

		}
		public void Blood_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Blood.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 80;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Blood_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Reaper Style";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Menses";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Parasites";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Damaged Guts";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "End Of The Battle";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "After The Battle";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "Wounded Finger";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Sex Games On";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Bad Diarrhea";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Urinary Tract Inflammation";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sweat")
				{
					answer.Text = "Hardcore Sex";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Blood") && (answer.Text == "Blood"))
				{
					answer.Text = "Blood Bath";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Blood";
				}
			}
			catch
			{

			}

		}
		public void Sweat_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 3;

				MediaPlayerClick.URL = "Sweat.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Sweat_Gif_Form.Visible = true;

				if (answer.Text == "Penis")
				{
					answer.Text = "Slipery Cock";
					
					ScoreBoard.Text = m_Count.ToString();
				}

				else if (answer.Text == "Vagina")
				{
					answer.Text = "Slipery Pussy";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal")
				{
					answer.Text = "Slipery And Wet";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fart")
				{
					answer.Text = "Sauna";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist")
				{
					answer.Text = "In Battle";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mouth")
				{
					answer.Text = "Salty Taste";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger")
				{
					answer.Text = "After Fingering";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet")
				{
					answer.Text = "Too Much Sex";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit")
				{
					answer.Text = "Long Pooping Time";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Urine")
				{
					answer.Text = "Inflamed Urethra";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood")
				{
					answer.Text = "Hardcore Sex";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if ((answer.Text == "Sweat") && (answer.Text == "Sweat"))
				{
					answer.Text = "Very Wet Combo";
					m_Count -= 5;
					ScoreBoard.Text = m_Count.ToString();
				}
								
				else if (m_mediaPlayer.enabled == false)
				{
					answer.Clear();
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					StopCounting();
				}
				
				else
				{
					answer.Text = "Sweat";
				}
			}
			catch
			{

			}

		}
		#endregion

		#region Buttons(ClearText,Restart(MainMenu),Quit)
		public void Clear_Click(object sender, EventArgs e)
		{
			try
			{
				MediaPlayerClick.URL = "cleartext.mp3";
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.controls.play();

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				answer.Clear();
				IconText.Clear();
				if (ScoreBoard.Text == "Score")
				{
					ScoreBoard.Clear();
				}
				else if (m_mediaPlayer.enabled == false)
				{
					MediaPlayerClick.controls.stop();
				}

			}
			catch
			{

			}
		}
       
		public void Quit_Click(object sender, EventArgs e)
		{
			try
			{

				Application.Exit();
			}
			catch
			{

			}

		}
		
		public void Restart_Click(object sender, EventArgs e)   // Back to Main Menu
		{
			try
			{
				Application.Restart();
			}
			catch
			{

			}

		}
				
		
		#endregion
		
		#region ButtonColor Change. Mousemove and Leave
		public void IconsMouseLeave(object sender, EventArgs e)   //All Icon Buttons but no dice or bonus
		{
			try
			{
				Penis.BackColor = Color.White;
				Vagina.BackColor = Color.White;
				Anal.BackColor = Color.White;
				Fart.BackColor = Color.White;
				Fist.BackColor = Color.White;
				Finger.BackColor = Color.White;
				Blood.BackColor = Color.White;
				Wet.BackColor = Color.White;
				Sweat.BackColor = Color.White;
				Urine.BackColor = Color.White;
				Mouth.BackColor = Color.White;
				Shit.BackColor = Color.White;

				

				IconText.Clear();

				m_ButtonGifs.Penis_Gif_Form.Visible = false;
				m_ButtonGifs.Vagina_Gif_Form.Visible = false;
				m_ButtonGifs.Anal_Gif_Form.Visible = false;
				m_ButtonGifs.Fart_Gif_Form.Visible = false;
				m_ButtonGifs.Fist_Gif_Form.Visible = false;
				m_ButtonGifs.Finger_Gif_Form.Visible = false;
				m_ButtonGifs.Blood_Gif_Form.Visible = false;
				m_ButtonGifs.Wet_Gif_Form.Visible = false;
				m_ButtonGifs.Sweat_Gif_Form.Visible = false;
				m_ButtonGifs.Urine_Gif_Form.Visible = false;
				m_ButtonGifs.Mouth_Gif_Form.Visible = false;
				m_ButtonGifs.Shit_Gif_Form.Visible = false;
				m_ButtonGifs.Dice_Gif_Form.Visible = false;
				m_ButtonGifs.Bonus_Gif_Form.Visible = false;
				m_ButtonGifs.Visible = false;
				

			}
			catch
			{

			}
		}



		public void BonusMouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				IconText.Text = "Bonus";
				Bonus.BackColor = Color.Gray;

			}
			catch
			{

			}

		}

		public void BonusMouseLeave(object sender, EventArgs e)
		{
			try
			{
				Bonus.BackColor = Color.White;
				IconText.Clear();
				m_ButtonGifs.Penis_Gif_Form.Visible = false;
				m_ButtonGifs.Vagina_Gif_Form.Visible = false;
				m_ButtonGifs.Anal_Gif_Form.Visible = false;
				m_ButtonGifs.Fart_Gif_Form.Visible = false;
				m_ButtonGifs.Fist_Gif_Form.Visible = false;
				m_ButtonGifs.Finger_Gif_Form.Visible = false;
				m_ButtonGifs.Blood_Gif_Form.Visible = false;
				m_ButtonGifs.Wet_Gif_Form.Visible = false;
				m_ButtonGifs.Sweat_Gif_Form.Visible = false;
				m_ButtonGifs.Urine_Gif_Form.Visible = false;
				m_ButtonGifs.Mouth_Gif_Form.Visible = false;
				m_ButtonGifs.Shit_Gif_Form.Visible = false;
				m_ButtonGifs.Dice_Gif_Form.Visible = false;
				m_ButtonGifs.Bonus_Gif_Form.Visible = false;
				m_ButtonGifs.Visible = false;

			}
			catch
			{

			}
		}


		public void Clear_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				
				Clear_Button.BackColor = Color.White;
			}
			catch
			{

			}
		}
		
		public void Quit_MouseLeave(object sender, EventArgs e)  
		{
			try
			{
				
				Quit_Button.BackColor = Color.White;
			}
			catch
			{

			}
			
		}



		public void Penis_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Penis.BackColor = Color.Gray;
				IconText.Text = "Penis";



			}
			catch
			{

			}
			
		}

		public void Vagina_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Vagina.BackColor = Color.Gray;
				IconText.Text = "Vagina";
				
			}
			catch
			{

			}
			
		}

		public void Anal_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Anal.BackColor = Color.Gray;
				IconText.Text = "Anal";
				
			}
			catch
			{

			}
			
		}

		public void Fart_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Fart.BackColor = Color.Gray;
				IconText.Text = "Fart";
				
			}
			catch
			{

			}
			
		}

		public void Fist_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Fist.BackColor = Color.Gray;
				IconText.Text = "Fist";
				
			}
			catch
			{

			}
			
		}

		public void Mouth_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Mouth.BackColor = Color.Gray;
				IconText.Text = "Mouth";
				
			}
			catch
			{

			}
			
		}

		public void Finger_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Finger.BackColor = Color.Gray;
				IconText.Text = "Finger";
				
			}
			catch
			{

			}
			
		}

		public void Wet_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Wet.BackColor = Color.Gray;
				IconText.Text = "Wet";
				
			}
			catch
			{

			}
			
		}

		public void Shit_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Shit.BackColor = Color.Gray;
				IconText.Text = "Shit";
				
			}
			catch
			{

			}
			
		}

		public void Urine_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Urine.BackColor = Color.Gray;
				IconText.Text = "Urine";
				
			}
			catch
			{

			}
			
		}

		public void Blood_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Blood.BackColor = Color.Gray;
				IconText.Text = "Blood";
				
			}
			catch
			{

			}
			
		}

		public void Sweat_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Sweat.BackColor = Color.Gray;
				IconText.Text = "Sweat";
				


			}
			catch
			{

			}
			
		}

		

		public void Quit_MouseMove(object sender, MouseEventArgs e) // Quit button
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Quit_Button.BackColor = Color.Gray;
			}
			catch
			{

			}
			
		}

		public void Clear_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Clear_Button.BackColor = Color.Gray;
			}
			catch
			{

			}
			
			
			
			
			
		}
					
				
		public void Restart_Move(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				Restart.BackColor = Color.Gray;
			}
			catch
			{

			}
			
				
		}

		public void Restart_Leave(object sender, EventArgs e)
		{
			try
			{
				Restart.BackColor = Color.White;
			}
			catch
			{

			}
			
		}

		public void AnswerMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (answer.Text == "<3 Welcome & Enjoy <3")
				{
					answer.Clear();
				}
				if (answer.Text == "Warning!!!")
				{
					answer.Text = "Warning!!!";
				}
				else
				{
					answer.Text = "Choose Two Icons And Enjoy the Answer";
					
				}
						
				
			}
			catch
			{

			}
			

		}

		public void AnswerLeave(object sender, EventArgs e)
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}

			
		}

		public void IconText_TextChanged(object sender, EventArgs e)
		{
			try
			{
				
			}
			catch
			{

			}
		}
		

		
		public void MusicPlayMouseEnter(object sender, EventArgs e)
		{
			try
			{
				MusicPlayBoy.BackColor = Color.Gray;
			}
			catch
			{

			}
		}

		public void MusicStopMouseEnter(object sender, EventArgs e)
		{
			try
			{
				MusicStopBoy.BackColor = Color.Gray;
				//answer.Text = "This Will RESET Your Progress!!!";
			}
			catch
			{

			}
		}

		public void MusicPlayMouseLeave(object sender, EventArgs e)
		{
			try
			{
				MusicPlayBoy.BackColor = Color.White;
				
			}
			catch
			{

			}
		}

		public void MusicStopMouseLeave(object sender, EventArgs e)
		{
			try
			{
				MusicStopBoy.BackColor = Color.White;
				answer.Clear();
			}
			catch
			{

			}
		}
		public void DiceMouseLeave(object sender, EventArgs e)
		{
			try
			{
				Dice.BackColor = Color.White;
				IconText.Clear();
				m_ButtonGifs.Penis_Gif_Form.Visible = false;
				m_ButtonGifs.Vagina_Gif_Form.Visible = false;
				m_ButtonGifs.Anal_Gif_Form.Visible = false;
				m_ButtonGifs.Fart_Gif_Form.Visible = false;
				m_ButtonGifs.Fist_Gif_Form.Visible = false;
				m_ButtonGifs.Finger_Gif_Form.Visible = false;
				m_ButtonGifs.Blood_Gif_Form.Visible = false;
				m_ButtonGifs.Wet_Gif_Form.Visible = false;
				m_ButtonGifs.Sweat_Gif_Form.Visible = false;
				m_ButtonGifs.Urine_Gif_Form.Visible = false;
				m_ButtonGifs.Mouth_Gif_Form.Visible = false;
				m_ButtonGifs.Shit_Gif_Form.Visible = false;
				m_ButtonGifs.Dice_Gif_Form.Visible = false;
				m_ButtonGifs.Bonus_Gif_Form.Visible = false;
				m_ButtonGifs.Visible = false;

			}
			catch
			{

			}
		}

		public void DiceMouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				IconText.Text = "Dice";
				Dice.BackColor = Color.Gray;

			}
			catch
			{

			}

		}
		

		
		#endregion

		#region Bonus Answers
		public void Bonus_Click(object sender, EventArgs e)
		{
			try
			{
				m_Count += 8;
				
				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				MediaPlayerClick.URL = "Bonus.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Bonus_Gif_Form.Visible = true;

				if (answer.Text == "Hetero Fucking")
				{
					answer.Text = "Hetero Fucking With A Best Friend";
					
					
					ScoreBoard.Text = m_Count.ToString();
					
				}
				else if (answer.Text == "Tickling The Penis")
				{
					answer.Text = "Slowly Tickling The Penis";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Penis Crushing")
				{
					answer.Text = "Penis Crushing With Both Hands";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal Fucking")
				{
					answer.Text = "Virgin Anal Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal Fisting")
				{
					answer.Text = "First Time Anal Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blowjob")
				{
					answer.Text = "On To The Top Please";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Thats a Sex Killer")
				{
					answer.Text = "But Brazilians Like It A Lot";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery Cock")
				{
					answer.Text = "Slipery Fat Big Long Dick";
					
					ScoreBoard.Text = m_Count.ToString();

				}
				else if (answer.Text == "Scat Style")
				{
					answer.Text = "Scat Style With Germans";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Man Pissing")
				{
					answer.Text = "Man Pissing On Your Face";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Reaper Style")
				{
					answer.Text = "Reaper Style With A Reaper";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery Cock")
				{
					answer.Text = "Slipery Hard Big Dick";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Gay Action")
				{
					answer.Text = "Gay Action With Ten Gays";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Pussy Fart")
				{
					answer.Text = "Big Fucking Pussy Fart In Your Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Brown Hole Riding")
				{
					answer.Text = "Brown Hole Riding With A Dog";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Vagina Fisting")
				{
					answer.Text = "Virgin Vagina Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Pussy Licking")
				{
					answer.Text = "Pussy Licking And Hard Orgasm";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger Fucking")
				{
					answer.Text = "Finger Fucking With Four Fingers";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger Licking")
				{
					answer.Text = "Finger Licking Sucking, Yeah Babe";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fingers Cross")
				{
					answer.Text = "Fingers Cross Then Fingers In The Butt";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "OOO Wet Vagina")
				{
					answer.Text = "Wet Vagina And Wet Dildo";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Brown Pussy OOO")
				{
					answer.Text = "Brown Pussy NOOOOO";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Menses")
				{
					answer.Text = "Menses And Virgin";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Woman Pissing")
				{
					answer.Text = "Woman Pissing On Your Face";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery Pussy")
				{
					answer.Text = "Slipery Pussy And Hard Orgasm";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Lesbian Action")
				{
					answer.Text = "Lesbian Action In The Woods";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Brown Hole Riding")
				{
					answer.Text = "Ride Until U Poop";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Mega Fart")
				{
					answer.Text = "Mega Fart And Lots Of Shit";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal Fisting")
				{
					answer.Text = "Anal Fisting With Brown Fist";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Ass To Mouth")
				{
					answer.Text = "Ass To Mouth Like A Boss";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Anal Massage")
				{
					answer.Text = "Anal Massage Before Pooping";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery Hole")
				{
					answer.Text = "Slipery Big Hole";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Doing Shit")
				{
					answer.Text = "Doing Shit In To The Closet";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Golden Hole")
				{
					answer.Text = "Golden Hole Of Gold";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Golden Fist")
				{
					answer.Text = "Golden Fist Of Gold";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Golden Finger")
				{
					answer.Text = "Golden Finger Of Gold";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Pissing To Mouth")
				{
					answer.Text = "Pissing Your Moms Mouth";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Parasites")
				{
					answer.Text = "Lots Of Worms In Your Anal";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery And Wet")
				{
					answer.Text = "Slipery And Wet Like A Rainy Day";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Diarrhea")
				{
					answer.Text = "Diarrhea And Germans Are Ready For U";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Thats a Sex Killer")
				{
					answer.Text = "And End Of Your Relationship";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Smelly Fist")
				{
					answer.Text = "Smelly Fist With A Surprise";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Dangerous Gas")
				{
					answer.Text = "Gas Chamber";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Kabooom")
				{
					answer.Text = "Like A Dynamite";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet Slipery Poop")
				{
					answer.Text = "AAAAH Feels Gooood";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Before The Pooping")
				{
					answer.Text = "Before And After Good Pooping";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Before The Shitting")
				{
					answer.Text = "Before And After Bad Shitting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Damaged Guts")
				{
					answer.Text = "Damaged Guts And Tapeworms";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sauna")
				{
					answer.Text = "Sauna And Beer";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shit In The Pants")
				{
					answer.Text = "Shit In The Pants Like A Boss";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Penis Crushing")
				{
					answer.Text = "Penis Crushing Like A Boss";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Vagina Fisting")
				{
					answer.Text = "Vagina Fister From Space ";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Fist Kisser")
				{
					answer.Text = "Kiss My Fist Bitch";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Lot´s Of Pain")
				{
					answer.Text = "Make`s U A Man";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Ready For Fisting")
				{
					answer.Text = "Are U Ready Bitch";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "End Of Anal Fun")
				{
					answer.Text = "End Of Your Day";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "End Of The Battle")
				{
					answer.Text = "End Of Fun";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Golden Fist")
				{
					answer.Text = "Fist Of A Legend";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Golden Finger")
				{
					answer.Text = "Finger Of A Legend";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Golden Shower")
				{
					answer.Text = "U Are A Legend";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wounded Finger")
				{
					answer.Text = "That`s Nothing Keep It Going";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "In Battle")
				{
					answer.Text = "Kill Him Like A Boss";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Angry")
				{
					answer.Text = "Breaking All The Furniture";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger Licking")
				{
					answer.Text = "Finger Licking And Then Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Spitting To Mouth")
				{
					answer.Text = "Spitting To Mouth And Then Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shitting To Mouth")
				{
					answer.Text = "Shitting To Mouth And Then Raping";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Pissing To Mouth")
				{
					answer.Text = "Golden Teeths";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "After The Battle")
				{
					answer.Text = "It Fucking Hurts ";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "After Fingering")
				{
					answer.Text = "Feels Good Babe";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Salty Taste")
				{
					answer.Text = "Salty Taste And Salty Feelings";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Kissing")
				{
					answer.Text = "Kissing Like A Child";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger Fucking")
				{
					answer.Text = "Finger Fucking, Do U Have A Little Dig?";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Finger Licking")
				{
					answer.Text = "Finger Licking And Then Fisting";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Brown Finger")
				{
					answer.Text = "Brown Finger Is A Nice Color";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery Finger")
				{
					answer.Text = "Slipery Finger Of Doom";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wounded Finger")
				{
					answer.Text = "Wounded Finger And Lot`s Of Blood";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "OOO Wet Vagina")
				{
					answer.Text = "Wet Vagina And Ready For Fucking";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Slipery Hole")
				{
					answer.Text = "Is It Too Big For U?";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Wet Slipery Poop")
				{
					answer.Text = "Aaah Yeah Babe, It`s Coming!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Ready For Fisting")
				{
					answer.Text = "Are U Ready For Russian Matures?";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Spitting To Mouth")
				{
					answer.Text = "Spit More U Whore";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				
				else if (answer.Text == "Flabby Poop")
				{
					answer.Text = "It`s Too Dangerous!!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Many Liters")
				{
					answer.Text = "Like German Boss";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Sex Games On")
				{
					answer.Text = "Yeah It`s Fucking Time";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Too Much Sex")
				{
					answer.Text = "Don`t Stop Until U Bleed";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "It´s a Rainy Day")
				{
					answer.Text = "Nature Fucking, Hell Yeah!!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Scat Style")
				{
					answer.Text = "The German Soldier Style, LOL!!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Brown Pussy OOO")
				{
					answer.Text = "Enjoy The Shitty Pussy Lips";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Doing Shit")
				{
					answer.Text = "It`s Time To Go Toilet, Sir!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Before The Pooping")
				{
					answer.Text = "NOOOO!!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "End Of Anal Fun")
				{
					answer.Text = "End Of Fun";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Shitting To Mouth")
				{
					answer.Text = " U Are Like Russian Poor Street Whore";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Emergency")
				{
					answer.Text = "Call Ampulance!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Bad Diarrhea")
				{
					answer.Text = "Go Sleep And Rest Good";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Long Pooping Time")
				{
					answer.Text = "Enjoy It!!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "The Pile Of Poop")
				{
					answer.Text = "Nice Job Sir!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				
				else if (answer.Text == "Urinary Tract Inflammation")
				{
					answer.Text = "It Hurts Too Much!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Inflamed Urethra")
				{
					answer.Text = "It`s Time To Take A Break";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Hardcore Sex")
				{
					answer.Text = "Ouh Yeah Bitch!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Blood Bath")
				{
					answer.Text = "Like A Blade Vampire Hunter";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (answer.Text == "Very Wet Combo")
				{
					answer.Text = "This Is A Great Combo, Keep It Going!!!";
					
					ScoreBoard.Text = m_Count.ToString();
				}
				else if (m_mediaPlayer.enabled == false)
				{
					m_ButtonGifs.Enabled = false;
					MediaPlayerClick.controls.stop();
					answer.Clear();
					StopCounting();
				}
				else
				{
					answer.Text = "Bonus";
				}
				

			}
			catch
			{

			}
		}


		#endregion

		#region LoadGreenTimerBox
		public void Timer1_Tick(object sender, EventArgs e)  //Controls LoadTimeBox Animation
		{
			try
			{
				Loading_Gif.Width += 2;
			}
			catch
			{

			}
			
		}
		#endregion

		#region Music Play and Stop

		

		public void MusicPlay(object sender, EventArgs e)
		{
			try
			{
				m_mediaPlayer.URL = "bazzdog.mp3";
				m_mediaPlayer.controls.play();
				pictureBox1.Visible = true;

				Lights2Gif.Visible = true;
				SpaceBackRoundGif.Visible = true;
				answer.Text = "It`s Party Time!!!";
				m_mediaPlayer.enabled = true;
				m_ButtonGifs.Enabled = true;

				FattyTwerk_gif.Visible = false;

			}
			catch
			{

			}
		}

		public void MusicStop(object sender, EventArgs e)
		{
			try
			{
				m_mediaPlayer.controls.stop();
				//pictureBox1.Visible = false;

				//GreenBox1.Visible = false;
				//GreenBox2.Visible = false;
				//GreenBox3.Visible = false;
				//GreenBox4.Visible = false;
				//GreenBox5.Visible = false;
				//GreenBox6.Visible = false;
				//Progressball1.BackColor = Color.White;
				//Progressball2.BackColor = Color.White;
				//Progressball3.BackColor = Color.White;
				//Progressball4.BackColor = Color.White;
				//Progressball5.BackColor = Color.White;
				//Progressball6.BackColor = Color.White;
				
				//Lights2Gif.Visible = false;
				//SpaceBackRoundGif.Visible = false;
				
				answer.Text = "U Are The Party Killer, U Bastard!!!";
				//m_mediaPlayer.enabled = false;
				//m_ButtonGifs.Visible = false;
				//m_ButtonGifs.Enabled = false;

				//m_CompletedGif.Hide();
				//StopCounting();
				//FattyTwerk_gif.Visible = false;
			}
			catch
			{

			}
		}
		#endregion

		#region Dice Answers and Score to Scoreboard
		public void DiceClick(object sender, EventArgs e)
		{
			try
			{
				m_ButtonGifs.Show();
				m_ButtonGifs.Visible = true;
				m_ButtonGifs.Dice_Gif_Form.Visible = true;
			

				MediaPlayerClick.URL = "Dice.mp3";
				MediaPlayerClick.controls.play();
				MediaPlayerClick.settings.playCount = 1;
				MediaPlayerClick.settings.volume = 100;

				FattyTwerk_gif.Visible = false;
				m_CompletedGif.Hide();
				m_Count ++;
								
				ScoreBoard.Text = m_Count.ToString();

				//ScoreBoard.Text = m_ScoreDice.ToString();
				

				int m_Random;
				Random RandomAnswer = new Random();
				m_Random = RandomAnswer.Next(1,89);

				if (m_Random == 1)
				{
					answer.Text = "Hetero Fucking";
				}
				else if (m_Random == 2)
				{
					answer.Text = "Tickling The Penis";
				}
				else if (m_Random == 3)
				{
					answer.Text = "Penis Crushing";
				}
				else if (m_Random == 4)
				{
					answer.Text = "Anal Fucking";
				}
				else if (m_Random == 5)
				{
					answer.Text = "Anal Fisting";
				}
				else if (m_Random == 6)
				{
					answer.Text = "Blowjob";
				}
				else if (m_Random == 7)
				{
					answer.Text = "Thats a Sex Killer";
				}
				else if (m_Random == 8)
				{
					answer.Text = "Slipery Cock";
				}
				else if (m_Random == 9)
				{
					answer.Text = "Scat Style";
				}
				else if (m_Random == 10)
				{
					answer.Text = "Man Pissing";
				}
				else if (m_Random == 11)
				{
					answer.Text = "Reaper Style";
				}
				else if (m_Random == 12)
				{
					answer.Text = "Wet Cock";
				}
				else if (m_Random == 13)
				{
					answer.Text = "Gay Action";
				}
				else if (m_Random == 14)
				{
					answer.Text = "Pussy Fart";
				}
				else if (m_Random == 15)
				{
					answer.Text = "Brown Hole Riding";
				}
				else if (m_Random == 16)
				{
					answer.Text = "Vagina Fisting";
				}
				else if (m_Random == 17)
				{
					answer.Text = "Pussy Licking";
				}
				else if (m_Random == 18)
				{
					answer.Text = "Finger Fucking";
				}
				else if (m_Random == 19)
				{
					answer.Text = "Finger Licking";
				}
				else if (m_Random == 20)
				{
					answer.Text = "Fingers Cross";
				}
				else if (m_Random == 21)
				{
					answer.Text = "OOO Wet Vagina";
				}
				else if (m_Random == 22)
				{
					answer.Text = "Brown Pussy OOO";
				}
				else if (m_Random == 23)
				{
					answer.Text = "Menses";
				}
				else if (m_Random == 24)
				{
					answer.Text = "Woman Pissing";
				}
				else if (m_Random == 25)
				{
					answer.Text = "Slipery Pussy";
				}
				else if (m_Random == 26)
				{
					answer.Text = "Lesbian Action";
				}
				
				else if (m_Random == 27)
				{
					answer.Text = "Mega Fart";
				}
				else if (m_Random == 28)
				{
					answer.Text = "Anal Fisting";
				}
				else if (m_Random == 29)
				{
					answer.Text = "Ass To Mouth";
				}
				else if (m_Random == 30)
				{
					answer.Text = "Anal Massage";
				}
				else if (m_Random == 31)
				{
					answer.Text = "Slipery Hole";
				}
				else if (m_Random == 32)
				{
					answer.Text = "Doing Shit";
				}
				else if (m_Random == 33)
				{
					answer.Text = "Golden Hole";
				}
				else if (m_Random == 34)
				{
					answer.Text = "Parasites";
				}
				else if (m_Random == 35)
				{
					answer.Text = "Slipery And Wet";
				}
				else if (m_Random == 36)
				{
					answer.Text = "Diarrhea";
				}
				
				else if (m_Random == 37)
				{
					answer.Text = "Smelly Fist";
				}
				else if (m_Random == 38)
				{
					answer.Text = "Dangerous Gas";
				}
				else if (m_Random == 39)
				{
					answer.Text = "Kabooom";
				}
				else if (m_Random == 40)
				{
					answer.Text = "Wet Slipery Poop";
				}
				else if (m_Random == 41)
				{
					answer.Text = "Before The Pooping";
				}
				else if (m_Random == 42)
				{
					answer.Text = "Before The Shitting";
				}
				else if (m_Random == 43)
				{
					answer.Text = "Damaged Guts";
				}
				else if (m_Random == 44)
				{
					answer.Text = "Sauna";
				}
				else if (m_Random == 45)
				{
					answer.Text = "Shit In The Pants";
				}
								
				else if (m_Random == 46)
				{
					answer.Text = "Vagina Fisting";
				}
				else if (m_Random == 47)
				{
					answer.Text = "Fist Kisser";
				}
				else if (m_Random == 48)
				{
					answer.Text = "Lot´s Of Pain";
				}
				else if (m_Random == 49)
				{
					answer.Text = "Ready For Fisting";
				}
				else if (m_Random == 50)
				{
					answer.Text = "End Of Anal Fun";
				}
				else if (m_Random == 51)
				{
					answer.Text = "Golden Fist";
				}
				else if (m_Random == 52)
				{
					answer.Text = "Golden Finger";
				}
				else if (m_Random == 53)
				{
					answer.Text = "End Of The Battle";
				}
				else if (m_Random == 54)
				{
					answer.Text = "In Battle";
				}
				else if (m_Random == 55)
				{
					answer.Text = "Angry";
				}
				else if (m_Random == 56)
				{
					answer.Text = "Finger Licking";
				}
				else if (m_Random == 57)
				{
					answer.Text = "Spitting To Mouth";

				}
				else if (m_Random == 58)
				{
					answer.Text = "Shitting To Mouth";

				}
				else if (m_Random == 59)
				{
					answer.Text = "Pissing To Mouth";

				}
				else if (m_Random == 60)
				{
					answer.Text = "After The Battle";

				}
				else if (m_Random == 61)
				{
					answer.Text = "After Fingering";

				}
				else if (m_Random == 62)
				{
					answer.Text = "Salty Taste";

				}
				else if (m_Random == 63)
				{
					answer.Text = "Kissing";

				}
				else if (m_Random == 64)
				{
					answer.Text = "Finger Fucking";

				}
				else if (m_Random == 65)
				{
					answer.Text = "Finger Licking";

				}
				else if (m_Random == 66)
				{
					answer.Text = "Brown Finger";

				}
				else if (m_Random == 67)
				{
					answer.Text = "Slipery Finger";

				}
				else if (m_Random == 68)
				{
					answer.Text = "Wounded Finger";

				}
				else if (m_Random == 69)
				{
					answer.Text = "Wet Slipery Poop";

				}
				else if (m_Random == 70)
				{
					answer.Text = "Flabby Poop";

				}
				else if (m_Random == 71)
				{
					answer.Text = "Many Liters";

				}
				else if (m_Random == 72)
				{
					answer.Text = "Sex Games On";

				}
				else if (m_Random == 73)
				{
					answer.Text = "Too Much Sex";

				}
				else if (m_Random == 74)
				{
					answer.Text = "It´s a Rainy Day";

				}
				else if (m_Random == 75)
				{
					answer.Text = "Emergency";

				}
				else if (m_Random == 76)
				{
					answer.Text = "Doing Shit";

				}
				else if (m_Random == 77)
				{
					answer.Text = "Before The Pooping";

				}
				else if (m_Random == 78)
				{
					answer.Text = "End Of Anal Fun";

				}
				else if (m_Random == 79)
				{
					answer.Text = "Shitting To Mouth";

				}
				else if (m_Random == 80)
				{
					answer.Text = "Bad Diarrhea";

				}
				else if (m_Random == 81)
				{
					answer.Text = "Long Pooping Time";

				}
				else if (m_Random == 82)
				{
					answer.Text = "The Pile Of Poop";

				}
				else if (m_Random == 83)
				{
					answer.Text = "Urinary Tract Inflammation";

				}
				else if (m_Random == 84)
				{
					answer.Text = "Inflamed Urethra";

				}
				else if (m_Random == 85)
				{
					answer.Text = "Golden Shower";

				}
				else if (m_Random == 86)
				{
					answer.Text = "Hardcore Sex";

				}
				else if (m_Random == 87)
				{
					answer.Text = "Blood Bath";

				}
				else if (m_Random == 88)
				{
					answer.Text = "Very Wet Combo";

				}
				 if (m_mediaPlayer.enabled == false)
				{
					MediaPlayerClick.controls.stop();
					m_ButtonGifs.Enabled = false;
					answer.Clear();
					StopCounting();
				}


			}
			catch
			{

			}
		}
		#endregion

		#region Keyboard Control
		public void Keyboard_KeyDown(object sender, KeyEventArgs e)  //Keyboard "disabler"
		{
			try
			{
							

				if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Up) ||
					(e.KeyCode == Keys.Down) || (e.KeyCode == Keys.NumPad4) || (e.KeyCode == Keys.NumPad8)
					|| (e.KeyCode == Keys.NumPad6) || (e.KeyCode == Keys.NumPad2))
				{
					
					answer.Text = "Warning, Enter and Space Keys Will Restart Program!!!";
					FattyTwerk_gif.Visible = false;
				}
				else if (e.KeyCode == Keys.Enter)
				{
					Application.Restart();
					//Penis_Gif.Visible = false;
					//Vagina_Gif.Visible = false;
					//Anal_Gif.Visible = false;
					//Fart_Gif.Visible = false;
					//Fist_Gif.Visible = false;
					//Mouth_Gif.Visible = false;
					//Finger_Gif.Visible = false;
					//Wet_Gif.Visible = false;
					//Shit_Gif.Visible = false;
					//Urine_Gif.Visible = false;
					//Blood_Gif.Visible = false;
					//Sweat_Gif.Visible = false;
					//Dice_Gif.Visible = false;
					//Bonus_Gif.Visible = false;
					//MediaPlayerClick.controls.stop();
					//answer.Clear();
				}
				else if (e.KeyCode == Keys.Space)
				{
					Application.Restart();
					//Penis_Gif.Visible = false;
					//Vagina_Gif.Visible = false;
					//Anal_Gif.Visible = false;
					//Fart_Gif.Visible = false;
					//Fist_Gif.Visible = false;
					//Mouth_Gif.Visible = false;
					//Finger_Gif.Visible = false;
					//Wet_Gif.Visible = false;
					//Shit_Gif.Visible = false;
					//Urine_Gif.Visible = false;
					//Blood_Gif.Visible = false;
					//Sweat_Gif.Visible = false;
					//Dice_Gif.Visible = false;
					//Bonus_Gif.Visible = false;
					//MediaPlayerClick.controls.stop();
					//answer.Clear();
				}
				else if (e.KeyCode == Keys.Tab)
				{
					answer.Text = "Warning, Enter and Space Keys Will Restart Program!!!";
					//e.Handled = false;
					//this.Enabled = false;
					FattyTwerk_gif.Visible = false;

				}


			}
			catch
			{

			}
			
		}

		
		
		public void Keyboard_KeyUp(object sender, KeyEventArgs e) //Keyboard "disabler"
		{
			try
			{
				

				if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Up) ||
					(e.KeyCode == Keys.Down) || (e.KeyCode == Keys.NumPad4) || (e.KeyCode == Keys.NumPad8)
					|| (e.KeyCode == Keys.NumPad6) || (e.KeyCode == Keys.NumPad2))
				{
					FattyTwerk_gif.Visible = false;
					answer.Text = "Warning, Enter and Space Keys Will Restart Program!!!";
				}
				else if (e.KeyCode == Keys.Enter)
				{
					Application.Restart();
					//Penis_Gif.Visible = false;
					//Vagina_Gif.Visible = false;
					//Anal_Gif.Visible = false;
					//Fart_Gif.Visible = false;
					//Fist_Gif.Visible = false;
					//Mouth_Gif.Visible = false;
					//Finger_Gif.Visible = false;
					//Wet_Gif.Visible = false;
					//Shit_Gif.Visible = false;
					//Urine_Gif.Visible = false;
					//Blood_Gif.Visible = false;
					//Sweat_Gif.Visible = false;
					//Dice_Gif.Visible = false;
					//Bonus_Gif.Visible = false;
					//MediaPlayerClick.controls.stop();
					//answer.Clear();
				}
				else if (e.KeyCode == Keys.Space)
				{
					Application.Restart();
					//Penis_Gif.Visible = false;
					//Vagina_Gif.Visible = false;
					//Anal_Gif.Visible = false;
					//Fart_Gif.Visible = false;
					//Fist_Gif.Visible = false;
					//Mouth_Gif.Visible = false;
					//Finger_Gif.Visible = false;
					//Wet_Gif.Visible = false;
					//Shit_Gif.Visible = false;
					//Urine_Gif.Visible = false;
					//Blood_Gif.Visible = false;
					//Sweat_Gif.Visible = false;
					//Dice_Gif.Visible = false;
					//Bonus_Gif.Visible = false;
					//MediaPlayerClick.controls.stop();
					//answer.Clear();
				}
				else if (e.KeyCode == Keys.Tab)
				{
					answer.Text = "Warning, Enter and Space Keys Will Restart Program!!!";
					//e.Handled = false;
					//this.Enabled = false;
					FattyTwerk_gif.Visible = false;
				}




			}
			catch
			{

			}
		}
		#endregion

		#region Music Volume 
		public void MusicVolume_Scroll(object sender, ScrollEventArgs e)
		{
			try
			{
				if (MusicVolume.Value == 0)
				{
					m_mediaPlayer.settings.volume = 0;
				}
				else if (MusicVolume.Value == 5)
				{
					m_mediaPlayer.settings.volume = 5;
				}
				else if (MusicVolume.Value == 10)
				{
					m_mediaPlayer.settings.volume = 10;
				}
				else if (MusicVolume.Value == 15)
				{
					m_mediaPlayer.settings.volume = 15;
				}
				else if (MusicVolume.Value == 20)
				{
					m_mediaPlayer.settings.volume = 20;
				}
				else if (MusicVolume.Value == 25)
				{
					m_mediaPlayer.settings.volume = 25;
				}
				else if (MusicVolume.Value == 30)
				{
					m_mediaPlayer.settings.volume = 30;
				}
				else if (MusicVolume.Value == 35)
				{
					m_mediaPlayer.settings.volume = 35;
				}
				else if (MusicVolume.Value == 40)
				{
					m_mediaPlayer.settings.volume = 40;
				}
				else if (MusicVolume.Value == 45)
				{
					m_mediaPlayer.settings.volume = 45;
				}
				else if (MusicVolume.Value == 50)
				{
					m_mediaPlayer.settings.volume = 50;
				}
				else if (MusicVolume.Value == 55)
				{
					m_mediaPlayer.settings.volume = 55;
				}
				else if (MusicVolume.Value == 60)
				{
					m_mediaPlayer.settings.volume = 60;
				}
				else if (MusicVolume.Value == 65)
				{
					m_mediaPlayer.settings.volume = 65;
				}
				else if (MusicVolume.Value == 70)
				{
					m_mediaPlayer.settings.volume = 70;
				}
				else if (MusicVolume.Value == 75)
				{
					m_mediaPlayer.settings.volume = 75;
				}
				else if (MusicVolume.Value == 80)
				{
					m_mediaPlayer.settings.volume = 80;
				}
				else if (MusicVolume.Value == 85)
				{
					m_mediaPlayer.settings.volume = 85;
				}
				else if (MusicVolume.Value == 90)
				{
					m_mediaPlayer.settings.volume = 90;
				}
				else if (MusicVolume.Value == 95)
				{
					m_mediaPlayer.settings.volume = 95;
				}
				else if (MusicVolume.Value == 100)
				{
					m_mediaPlayer.settings.volume = 100;
				}



			}
			catch
			{

			}
			
		}
		#endregion

		#region AnswerTextBox (Congratulations!!),ProgressBoxes/gifs, and WinningGif
		private void AnswerTextBox(object sender, EventArgs e)
		{
			try
			{
				
				// Progressbox activations
				 if ((ScoreBoard.Text == "100") || (ScoreBoard.Text == "101") || (ScoreBoard.Text == "102") || (ScoreBoard.Text == "103") || (ScoreBoard.Text == "104") || (ScoreBoard.Text == "105") || (ScoreBoard.Text == "106") || (ScoreBoard.Text == "107") || (ScoreBoard.Text == "108") || (ScoreBoard.Text == "109") || (ScoreBoard.Text == "110")|| (ScoreBoard.Text == "111")|| (ScoreBoard.Text == "112")|| (ScoreBoard.Text == "113")|| (ScoreBoard.Text == "114")|| (ScoreBoard.Text == "115")|| (ScoreBoard.Text == "116")|| (ScoreBoard.Text == "117")|| (ScoreBoard.Text == "118") || (ScoreBoard.Text == "119") || (ScoreBoard.Text == "120")|| (ScoreBoard.Text == "121") || (ScoreBoard.Text == "122") || (ScoreBoard.Text == "123") || (ScoreBoard.Text == "124") || (ScoreBoard.Text == "125") || (ScoreBoard.Text == "126"))
				 {
					GreenBox1.Visible = true;

					if (!m_WasExecuted)  // Executes only once
					{
						m_CompletedSound.URL = "Completed_Echo.mp3";
						m_CompletedSound.settings.playCount = 1;
						m_CompletedSound.controls.play();
						m_CompletedSound.settings.volume = 100;

						m_CompletedGif.Show();
						m_CompletedGif.Visible = true;
						m_CompletedGif.Activate();

						FattyTwerk_gif.Visible = true;
						m_WasExecuted = true;     // Executes only once

						if (m_CompletedSound.settings.playCount == 1)
						{
							MediaPlayerClick.controls.stop();
						}
					}
												

					

				}
				else if ((ScoreBoard.Text == "400") || (ScoreBoard.Text == "401") || (ScoreBoard.Text == "402") || (ScoreBoard.Text == "403") || (ScoreBoard.Text == "404") || (ScoreBoard.Text == "405") || (ScoreBoard.Text == "406") || (ScoreBoard.Text == "407") || (ScoreBoard.Text == "408") || (ScoreBoard.Text == "409") || (ScoreBoard.Text == "410") || (ScoreBoard.Text == "411") || (ScoreBoard.Text == "412") || (ScoreBoard.Text == "413") || (ScoreBoard.Text == "414") || (ScoreBoard.Text == "415") || (ScoreBoard.Text == "416") || (ScoreBoard.Text == "417") || (ScoreBoard.Text == "418") || (ScoreBoard.Text == "419") || (ScoreBoard.Text == "420") || (ScoreBoard.Text == "421") || (ScoreBoard.Text == "422") || (ScoreBoard.Text == "423") || (ScoreBoard.Text == "424") || (ScoreBoard.Text == "425") || (ScoreBoard.Text == "426") || (ScoreBoard.Text == "427"))
				{
					GreenBox1.Visible = true;
					GreenBox2.Visible = true;

					if (m_WasExecuted)  // Executes only once and now it`s opposite
					{
						m_CompletedSound.URL = "Completed_Echo.mp3";
						m_CompletedSound.settings.playCount = 1;
						m_CompletedSound.controls.play();
						m_CompletedSound.settings.volume = 100;

						m_CompletedGif.Show();
						m_CompletedGif.Visible = true;
						m_CompletedGif.Activate();

						FattyTwerk_gif.Visible = true;
						m_WasExecuted = false;   // Executes only once and now it`s opposite

						if (m_CompletedSound.settings.playCount == 1)
						{
							MediaPlayerClick.controls.stop();
						}
					}

					
					
					
					
				}
				else if ((ScoreBoard.Text == "800") || (ScoreBoard.Text == "801") || (ScoreBoard.Text == "802") || (ScoreBoard.Text == "803") || (ScoreBoard.Text == "804") || (ScoreBoard.Text == "805") || (ScoreBoard.Text == "806") || (ScoreBoard.Text == "807") || (ScoreBoard.Text == "808") || (ScoreBoard.Text == "809") || (ScoreBoard.Text == "810") || (ScoreBoard.Text == "811") || (ScoreBoard.Text == "812") || (ScoreBoard.Text == "813") || (ScoreBoard.Text == "814") || (ScoreBoard.Text == "815") || (ScoreBoard.Text == "816") || (ScoreBoard.Text == "817") || (ScoreBoard.Text == "818") || (ScoreBoard.Text == "819") || (ScoreBoard.Text == "820"))
				{
					GreenBox1.Visible = true;
					GreenBox2.Visible = true;
					GreenBox3.Visible = true;

					if (!m_WasExecuted)  // Executes only once
					{
						m_CompletedSound.URL = "Completed_Echo.mp3";
						m_CompletedSound.settings.playCount = 1;
						m_CompletedSound.controls.play();
						m_CompletedSound.settings.volume = 100;

						m_CompletedGif.Show();
						m_CompletedGif.Visible = true;
						m_CompletedGif.Activate();

						FattyTwerk_gif.Visible = true;
						m_WasExecuted = true;  // Executes only once
						if (m_CompletedSound.settings.playCount == 1)
						{
							MediaPlayerClick.controls.stop();
						}
					}
													
					
				}
				else if ((ScoreBoard.Text == "1201") || (ScoreBoard.Text == "1202") || (ScoreBoard.Text == "1203") || (ScoreBoard.Text == "1204") || (ScoreBoard.Text == "1205") || (ScoreBoard.Text == "1206") || (ScoreBoard.Text == "1207") || (ScoreBoard.Text == "1208") || (ScoreBoard.Text == "1209") || (ScoreBoard.Text == "1210") || (ScoreBoard.Text == "1211") || (ScoreBoard.Text == "1212") || (ScoreBoard.Text == "1213") || (ScoreBoard.Text == "1214") || (ScoreBoard.Text == "1215")|| (ScoreBoard.Text == "1216") || (ScoreBoard.Text == "1217") || (ScoreBoard.Text == "1218") || (ScoreBoard.Text == "1219") || (ScoreBoard.Text == "1220") || (ScoreBoard.Text == "1221"))
				{
					GreenBox1.Visible = true;
					GreenBox2.Visible = true;
					GreenBox3.Visible = true;
					GreenBox4.Visible = true;

					if (m_WasExecuted)  // Executes only once and now it`s opposite
					{
						m_CompletedSound.URL = "Completed_Echo.mp3";
						m_CompletedSound.settings.playCount = 1;
						m_CompletedSound.controls.play();
						m_CompletedSound.settings.volume = 100;

						m_CompletedGif.Show();
						m_CompletedGif.Visible = true;
						m_CompletedGif.Activate();

						FattyTwerk_gif.Visible = true;
						m_WasExecuted = false;  // Executes only once and now it`s opposite

						if (m_CompletedSound.settings.playCount == 1)
						{
							MediaPlayerClick.controls.stop();
						}
					}
										
					
				}
				else if ((ScoreBoard.Text == "2400") || (ScoreBoard.Text == "2401") || (ScoreBoard.Text == "2402") || (ScoreBoard.Text == "2403") || (ScoreBoard.Text == "2404") || (ScoreBoard.Text == "2405") || (ScoreBoard.Text == "2406") || (ScoreBoard.Text == "2407") || (ScoreBoard.Text == "2408") || (ScoreBoard.Text == "2409") || (ScoreBoard.Text == "2410") || (ScoreBoard.Text == "2411") || (ScoreBoard.Text == "2412") || (ScoreBoard.Text == "2413") || (ScoreBoard.Text == "2414") || (ScoreBoard.Text == "2415") || (ScoreBoard.Text == "2416") || (ScoreBoard.Text == "2417") || (ScoreBoard.Text == "2418") || (ScoreBoard.Text == "2419") || (ScoreBoard.Text == "2420") || (ScoreBoard.Text == "2421") || (ScoreBoard.Text == "2422") || (ScoreBoard.Text == "2423") || (ScoreBoard.Text == "2424") || (ScoreBoard.Text == "2425"))
				{

					GreenBox1.Visible = true;
					GreenBox2.Visible = true;
					GreenBox3.Visible = true;
					GreenBox4.Visible = true;
					GreenBox5.Visible = true;

					if (!m_WasExecuted)  // Executes only once
					{
						m_CompletedSound.URL = "Completed_Echo.mp3";
						m_CompletedSound.settings.playCount = 1;
						m_CompletedSound.controls.play();
						m_CompletedSound.settings.volume = 100;

						m_CompletedGif.Show();
						m_CompletedGif.Visible = true;
						m_CompletedGif.Activate();

						FattyTwerk_gif.Visible = true;
						m_WasExecuted = true;    // Executes only once

						if (m_CompletedSound.settings.playCount == 1)
						{
							MediaPlayerClick.controls.stop();
						}
					}

					
					
					
					
				}
				else if ((ScoreBoard.Text == "4000") || (ScoreBoard.Text == "4001") || (ScoreBoard.Text == "4002") || (ScoreBoard.Text == "4003") || (ScoreBoard.Text == "4004") || (ScoreBoard.Text == "4005") || (ScoreBoard.Text == "4006") || (ScoreBoard.Text == "4007") || (ScoreBoard.Text == "4008") || (ScoreBoard.Text == "4009") || (ScoreBoard.Text == "4010") || (ScoreBoard.Text == "4011") || (ScoreBoard.Text == "4012") || (ScoreBoard.Text == "4013") || (ScoreBoard.Text == "4014") || (ScoreBoard.Text == "4015") || (ScoreBoard.Text == "4016") || (ScoreBoard.Text == "4017") || (ScoreBoard.Text == "4018") || (ScoreBoard.Text == "4019") || (ScoreBoard.Text == "4020") || (ScoreBoard.Text == "4021") || (ScoreBoard.Text == "4022") || (ScoreBoard.Text == "4023"))

				{
					//m_CompletedSound.URL = "Udidit.mp3";
					//m_CompletedSound.settings.playCount = 1;
					//m_CompletedSound.controls.play();

					//if (m_CompletedSound.settings.playCount == 1)
					//{
					//	MediaPlayerClick.controls.stop();
					//}

					m_WinningGifForm.Activate();
					m_WinningGifForm.Show();
					m_WinningGifForm.Visible = true;
									
					
					Progressball1.Dispose();
					Progressball2.Dispose();
					Progressball3.Dispose();
					Progressball4.Dispose();
					Progressball5.Dispose();
					Progressball6.Dispose();

					GreenBox1.Dispose();
					GreenBox2.Dispose();
					GreenBox3.Dispose();
					GreenBox4.Dispose();
					GreenBox5.Dispose();
					GreenBox6.Dispose();

					ScoreBoard.Dispose();


					Restart.Dispose();
					
					Quit_Button.Dispose();
					
					
					answer.Dispose();
					IconText.Dispose();

					Penis.Enabled = false;
					Vagina.Enabled = false;
					Anal.Enabled = false;
					Fist.Enabled = false;
					Finger.Enabled = false;
					Mouth.Enabled = false;
					Blood.Enabled = false;
					Urine.Enabled = false;
					Shit.Enabled = false;
					Sweat.Enabled = false;
					Fart.Enabled = false;
					Wet.Enabled = false;

					Dice.Enabled = false;
					Bonus.Enabled = false;
					Clear_Button.Enabled = false;
					m_mediaPlayer.controls.stop();

					m_mediaPlayer.settings.playCount = 80;
					m_mediaPlayer.URL = "UWin.mp3";
					m_mediaPlayer.controls.play();
					MusicPlayBoy.Visible = false;
					MusicStopBoy.Visible = false;
					MusicVolume.Visible = false;
					MusicVolumeText.Visible = false; 
					pictureBox1.Dispose();

					FattyTwerk_gif.Dispose();

					
				}
			}
			catch
			{

			}
			

		}

		#endregion

		#region ProgressBox Meanings (answertextbox) MouseEnter and Leave
		private void ProgressBox1(object sender, EventArgs e)  //Mouse Enter
		{
			try
			{
				answer.Text = "Activation Required 100";
				if (Progressball1.BackColor == Color.Green)
				{
					answer.Text = "Completed";
				}
			}
			catch
			{

			}
		}

		private void Progressbox2(object sender, EventArgs e)//Mouse Enter
		{
			try
			{
				answer.Text = "Activation Required 400";
				if (Progressball2.BackColor == Color.Green)
				{
					answer.Text = "Completed";
				}
			}
			catch
			{

			}
		}

		private void Progressbox3(object sender, EventArgs e)//Mouse Enter
		{
			try
			{
				answer.Text = "Activation Required 800";
				if (Progressball3.BackColor == Color.Green)
				{
					answer.Text = "Completed";
				}
			}
			catch
			{

			}
		}

		private void Progressbox4(object sender, EventArgs e)//Mouse Enter
		{
			try
			{
				answer.Text = "Activation Required 1200";
				if (Progressball4.BackColor == Color.Green)
				{
					answer.Text = "Completed";
				}
			}
			catch
			{

			}
		}

		private void Progressbox5(object sender, EventArgs e)//Mouse Enter
		{
			try
			{
				answer.Text = "Activation Required 2400";
				if (Progressball5.BackColor == Color.Green)
				{
					answer.Text = "Completed";
				}
			}
			catch
			{

			}
		}

		private void Progressbox6(object sender, EventArgs e)//Mouse Enter
		{
			try
			{
				answer.Text = "Activation Required 4000";
				
			}
			catch
			{

			}

		}
		private void ProgressBox1Leave(object sender, EventArgs e) //Mouse Leave
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}

		private void Progressbox2Leave(object sender, EventArgs e)//Mouse Leave
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}

		private void Progressbox3Leave(object sender, EventArgs e)//Mouse Leave
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}

		private void Progressbox4Leave(object sender, EventArgs e)//Mouse Leave
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}

		private void Progressbox5Leave(object sender, EventArgs e)//Mouse Leave
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}

		private void Progressbox6Leave(object sender, EventArgs e)//Mouse Leave
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}

		#endregion
		
		#region StopCounting and ScoreboardClear
		private void StopCounting()
		{
			try
			{
				m_Count = 0;
				ScoreBoard.Clear();
			}
			catch
			{

			}
		}



		#endregion

		#region GreenBox.gifs MouseEnter/Leave
		private void GreenBox123456_GifsMouseEnter(object sender, EventArgs e)
		{
			try
			{
				if ((GreenBox1.Visible == true) || (GreenBox2.Visible == true) || (GreenBox3.Visible == true) || (GreenBox4.Visible == true) || (GreenBox5.Visible == true) || (GreenBox6.Visible == true))
				{
					answer.Text = "Completed";
				}
			}
			catch
			{

			}
		}
		private void GreenBox123456_GifsMouseLeave(object sender, EventArgs e)
		{
			try
			{
				answer.Clear();
			}
			catch
			{

			}
		}












		#endregion

		#region System GarbageCollector
		private void GarbageCollector()
		{
			try
			{
				GC.Collect();
				GC.WaitForPendingFinalizers();
				GC.Collect();
			}
			catch
			{

			}
		}
		#endregion
	}

}

	



