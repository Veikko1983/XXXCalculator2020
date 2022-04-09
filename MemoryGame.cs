using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;  //Windowns MediaPlayer
using System.IO;  //File save or load

namespace XXXCalculator2020
{
	
	public partial class MemoryGame : Form
	{
		readonly Timer m_TimerToLoadingScr = new Timer();
		readonly Timer m_TimeToPairs = new Timer();
		readonly Timer m_TimerToRightPairs = new Timer();
		readonly Timer m_PlayTimeTimer = new Timer();
		readonly WindowsMediaPlayer m_LoadingSound = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer m_MemoryGameMusic = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer m_YeahAndNoSound = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer m_VexiSounds = new WindowsMediaPlayer();
		int m_ScoreBoardPoints;
		int m_PlayTimeCount;
		int m_FinalScore;
		int m_Count;
		readonly Random m_RandomLocation = new Random();
		readonly List<Point> m_Points = new List<Point>();
		readonly MemoryGamePointScreenForm m_MemoryGamePointsScreenForm = new MemoryGamePointScreenForm();
		readonly MemoryGameScoreBoardForm m_MemoryGameScoreBoard = new MemoryGameScoreBoardForm();
		//readonly MemoryGameScoreBoardForm m_MemoryGameScoreBoard = new MemoryGameScoreBoardForm();

		Button m_PendingImage1;  // Store first flipped card into this variable
		Button m_PendingImage2;  // -----second--------------------------------

		#region PROGRAM STARTS, LOADING SCREEN, TIMER TO LOADING SCREEN & WIDTH ANIMATION TO LOADING TEXT_IMAGE
		public MemoryGame()
		{
			
			InitializeComponent();

			LoadScreenTimerMemoryGame.Start();
			CenterToParent();
			CardsHolderPanel.Visible = false;

			//Cursor.Position = new Point(0, 0);  // Puts Cursor 0,0 position on your Windowsdesktop
			Cursor.Hide();
						
			m_LoadingSound.URL = "WelcomeMemoryRobot.mp3";
			m_LoadingSound.settings.playCount = 1;
			m_LoadingSound.controls.play();

			this.Controls.Add(LoadingMemoryGame_Gif);   // Orders which will came first(Bring front or Bring back(Mouse click left Imagebox))
			this.Controls.Add(MGameLoadingS_Gif);

			//ImageFilesLoaderAndRandomizer();  //Loads Cover Images to Buttons1-24 (Properties.Resources.Questonmark100x100Cover) Or u can use foreach loop to do same trick

			//Timer to Loading Screen
			m_TimerToLoadingScr.Interval = 7000;   // // time scale, 1000 = 1sec.
			m_TimerToLoadingScr.Tick += new EventHandler(Timer_Tick);
			m_TimerToLoadingScr.Start();  // timer start
			
			void Timer_Tick(object sender, EventArgs e)   //Timer to Loading Screen
			{
				m_TimerToLoadingScr.Stop();

				PlayTimeTimer();

				PlayTimeTimerBox.Visible = true;
				
				Time_label.Visible = true;

				RestartButtonMiniIcon.Visible = true;

				Card1.Visible = true;
				DubCard1.Visible = true;
				Card2.Visible = true;
				DubCard2.Visible = true;
				Card3.Visible = true;
				DubCard3.Visible = true;
				Card4.Visible = true;
				DubCard4.Visible = true;
				Card5.Visible = true;
				DubCard5.Visible = true;
				Card6.Visible = true;
				DubCard6.Visible = true;
				Card7.Visible = true;
				DubCard7.Visible = true;
				Card8.Visible = true;
				DubCard8.Visible = true;
				Card9.Visible = true;
				DubCard9.Visible = true;
				Card10.Visible = true;
				DubCard10.Visible = true;
				Card11.Visible = true;
				DubCard11.Visible = true;
				Card12.Visible = true;
				DubCard12.Visible = true;

				Quit_Button_MemoryGame.Visible = true;
				MainMenuButtonMemoryGame.Visible = true;
				LoadingMemoryGame_Gif.Dispose();
				MGameLoadingS_Gif.Dispose();
				MemoryGameBackground_Gif.Visible = true;
				
				//Cursor.Position = new Point(0, 0);  // Puts Cursor 0,0 position on your Windowsdesktop
				Cursor.Show();
				m_MemoryGameMusic.URL = "MemoryGameMusic.mp3";
				m_MemoryGameMusic.settings.playCount = 80;
				m_MemoryGameMusic.controls.play();
				m_MemoryGameMusic.settings.volume = 60;
				MusicPlayButtonMemoryGame.Visible = true;
				MusicStopButtonMemoryGame.Visible = true;
				MusicVolumeSliderMemoryGame.Visible = true;
				MusicVolumeLabel.Visible = true;
				CardsHolderPanel.Visible = true;
				YourScoreLabel.Visible = true;
				YourScore_TextBox.Visible = true;
				
				try
				{
					foreach (Button m_picture in CardsHolderPanel.Controls) // Loops every button backroundimage to questonmark100x100 begin of the game in CardsHolderPanel
					{
						m_picture.Image = Properties.Resources.questonmark100x100;
						m_Points.Add(m_picture.Location);
					}
				}
				catch
				{

				}
				try
				{
					foreach (Button m_picture in CardsHolderPanel.Controls) //Shuffles every Button to new random location
					{
						int m_next = m_RandomLocation.Next(m_Points.Count);
						Point m_p = m_Points[m_next];
						m_picture.Location = m_p;
						m_Points.Remove(m_p);
					}
				}
				catch
				{

				}

			}

		}
		private void LoadScreenTimerMemoryGame_Tick(object sender, EventArgs e)
		{
			LoadingMemoryGame_Gif.Width += 1;
		}
		#endregion

