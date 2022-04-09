using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib; // WindowsMediaPlayer

namespace XXXCalculator2020
{
	public partial class MainMenuForm : Form
	{

		//bool m_IsClicked;
		//readonly HowToPlayForm m_HowToPlayForm = new HowToPlayForm();  // If using this here it only will fire ones
		//readonly MainMenuForm m_MainMenuForm = new MainMenuForm();
		
		readonly WindowsMediaPlayer m_Musicplayer = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer m_SoundsYesAndNo = new WindowsMediaPlayer();
		
		//[STAThread]   // Form that starts first (MainForm)Project/XXXCalculator2020Properties/Application/StartUpObject
		//static void Main()
		//{

		//	Application.Run(new MainMenuForm());

		//}
		#region Program Starts
		public MainMenuForm()
		{
			InitializeComponent();
			// Only for the Demo Version
			//OnlyForTheDemoUsage();
			//this.Size = Screen.PrimaryScreen.WorkingArea.Size; // Screen scales with any screen size, fullscreen.
			this.Enabled = true;
			m_Musicplayer.controls.stop();

			Cursor.Position = new Point(850, 400);  // Puts Cursor middle of the screen on your Windowsdesktop
			Cursor.Show();
			

			CursorgifHello.Visible = false;
			CursorGifNormalMode.Visible = false;
			CursorGifNormalMode1.Visible = false;
			CursorGifGuessMode.Visible = false;
			CursorGifGuessMode1.Visible = false;
			CursorGifMemoryGame.Visible = false;
			CursorGifMemoryGame1.Visible = false;
			CursorGifQuitGame.Visible = false;
			CursorGifQuitGame1.Visible = false;
			CursorGifCredits.Visible = false;
			
			
			MusicPlayer();
			
			GarbageCollector();
		}
		#endregion

		#region NormalMode,GuessMode,MemoryGame,Quit,Hello,Credits and Secret Game Wörm Buttons(MouseEnter,Leave and Click)
		private void NormalMode_Button_Click(object sender, EventArgs e)
		{
			try
			{
								
				m_SoundsYesAndNo.controls.stop();
				m_Musicplayer.controls.stop();

				this.Close(); // Close this form(MainMenu)
				NormalModeForm m_NormalMode = new NormalModeForm();
				m_NormalMode.Show();  // Showing new Form        

				GarbageCollector();
			}
			catch
			{

			}
		}

		private void NormalMode_Button_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				m_SoundsYesAndNo.URL = "NormalMode.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 60;

				NormalMode_Button.BackColor = Color.Green;

				Cursor = Cursors.Hand;

				CursorGifNormalMode.Visible = true;
				CursorGifNormalMode1.Visible = true;

				NormalMode_Button.Height = 54;
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void NormalMode_Button_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				NormalMode_Button.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
				m_SoundsYesAndNo.controls.stop();

				CursorGifNormalMode.Visible = false;
				CursorGifNormalMode1.Visible = false;