		#region ALL BUTTONS MOUSE ENTER/LEAVE 
		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card1.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button2_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard1.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button3_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card2.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button4_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard2.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button5_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card3.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button6_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard3.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button7_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card4.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button8_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard4.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button9_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card5.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button10_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard5.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button11_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card6.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button12_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard6.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button13_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card7.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button14_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard7.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button15_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card8.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button16_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard8.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button17_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card9.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button18_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard9.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button19_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card10.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button20_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard10.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button21_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card11.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button22_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard11.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button23_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Card12.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button24_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				DubCard12.BackColor = Color.Green;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card1.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button2_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard1.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button3_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card2.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button4_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard2.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button5_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card3.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button6_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard3.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button7_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card4.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button8_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard4.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button9_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card5.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button10_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard5.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button11_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card6.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button12_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard6.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button13_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card7.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button14_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard7.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button15_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card8.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button16_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard8.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button17_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card9.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button18_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard9.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button19_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card10.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button20_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard10.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button21_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card11.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button22_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard11.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button23_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Card12.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Button24_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				DubCard12.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void Quit_Button_MemoryGame_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Quit_Button_MemoryGame.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void MainMenuButtonMemoryGame_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				MainMenuButtonMemoryGame.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void Quit_Button_MemoryGame_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Quit_Button_MemoryGame.BackColor = Color.White;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}

		private void MainMenuButtonMemoryGame_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				MainMenuButtonMemoryGame.BackColor = Color.White;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}
		private void MusicPlayButtonMemoryGame_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				MusicPlayButtonMemoryGame.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void MusicPlayButtonMemoryGame_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				MusicPlayButtonMemoryGame.BackColor = Color.White;
				Cursor = Cursors.Default;

			}
			catch
			{

			}
		}

		private void MusicStopButtonMemoryGame_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				MusicStopButtonMemoryGame.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void MusicStopButtonMemoryGame_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				MusicStopButtonMemoryGame.BackColor = Color.White;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}
		private void RestartMemoryGame_button_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				RestartMemoryGame_button.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}
		private void RestartMemoryGame_button_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				RestartMemoryGame_button.BackColor = Color.White;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
			
		}
		private void MusicVolumeSliderMemoryGame_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void MusicVolumeSliderMemoryGame_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}
		private void RestartButtonMiniIcon_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				RestartButtonMiniIcon.BackColor = Color.Gray;
				Cursor = Cursors.Hand;
				//MessageBox.Show("", "Restart");  // Shows ugly messagebox middle of the screen LOOOL
				RestartLabelText.Visible = true;
			}
			catch
			{

			}
		}
		private void RestartButtonMiniIcon_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				RestartButtonMiniIcon.BackColor = Color.White;
				Cursor = Cursors.Default;
				RestartLabelText.Visible = false;

			}
			catch
			{

			}
		}
		private void FScoreTextBox_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				TimeMinusScoreLabel.Visible = true;
			}
			catch
			{

			}
		}

		private void FScoreTextBox_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				TimeMinusScoreLabel.Visible = false;
			}
			catch
			{

			}
		}
		#endregion

		#region QUIT,MAIN MENU & RESTART BUTTONS
		private void Quit_Button_MemoryGame_Click(object sender, EventArgs e)
		{
			try
			{
				Application.Exit();
			}
			catch
			{

			}
		}

		private void MainMenuButtonMemoryGame_Click(object sender, EventArgs e)
		{
			try
			{
				//Application.Restart();
				m_MemoryGameMusic.controls.stop();
				this.Close();
				MainMenuForm m_MainMenu = new MainMenuForm();
				m_MainMenu.Show();
				
				m_MemoryGameScoreBoard.Close();
			}
			catch
			{

			}
		}
		private void RestartMemoryGame_button_Click(object sender, EventArgs e)
		{
			try
			{
				m_MemoryGameMusic.controls.stop();
				this.Close();
				MemoryGame m_MemoryGameForm = new MemoryGame();
				m_MemoryGameForm.Show();
				
				m_MemoryGameScoreBoard.Close();
			}
			catch
			{

			}
		}
		private void RestartButtonMiniIcon_Click(object sender, EventArgs e)
		{
			try
			{
				m_MemoryGameMusic.controls.stop();
				this.Close();
				MemoryGame m_MemoryGameForm = new MemoryGame();
				m_MemoryGameForm.Show();
				
				m_MemoryGameScoreBoard.Close();
			}
			catch
			{

			}
		}
		#endregion

		#region GUESTION MARK BUTTONS 
		private void Card1_Click(object sender, EventArgs e)
		{
			try
			{
				Card1.Image = Properties.Resources.penis100x100;
				m_VexiSounds.URL = "Penis.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;

				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card1;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card1;
					
				}

				if (m_PendingImage1 != null && m_PendingImage2 != null)    // Checks if they are not null
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have a same tag number
					{
						// add here new Scoreboard plus or minus form show!!!!!
						CorrectPicsCount();
						TimerToRightPairs();
						Card1.Dispose();
						DubCard1.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						PenisImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();

					}
					else
					{
						TimerToWrongPairs();   // Waits until timer stops then checks and checks also if u pick a wrong pair
					}
				
				}
			}
			catch
			{

			}
		}

		private void DubCard1_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard1.Image = Properties.Resources.penis100x100;
				m_VexiSounds.URL = "Penis.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard1;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard1;
					
				}
				
				if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compareing if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card1.Dispose();
						DubCard1.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						PenisImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();

					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks  
					}
					
				}
			}
			catch
			{

			}
		}

		private void Card2_Click(object sender, EventArgs e)
		{
			try
			{
				Card2.Image = Properties.Resources.vagina100x100;
				m_VexiSounds.URL = "Vagina.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card2;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card2;
					
				}
				
				if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compareing if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card2.Dispose();
						DubCard2.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						VaginaImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}
					
				}
			}
			catch
			{

			}
		}

		private void DubCard2_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard2.Image = Properties.Resources.vagina100x100;
				m_VexiSounds.URL = "Vagina.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard2;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard2;
					
				}
				
				if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compareing if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card2.Dispose();
						DubCard2.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						VaginaImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}
				}
			}
			catch
			{

			}
		}

		private void Card3_Click(object sender, EventArgs e)
		{
			try
			{
				Card3.Image = Properties.Resources.anal100x100;
				m_VexiSounds.URL = "Anal.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 95;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card3;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card3;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card3.Dispose();
						DubCard3.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						AnalImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard3_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard3.Image = Properties.Resources.anal100x100;
				m_VexiSounds.URL = "Anal.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 95;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard3;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard3;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card3.Dispose();
						DubCard3.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						AnalImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card4_Click(object sender, EventArgs e)
		{
			try
			{
				Card4.Image = Properties.Resources.fart100x100;
				m_VexiSounds.URL = "Fart.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card4;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card4;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card4.Dispose();
						DubCard4.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						FartImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard4_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard4.Image = Properties.Resources.fart100x100;
				m_VexiSounds.URL = "Fart.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard4;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard4;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card4.Dispose();
						DubCard4.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						FartImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card5_Click(object sender, EventArgs e)
		{
			try
			{
				Card5.Image = Properties.Resources.fist100x100;
				m_VexiSounds.URL = "Fist.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card5;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card5;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card5.Dispose();
						DubCard5.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						FistImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard5_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard5.Image = Properties.Resources.fist100x100;
				m_VexiSounds.URL = "Fist.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard5;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard5;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card5.Dispose();
						DubCard5.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						FistImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card6_Click(object sender, EventArgs e)
		{
			try
			{
				Card6.Image = Properties.Resources.mouth100x100;
				m_VexiSounds.URL = "Mouth.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 95;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card6;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card6;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card6.Dispose();
						DubCard6.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						MouthImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks and checks also if u pick wrong pairs
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard6_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard6.Image = Properties.Resources.mouth100x100;
				m_VexiSounds.URL = "Mouth.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 95;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard6;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard6;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card6.Dispose();
						DubCard6.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						MouthImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card7_Click(object sender, EventArgs e)
		{
			try
			{
				Card7.Image = Properties.Resources.finger100x100;
				m_VexiSounds.URL = "Finger.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 65;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card7;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card7;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card7.Dispose();
						DubCard7.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						FingerImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard7_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard7.Image = Properties.Resources.finger100x100;
				m_VexiSounds.URL = "Finger.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 65;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard7;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard7;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card7.Dispose();
						DubCard7.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						FingerImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card8_Click(object sender, EventArgs e)
		{
			try
			{
				Card8.Image = Properties.Resources.wet100x100;
				m_VexiSounds.URL = "Wet.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 100;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card8;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card8;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card8.Dispose();
						DubCard8.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						WetImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard8_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard8.Image = Properties.Resources.wet100x100;
				m_VexiSounds.URL = "Wet.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 100;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard8;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard8;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card8.Dispose();
						DubCard8.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						WetImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card9_Click(object sender, EventArgs e)
		{
			try
			{
				Card9.Image = Properties.Resources.shit100x100;
				m_VexiSounds.URL = "Shit.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 90;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card9;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card9;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card9.Dispose();
						DubCard9.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						ShitImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard9_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard9.Image = Properties.Resources.shit100x100;
				m_VexiSounds.URL = "Shit.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 90;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard9;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard9;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card9.Dispose();
						DubCard9.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						ShitImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card10_Click(object sender, EventArgs e)
		{
			try
			{
				Card10.Image = Properties.Resources.urine100x100;
				m_VexiSounds.URL = "Urine.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card10;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card10;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card10.Dispose();
						DubCard10.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						UrineImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard10_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard10.Image = Properties.Resources.urine100x100;
				m_VexiSounds.URL = "Urine.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard10;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard10;
					
				}
				 if(m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card10.Dispose();
						DubCard10.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						UrineImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card11_Click(object sender, EventArgs e)
		{
			try
			{
				Card11.Image = Properties.Resources.blood100x100;
				m_VexiSounds.URL = "Blood.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card11;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card11;
					
				}
				 if(m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same tag number
					{
						
						CorrectPicsCount();
						TimerToRightPairs();
						Card11.Dispose();
						DubCard11.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						BloodImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard11_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard11.Image = Properties.Resources.blood100x100;
				m_VexiSounds.URL = "Blood.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard11;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard11;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have same a tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card11.Dispose();
						DubCard11.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						BloodImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();
					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void Card12_Click(object sender, EventArgs e)
		{
			try
			{
				Card12.Image = Properties.Resources.sweat100x100;
				m_VexiSounds.URL = "Sweat.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = Card12;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = Card12;
					
				}
				 if (m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have a same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card12.Dispose();
						DubCard12.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						SweatImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();

					}
					else
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}

		private void DubCard12_Click(object sender, EventArgs e)
		{
			try
			{
				DubCard12.Image = Properties.Resources.sweat100x100;
				m_VexiSounds.URL = "Sweat.mp3";
				m_VexiSounds.settings.playCount = 1;
				m_VexiSounds.controls.play();
				m_VexiSounds.settings.volume = 80;
				if (m_PendingImage1 == null)
				{
					m_PendingImage1 = DubCard12;
				}
				else if (m_PendingImage1 != null && m_PendingImage2 == null)
				{
					m_PendingImage2 = DubCard12;
					
				}
				 if(m_PendingImage1 != null && m_PendingImage2 != null)
				{
					
					if (m_PendingImage1.Tag == m_PendingImage2.Tag) // Compare if they have a same tag number
					{
						CorrectPicsCount();
						TimerToRightPairs();
						Card12.Dispose();
						DubCard12.Dispose();
						m_PendingImage1 = null;
						m_PendingImage2 = null;
						SweatImageFound.Visible = true;
						YeahSound();
						WhenAllPairsAreFound();

					}
					else 
					{
						TimerToWrongPairs();   // Waits until timer stops then checks
					}

				}
			}
			catch
			{

			}
		}
		
		#endregion
		
		#region MUSIC PLAY,STOP BUTTONS AND MUSIC VOLUME SLIDER
		private void MusicPlayButtonMemoryGame_Click(object sender, EventArgs e)
		{
			try
			{
				m_MemoryGameMusic.URL = "MemoryGameMusic.mp3";
				m_MemoryGameMusic.settings.playCount = 1;
				m_MemoryGameMusic.settings.setMode("Loop", true);
				m_MemoryGameMusic.controls.play();
				m_MemoryGameMusic.settings.volume = 60;
				
			}
			catch
			{

			}
		}

		private void MusicStopButtonMemoryGame_Click(object sender, EventArgs e)
		{
			try
			{
				
				m_MemoryGameMusic.controls.stop();

			}
			catch
			{

			}
		}
		
		private void MusicVolumeSliderMemoryGame_Scroll(object sender, ScrollEventArgs e)
		{
			try
			{
				if (MusicVolumeSliderMemoryGame.Value == 60)
				{
					m_MemoryGameMusic.settings.volume = 60;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 55)
				{
					m_MemoryGameMusic.settings.volume = 55;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 50)
				{
					m_MemoryGameMusic.settings.volume = 50;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 45)
				{
					m_MemoryGameMusic.settings.volume = 45;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 40)
				{
					m_MemoryGameMusic.settings.volume = 40;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 35)
				{
					m_MemoryGameMusic.settings.volume = 35;
				}
				if (MusicVolumeSliderMemoryGame.Value == 30)
				{
					m_MemoryGameMusic.settings.volume = 30;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 25)
				{
					m_MemoryGameMusic.settings.volume = 25;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 20)
				{
					m_MemoryGameMusic.settings.volume = 20;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 15)
				{
					m_MemoryGameMusic.settings.volume = 15;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 10)
				{
					m_MemoryGameMusic.settings.volume = 10;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 5)
				{
					m_MemoryGameMusic.settings.volume = 5;
				}
				else if (MusicVolumeSliderMemoryGame.Value == 0)  
				{
					m_MemoryGameMusic.settings.volume = 0;
				}
				
			}
			catch
			{

			}
		}
		#endregion
					
		#region WRONG PAIRS MINUS POINTS
		private void WrongPairsMinusPoints()
		{
			m_ScoreBoardPoints -= 10;
			YourScore_TextBox.Text = m_ScoreBoardPoints.ToString();
			m_FinalScore -= 10;
			FScoreTextBox.Text = m_FinalScore.ToString();
		}
		#endregion

		#region RIGHT PAIRS PLUS POINTS
		private void CorrectPicsCount()
		{
			m_ScoreBoardPoints += 40;
			YourScore_TextBox.Text = m_ScoreBoardPoints.ToString();
			m_FinalScore += 40;
			FScoreTextBox.Text = m_FinalScore.ToString();  // Counts in background to your FinalScoreBox
		}
		#endregion

		#region TIMER TO WRONG PAIRS
		private void TimerToWrongPairs()
		{
			
			try
			{
				m_MemoryGamePointsScreenForm.Show();
				m_MemoryGamePointsScreenForm.MinusPointsImage.Visible = true;
				m_TimeToPairs.Interval = 1600;   // time
				m_TimeToPairs.Tick += new EventHandler(Timer_Pairs);
				m_TimeToPairs.Start();  // timer start
				NoooSound();
				WrongPairsMinusPoints();
				AllGuestionMarkButtonsEnableFalse();

				void Timer_Pairs(object sender, EventArgs e)
				{
					
					m_TimeToPairs.Stop();
					m_MemoryGamePointsScreenForm.Hide();
					m_MemoryGamePointsScreenForm.MinusPointsImage.Visible = false;
					AllGuestionMarkButtonsEnableTrue();
					if ((m_PendingImage1 != null) &&(m_PendingImage2 != null))
					{
						m_PendingImage1.Image = Properties.Resources.questonmark100x100;
						m_PendingImage2.Image = Properties.Resources.questonmark100x100;
						m_PendingImage1 = null;
						m_PendingImage2 = null;
					}
					
					



				}
			}
			catch
			{

			}
		}
		#endregion
		
		#region TIMER TO RIGHT PAIRS
		private void TimerToRightPairs()
		{
			try
			{
				m_MemoryGamePointsScreenForm.Show();
				m_MemoryGamePointsScreenForm.PlusPointsImage.Visible = true;
				CardsEnableFalse();
				m_TimerToRightPairs.Interval = 1200;   // time, 1000 = 1sec.
				m_TimerToRightPairs.Tick += new EventHandler(Timer_RightPairs);
				m_TimerToRightPairs.Start();  // timer start
				void Timer_RightPairs(object sender, EventArgs e)
				{
					m_TimerToRightPairs.Stop();
					CardsEnableTrue();
					m_MemoryGamePointsScreenForm.Hide();
					m_MemoryGamePointsScreenForm.PlusPointsImage.Visible = false;

				}
			}
			catch
			{

			}
		}
		

		#endregion
				
		#region WHEN ALL PAIRS ARE FOUND
		private void WhenAllPairsAreFound()
		{
			
			try
			{
				if ((PenisImageFound.Visible == true)&&(VaginaImageFound.Visible == true)&&(AnalImageFound.Visible == true) && (FartImageFound.Visible == true) && (FistImageFound.Visible == true) && (MouthImageFound.Visible == true) && (FingerImageFound.Visible == true) && (WetImageFound.Visible == true) && (ShitImageFound.Visible == true) && (UrineImageFound.Visible == true) && (BloodImageFound.Visible == true) && (SweatImageFound.Visible == true))
				{
					AllMiniIconsDispose();
					RestartButtonMiniIcon.Dispose();
					CardsHolderPanel.Dispose();
					WellDoneGif.Visible = true;
					RestartMemoryGame_button.Visible = true;
					MusicPlayButtonMemoryGame.Dispose();
					MusicStopButtonMemoryGame.Dispose();
					MusicVolumeLabel.Dispose();
					MusicVolumeSliderMemoryGame.Dispose();
					FinalScoreLabel.Visible = true;
					m_MemoryGameMusic.controls.stop();
					m_MemoryGameMusic.URL = "WellDoneSong.mp3";
					m_MemoryGameMusic.settings.playCount = 70;
					//m_MemoryGameMusic.settings.volume = 60;
					m_MemoryGameMusic.controls.play();

					m_PlayTimeTimer.Stop();
									
					//FScoreTextBox.Text = YourScore_TextBox.Text;  // Adds ScoreBoard Score to Final Score Box
					FScoreTextBox.Visible = true;
					PlayTimeTimerBox.Dispose();
					YourScore_TextBox.Dispose();
					Time_label.Dispose();
					YourScoreLabel.Dispose();


					m_MemoryGameScoreBoard.Show();
					HighScoreBoardScoresFormMg();
					//m_MemoryGameScoreBoardForm.QuitButtonToMGameScoreB.Visible = true;


				}
				

				

			}
			catch
			{

			}
		}
		#endregion

		#region ALL GUESTION MARK BUTTONS ENABLE FALSE

		private void AllGuestionMarkButtonsEnableFalse()
		{
			try
			{
				Card1.Enabled = false;
				DubCard1.Enabled = false;
				Card2.Enabled = false;
				DubCard2.Enabled = false;
				Card3.Enabled = false;
				DubCard3.Enabled = false;
				Card4.Enabled = false;
				DubCard4.Enabled = false;
				Card5.Enabled = false;
				DubCard5.Enabled = false;
				Card6.Enabled = false;
				DubCard6.Enabled = false;
				Card7.Enabled = false;
				DubCard7.Enabled = false;
				Card8.Enabled = false;
				DubCard8.Enabled = false;
				Card9.Enabled = false;
				DubCard9.Enabled = false;
				Card10.Enabled = false;
				DubCard10.Enabled = false;
				Card11.Enabled = false;
				DubCard11.Enabled = false;
				Card12.Enabled = false;
				DubCard12.Enabled = false;
			}
			catch
			{

			}
		}

		#endregion

		#region ALL GUESTION MARK BUTTONS ENABLE TRUE

		private void AllGuestionMarkButtonsEnableTrue()
		{
			try
			{
				Card1.Enabled = true;
				DubCard1.Enabled = true;
				Card2.Enabled = true;
				DubCard2.Enabled = true;
				Card3.Enabled = true;
				DubCard3.Enabled = true;
				Card4.Enabled = true;
				DubCard4.Enabled = true;
				Card5.Enabled = true;
				DubCard5.Enabled = true;
				Card6.Enabled = true;
				DubCard6.Enabled = true;
				Card7.Enabled = true;
				DubCard7.Enabled = true;
				Card8.Enabled = true;
				DubCard8.Enabled = true;
				Card9.Enabled = true;
				DubCard9.Enabled = true;
				Card10.Enabled = true;
				DubCard10.Enabled = true;
				Card11.Enabled = true;
				DubCard11.Enabled = true;
				Card12.Enabled = true;
				DubCard12.Enabled = true;
			}
			catch
			{

			}
		}

		#endregion
		
		#region YEAH & NOOO SOUND

		private void YeahSound()
		{
			try
			{
				m_YeahAndNoSound.URL = "PairFound.mp3";
				m_YeahAndNoSound.settings.playCount = 1;
				m_YeahAndNoSound.controls.play();
			}
			catch
			{

			}
		}
		private void NoooSound()
		{
			try
			{
				m_YeahAndNoSound.URL = "WrongPair.mp3";
				m_YeahAndNoSound.settings.playCount = 1;
				m_YeahAndNoSound.controls.play();
			}
			catch
			{

			}
		}

		#endregion

		#region PLAY TIME TIMER

		private void PlayTimeTimer()
		{
			try
			{
				
				m_PlayTimeTimer.Interval = 2000;   // time scale, 1000 = 1sec.
				m_PlayTimeTimer.Tick += new EventHandler(PlayTimeTimer);
				m_PlayTimeTimer.Start();  // timer start
				
				void PlayTimeTimer(object sender, EventArgs e)
				{
					m_PlayTimeCount += 1;
					PlayTimeTimerBox.Text = m_PlayTimeCount.ToString();

					m_FinalScore -= 1;  // Minus Time for FinalScoreTextBox
					FScoreTextBox.Text = m_FinalScore.ToString();
					
					// stop time is located in WHEN ALL PAIRS ARE FOUND region
				}
			}
			catch
			{

			}
		}

		#endregion

		#region CARDS ENABLE TRUE & FALSE
		private void CardsEnableTrue()
		{
			try
			{
				Card1.Enabled = true;
				DubCard1.Enabled = true;
				Card2.Enabled = true;
				DubCard2.Enabled = true;
				Card3.Enabled = true;
				DubCard3.Enabled = true;
				Card4.Enabled = true;
				DubCard4.Enabled = true;
				Card5.Enabled = true;
				DubCard5.Enabled = true;
				Card6.Enabled = true;
				DubCard6.Enabled = true;
				Card7.Enabled = true;
				DubCard7.Enabled = true;
				Card8.Enabled = true;
				DubCard8.Enabled = true;
				Card9.Enabled = true;
				DubCard9.Enabled = true;
				Card10.Enabled = true;
				DubCard10.Enabled = true;
				Card11.Enabled = true;
				DubCard11.Enabled = true;
				Card12.Enabled = true;
				DubCard12.Enabled = true;
			}
			catch
			{

			}
		}
		private void CardsEnableFalse()
		{
			try
			{
				Card1.Enabled = false;
				DubCard1.Enabled = false;
				Card2.Enabled = false;
				DubCard2.Enabled = false;
				Card3.Enabled = false;
				DubCard3.Enabled = false;
				Card4.Enabled = false;
				DubCard4.Enabled = false;
				Card5.Enabled = false;
				DubCard5.Enabled = false;
				Card6.Enabled = false;
				DubCard6.Enabled = false;
				Card7.Enabled = false;
				DubCard7.Enabled = false;
				Card8.Enabled = false;
				DubCard8.Enabled = false;
				Card9.Enabled = false;
				DubCard9.Enabled = false;
				Card10.Enabled = false;
				DubCard10.Enabled = false;
				Card11.Enabled = false;
				DubCard11.Enabled = false;
				Card12.Enabled = false;
				DubCard12.Enabled = false;
			}
			catch
			{

			}
		}

		#endregion

		#region ALL MINI-ICONS VISIBLE FALSE

		private void AllMiniIconsDispose()
		{
			try
			{
				PenisImageFound.Dispose();
				VaginaImageFound.Dispose();
				AnalImageFound.Dispose();
				FartImageFound.Dispose(); 
				FistImageFound.Dispose(); 
				MouthImageFound.Dispose();
				FingerImageFound.Dispose();
				WetImageFound.Dispose();
				ShitImageFound.Dispose();
				UrineImageFound.Dispose();
				BloodImageFound.Dispose();
				SweatImageFound.Dispose();

			}
			catch
			{

			}
		}



		#endregion

		#region HIGHSCOREBOARD SCORES & WRITELINE/READLINE(Save to txt file)

		public void HighScoreBoardScoresFormMg()
		{
			try
			{
				// HINT!! ADD ALL FILES FIRST THEN U HAVE CHANGE TO COMPARE ALL NUMBERS TOGETHER!!!!!
				
				//m_GuessModeScoreBoardForm.HSGM_Score_Textb1.Text = YourFinalScoreBoard.Text;   // Adds YourFinalScore to GuessModeScoreBoard/HSGM textbox
				m_Count = int.Parse(FScoreTextBox.Text);  // Converts string number to int m_Count	

				#region File 1

				if (!File.Exists("XXXCalculator20201mg.txt")) // If the file did not exist then it creates it
				{
					//Add here more texts because now it only writes 1 line to txt file
					TextWriter m_TextWriter1 = new StreamWriter("XXXCalculator20201mg.txt");
					m_TextWriter1.Write(m_Count);
					m_TextWriter1.Close();

					TextReader m_TextReader1 = new StreamReader("XXXCalculator20201mg.txt");
					m_MemoryGameScoreBoard.HSMG_Score_Textb1.Text = m_TextReader1.ReadLine();
					m_TextReader1.Close();

					m_MemoryGameScoreBoard.HSMG_Name_Textb1.ReadOnly = false;
					m_MemoryGameScoreBoard.HSMG_Name_Textb1.BackColor = Color.Red;
					m_MemoryGameScoreBoard.HSMG_Name_Textb1.Text = "ADD YOUR NAME";
					m_MemoryGameScoreBoard.HSMG_Name_Textb1.Select();   // Puts cursor automatic this textbox
					m_MemoryGameScoreBoard.HSMG_Score_Textb1.ForeColor = Color.White;
					

				}
				if (File.Exists("XXXCalculator20201mg.txt")) //If file is exixted
				{

					if (m_Count >= Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb1.Text)) //If final score is biger or same than exist file 1
					{
						TextWriter m_TextWriter1 = new StreamWriter("XXXCalculator20201mg.txt");
						m_TextWriter1.Write(m_Count);
						m_TextWriter1.Close();

						TextReader m_TextReader1 = new StreamReader("XXXCalculator20201mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb1.Text = m_TextReader1.ReadLine();
						m_TextReader1.Close();
						//m_GuessModeScoreBoardForm.HSGM_Score_Textb1.Text = m_Count.ToString();  // converting m_count(int) x value to string 
						m_MemoryGameScoreBoard.HSMG_Name_Textb1.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Name_Textb1.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb1.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb1.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb1.Select();
						m_MemoryGameScoreBoard.HSMG_Score_Textb1.ForeColor = Color.White;
					}
				}
				#endregion

				#region File 2

				if (!File.Exists("XXXCalculator20202mg.txt"))
				{
					if (m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb1.Text))
					{
						TextWriter m_TextWriter2 = new StreamWriter("XXXCalculator20202mg.txt");
						m_TextWriter2.Write(m_Count);
						m_TextWriter2.Close();

						TextReader m_TextReader2 = new StreamReader("XXXCalculator20202mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb2.Text = m_TextReader2.ReadLine();
						m_TextReader2.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb2.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.Select();
						m_MemoryGameScoreBoard.HSMG_Score_Textb2.ForeColor = Color.White;
					}

				}

				//this works fine!!!
				if (File.Exists("XXXCalculator20202mg.txt"))
				{
					//MessageBox.Show("Is this alive??");
					if ((m_Count >= Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb2.Text)) && ((m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb1.Text))))
					{
						TextWriter m_TextWriter2 = new StreamWriter("XXXCalculator20202mg.txt");
						m_TextWriter2.Write(m_Count);
						m_TextWriter2.Close();

						TextReader m_TextReader2 = new StreamReader("XXXCalculator20202mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb2.Text = m_TextReader2.ReadLine();
						m_TextReader2.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb2.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb2.Select();
						m_MemoryGameScoreBoard.HSMG_Score_Textb2.ForeColor = Color.White;
					}
				}
				#endregion

				#region File 3

				if (!File.Exists("XXXCalculator20203mg.txt"))
				{
					if (m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb2.Text))
					{
						TextWriter m_TextWriter3 = new StreamWriter("XXXCalculator20203mg.txt");
						m_TextWriter3.Write(m_Count);
						m_TextWriter3.Close();

						TextReader m_TextReader3 = new StreamReader("XXXCalculator20203mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb3.Text = m_TextReader3.ReadLine();
						m_TextReader3.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb3.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.Select();
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Score_Textb3.ForeColor = Color.White;
					}

				}
				if (File.Exists("XXXCalculator20203mg.txt"))
				{
					if ((m_Count >= Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb3.Text)) && (m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb2.Text)))
					{
						TextWriter m_TextWriter3 = new StreamWriter("XXXCalculator20203mg.txt");
						m_TextWriter3.Write(m_Count);
						m_TextWriter3.Close();

						TextReader m_TextReader3 = new StreamReader("XXXCalculator20203mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb3.Text = m_TextReader3.ReadLine();
						m_TextReader3.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb3.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb3.Select();
						m_MemoryGameScoreBoard.HSMG_Score_Textb3.ForeColor = Color.White;
					}

				}
				#endregion

				#region File 4

				if (!File.Exists("XXXCalculator20204mg.txt"))
				{
					if (m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb3.Text))
					{
						TextWriter m_TextWriter4 = new StreamWriter("XXXCalculator20204mg.txt");
						m_TextWriter4.Write(m_Count);
						m_TextWriter4.Close();

						TextReader m_TextReader4 = new StreamReader("XXXCalculator20204mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb4.Text = m_TextReader4.ReadLine();
						m_TextReader4.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb4.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.Select();
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Score_Textb4.ForeColor = Color.White;
					}
				}
				if (File.Exists("XXXCalculator20204mg.txt"))
				{
					if ((m_Count >= Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb4.Text)) && ((m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb3.Text))))
					{
						TextWriter m_TextWriter4 = new StreamWriter("XXXCalculator20204mg.txt");
						m_TextWriter4.Write(m_Count);
						m_TextWriter4.Close();

						TextReader m_TextReader4 = new StreamReader("XXXCalculator20204mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb4.Text = m_TextReader4.ReadLine();
						m_TextReader4.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb4.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.Select();
						m_MemoryGameScoreBoard.HSMG_Name_Textb4.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Score_Textb4.ForeColor = Color.White;
					}
				}

				#endregion

				#region File 5

				if (!File.Exists("XXXCalculator20205mg.txt"))
				{
					if (m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb4.Text))
					{
						TextWriter m_TextWriter5 = new StreamWriter("XXXCalculator20205mg.txt");
						m_TextWriter5.Write(m_Count);
						m_TextWriter5.Close();

						TextReader m_TextReader5 = new StreamReader("XXXCalculator20205mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb5.Text = m_TextReader5.ReadLine();
						m_TextReader5.Close();
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.Select();
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Score_Textb5.ForeColor = Color.White;
					}
				}
				if (File.Exists("XXXCalculator20205mg.txt"))
				{
					if ((m_Count >= Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb5.Text)) && ((m_Count < Convert.ToInt32(m_MemoryGameScoreBoard.HSMG_Score_Textb4.Text))))
					{
						TextWriter m_TextWriter5 = new StreamWriter("XXXCalculator20205mg.txt");
						m_TextWriter5.Write(m_Count);
						m_TextWriter5.Close();

						TextReader m_TextReader5 = new StreamReader("XXXCalculator20205mg.txt");
						m_MemoryGameScoreBoard.HSMG_Score_Textb5.Text = m_TextReader5.ReadLine();
						m_TextReader5.Close();

						m_MemoryGameScoreBoard.HSMG_Name_Textb5.BackColor = Color.Red;
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.Clear();
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.Text = "ADD YOUR NAME";
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.Select();
						m_MemoryGameScoreBoard.HSMG_Name_Textb5.ReadOnly = false;
						m_MemoryGameScoreBoard.HSMG_Score_Textb5.ForeColor = Color.White;

					}
				}


				//Little lesson to if or else if`s. If u use IF statement it will check all if`s, it doesen`t mather if it`s condition is true or not. If u use else if, it will stop the first one that program checks correct. REMEMBER!!!





				#endregion

			}

			catch
			{

			}
		}


		#endregion

	}

}