				NormalMode_Button.Height = 49;
				GarbageCollector();
			}
			catch
			{

			}
		}
				
		private void GuessMode_Click(object sender, EventArgs e)
		{
			try
			{
				//MessageBox.Show("Work In Progress!!!", "<3 Not Ready <3");

				m_SoundsYesAndNo.controls.stop();
				m_Musicplayer.controls.stop();

				this.Close();
				GuessMode m_GuessMode = new GuessMode();
				m_GuessMode.Show();

				GarbageCollector();
			}
							
			catch
			{

			}
		}
		
		private void GuessMode_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				m_SoundsYesAndNo.URL = "GuessMode.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 70;

				GuessMode.BackColor = Color.Green;
				Cursor = Cursors.Hand;
				CursorGifGuessMode.Visible = true;
				CursorGifGuessMode1.Visible = true;
								
				GuessMode.Height = 54;
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void GuessMode_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				m_SoundsYesAndNo.controls.stop();

				GuessMode.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
				CursorGifGuessMode.Visible = false;
				CursorGifGuessMode1.Visible = false;
				GuessMode.Height = 49;
				
				GarbageCollector();
			}
			catch
			{

			}
		}
		private void MemoryGame_Click(object sender, EventArgs e)
		{
			try
			{
				//MessageBox.Show("Work In Progress!!!", "<3 Not Ready <3");
				
				m_SoundsYesAndNo.controls.stop();
				m_Musicplayer.controls.stop();
				this.Close();
				MemoryGame m_MemoryGameForm = new MemoryGame();
				m_MemoryGameForm.Show();
				
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void MemoryGame_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				m_SoundsYesAndNo.URL = "MemoryGame.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 60;
				MemoryGame.BackColor = Color.Green;
				
				Cursor = Cursors.Hand;
				MemoryGame.Height = 54;
				CursorGifMemoryGame.Visible = true;
				CursorGifMemoryGame1.Visible = true;
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void MemoryGame_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				m_SoundsYesAndNo.controls.stop();

				MemoryGame.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
				MemoryGame.Height = 49;
				CursorGifMemoryGame.Visible = false;
				CursorGifMemoryGame1.Visible = false;
				GarbageCollector();
			}
			catch
			{

			}
		}
		private void StartQuit_Noo(object sender, EventArgs e)   //QuitGame
		{
			try
			{
				Application.Exit();
			}
			catch
			{

			}
		}
		private void StartQuit_MouseEnter(object sender, EventArgs e)  //Quit Game
		{
			try
			{
				m_SoundsYesAndNo.URL = "QuitGame.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 70;
				
				CursorGifQuitGame.Visible = true;
				CursorGifQuitGame1.Visible = true;

				QuitStart.BackColor = Color.Red;
				Cursor = Cursors.Hand;

				GarbageCollector();
				QuitStart.Height = 54;

			}
			catch
			{

			}
		}

		private void StartQuit_MouseLeave(object sender, EventArgs e)   //Quit Game
		{
			try
			{
				m_SoundsYesAndNo.controls.stop();

				QuitStart.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
				CursorGifQuitGame.Visible = false;
				CursorGifQuitGame1.Visible = false;
				GarbageCollector();
				QuitStart.Height = 49;
			}
			catch
			{

			}
			
		}
		
		private void Credits_Click(object sender, EventArgs e)
		{
			try
			{
				m_Musicplayer.controls.stop();
				this.Hide();
				//MessageBox.Show("Veikko Ruopio (BazzDog)", "<3 Credits <3");
				Credits_Image m_Credits_Image = new Credits_Image();
				m_Credits_Image.Show();
				Enabled = false;
				GarbageCollector();
			}
			catch
			{

			}
		}
		private void Credits_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				m_SoundsYesAndNo.URL = "Credits.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 80;
				Credits.BackColor = Color.Yellow;
				//Credits.Height = 32;
				CursorGifCredits.Visible = true;
				Cursor = Cursors.Hand;
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void Credits_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Credits.BackColor = Color.YellowGreen;
				CursorGifCredits.Visible = false;
				m_SoundsYesAndNo.controls.stop();
				//Credits.Height = 25;
				Cursor = Cursors.Default;
				GarbageCollector();
			}
			catch
			{

			}
		}
		private void HelloButtonClick(object sender, EventArgs e)
		{
			try
			{
				m_Musicplayer.controls.stop();
				this.Hide();
				Lightshow m_LightShow = new Lightshow();
				m_LightShow.Show();

			}
			catch
			{

			}
		}
		private void HelloButtonMouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				m_SoundsYesAndNo.URL = "Hello.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 70;
				HelloButton.BackColor = Color.Yellow;
				CursorgifHello.Visible = true;
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void HelloButtonMouseLeave(object sender, EventArgs e)
		{
			try
			{
				
				Cursor = Cursors.Default;
				m_SoundsYesAndNo.controls.stop();
				HelloButton.BackColor = Color.YellowGreen;
				CursorgifHello.Visible = false;
				GarbageCollector();

			}
			catch
			{

			}
		}
		private void HowToPlayButton_Click(object sender, EventArgs e)  
		{
			
			try
			{
				m_Musicplayer.controls.stop();
				this.Close();
				HowToPlayForm m_HowToPlayForm = new HowToPlayForm();  // Creats new form on taskbar every third click
				m_HowToPlayForm.Show();
				ItsDancePartyForm m_ItsPartyForm = new ItsDancePartyForm();
				m_ItsPartyForm.Show();
				ItsDanceParty2Form m_ItsParty2Form = new ItsDanceParty2Form();
				m_ItsParty2Form.Show();
				//if (m_IsClicked == false)
				//{
				//	HelloButton.Enabled = false;
				//	Credits.Enabled = false;
				//	NormalMode_Button.Enabled = false;
				//	GuessMode.Enabled = false;
				//	MemoryGame.Enabled = false;
				//	ReadBeforePlay_Button.Enabled = false;
				//	m_HowToPlayForm.Show();
				//	m_IsClicked = true;
				//}
				//else 
				//{
				//	m_HowToPlayForm.Close();
				//	m_IsClicked = false;
				//	NormalMode_Button.Enabled = true;
				//	GuessMode.Enabled = true;
				//	HelloButton.Enabled = true;
				//	MemoryGame.Enabled = true;
				//	Credits.Enabled = true;
				//	ReadBeforePlay_Button.Enabled = true;
				//}

			}
			catch
			{
			
			}
		}
		private void HowToPlayButton_MouseEnter(object sender, EventArgs e)  
		{
			try
			{
				m_SoundsYesAndNo.URL = "HowToPlay.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 80;
				HowToPlayButton.BackColor = Color.Yellow;
				Cursor = Cursors.Hand;
				HowToPlayBall_Gif.Visible = true;
			}
			catch
			{

			}
		}

		private void HowToPlayButton_MouseLeave(object sender, EventArgs e)  
		{
			try
			{
				m_SoundsYesAndNo.controls.stop();
				HowToPlayButton.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
				HowToPlayBall_Gif.Visible = false;
			}
			catch
			{

			}
		}
		private void ReadBeforePlay_Button_Click(object sender, EventArgs e)   // SCOREBOARDS Button_Click
		{
			try
			{
				m_Musicplayer.controls.stop();

				m_Musicplayer.URL = "ScoreboardsMusic.mp3";
				m_Musicplayer.settings.playCount = 1;
				m_Musicplayer.settings.setMode("Loop", true);
				m_Musicplayer.controls.play();

				GuessModeScoreBoardForm m_GuesModeScoreBoardForm = new GuessModeScoreBoardForm();
				MemoryGameScoreBoardForm m_MemmoryGameScoreBoardForm = new MemoryGameScoreBoardForm();
				ExitAndErazeScoreboardsForm m_ExitAndErazeScoreboardsForm = new ExitAndErazeScoreboardsForm();
				m_ExitAndErazeScoreboardsForm.Show();
				m_GuesModeScoreBoardForm.Show();
				m_MemmoryGameScoreBoardForm.Show();
				//m_GuesModeScoreBoardForm.Enabled = false;
				//m_MemmoryGameScoreBoardForm.Enabled = false;
				this.Close();
				//m_MemmoryGameScoreBoardForm.ExitButtonToMGameScoreB.Visible = true;

				//if (m_IsClicked == false)
				//{
				//	HelloButton.Enabled = false;
				//	Credits.Enabled = false;
				//	NormalMode_Button.Enabled = false;
				//	GuessMode.Enabled = false;
				//	MemoryGame.Enabled = false;
				//	HowToPlayButton.Enabled = false;
				//	m_ReadBeforePlayForm.Show();
				//	m_IsClicked = true;
				//}
				//else
				//{
				//	m_ReadBeforePlayForm.Close();
				//	m_IsClicked = false;
				//	NormalMode_Button.Enabled = true;
				//	GuessMode.Enabled = true;
				//	HelloButton.Enabled = true;
				//	MemoryGame.Enabled = true;
				//	Credits.Enabled = true;
				//	HowToPlayButton.Enabled = true;
				//}
			}
			catch
			{

			}
		}
		private void ReadBeforePlay_Button_MouseEnter(object sender, EventArgs e)   // SCOREBOARDS Button_MouseEnter
		{
			try
			{
				m_SoundsYesAndNo.URL = "ScoreBoards.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();
				m_SoundsYesAndNo.settings.volume = 60;
				ReadBeforePlayBall_Gif.Visible = true;
				ReadBeforePlay_Button.BackColor = Color.Yellow;
				Cursor = Cursors.Hand;
			}
			catch
			{

			}
		}

		private void ReadBeforePlay_Button_MouseLeave(object sender, EventArgs e)  // SCOREBOARDS Button_MouseLeave
		{
			try
			{
				ReadBeforePlayBall_Gif.Visible = false;
				ReadBeforePlay_Button.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
			}
			catch
			{

			}
		}
		private void LoveXXX_gif_Click(object sender, EventArgs e)  //Secret Game Wörm
		{
			try
			{
				m_Musicplayer.controls.stop();
				m_SoundsYesAndNo.URL = "WörmSpeech.mp3";
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.settings.volume = 50;
				m_SoundsYesAndNo.controls.play();
				WörmSecretGame m_SecretGameWörm = new WörmSecretGame();
				m_SecretGameWörm.Show();
				this.Close(); // close this form
				
			}
			catch
			{

			}
		}
		private void LoveXXX_gif_MouseEnter(object sender, EventArgs e) //Secret Game Wörm
		{
			try
			{
				Cursor = Cursors.Hand;

				m_SoundsYesAndNo.URL = "SecretGameWörm_Echo.mp3";
				m_SoundsYesAndNo.settings.volume = 70;
				m_SoundsYesAndNo.settings.playCount = 1;
				m_SoundsYesAndNo.controls.play();

			}
			catch
			{

			}
		}

		private void LoveXXX_gif_MouseLeave(object sender, EventArgs e) //Secret Game Wörm
		{
			try
			{
				Cursor = Cursors.Default;

			}
			catch
			{

			}
		}
		#endregion

		#region MusicPlayer

		private void MusicPlayer()
		{
			
			m_Musicplayer.URL = "startgame.mp3";
			m_Musicplayer.controls.play();
			m_Musicplayer.settings.playCount = 1;
			m_Musicplayer.settings.setMode("Loop" , true);
			m_Musicplayer.settings.volume = 70;

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

		#region FOR THE DEMO VERSION

		//private void OnlyForTheDemoUsage()
		//{
		//	try
		//	{
		//		MemoryGame.Enabled = false;
		//		GuessMode.Enabled = false;
		//		HowToPlayButton.Enabled = false;
		//		HelloButton.Enabled = false;
		//		ReadBeforePlay_Button.Enabled = false;
		//		VersioNumber.Text = "v.DEMO";
				
		//	}
		//	catch
		//	{

		//	}
		//}


		#endregion

		
	}
}
