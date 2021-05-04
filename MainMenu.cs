using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib; // WindowsMediaPlayer

namespace XXXCalculator2020
{
	public partial class MainMenuForm : Form
	{
		
		
		readonly WindowsMediaPlayer m_Musicplayer = new WindowsMediaPlayer();
		readonly WindowsMediaPlayer m_SoundsYesAndNo = new WindowsMediaPlayer();
		
		[STAThread]
		static void Main()
		{
			
			Application.Run(new MainMenuForm());
			
		}
		public MainMenuForm()
		{
			InitializeComponent();
			
			Cursor.Position = new Point(0, 0);  // Puts Cursor 0,0 position on your Windowsdesktop
			
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
		
		
		#region NormalMode,GuessMode,MemoryGame,Quit,Hello and Credits Buttons(MouseEnter and Leave)
		private void StartGame_Button(object sender, EventArgs e) // NormalMode
		{
			try
			{


				Heart_Gif.Dispose();
				Heart_Gif2.Dispose();
				Greengoo_Gif.Dispose();
				Greengoo2_Gif.Dispose();
				Startgame_gif1.Dispose();
				Startgame_gif2.Dispose();
				Startgame_gif3.Dispose();
				Startgame_gif4.Dispose();
				RedSmoke_gif.Dispose();
				RedSmoke2_gif.Dispose();
				LoveXXX_gif.Dispose();
				VersioNumber.Dispose();
				HelloButton.Dispose();
				CursorGifNormalMode.Dispose();
				CursorGifNormalMode1.Dispose();
				CursorGifGuessMode.Dispose();
				CursorGifGuessMode1.Dispose();
				CursorGifMemoryGame.Dispose();
				CursorGifMemoryGame1.Dispose();
				CursorGifQuitGame.Dispose();
				CursorGifQuitGame1.Dispose();
				CursorGifCredits.Dispose();

				m_SoundsYesAndNo.controls.stop();
				m_Musicplayer.controls.stop();

				Credits.Dispose();
				NormalMode_Button.Dispose();  // Normal Mode
				GuessMode.Dispose();
				QuitStart.Dispose(); // Quit game
				MemoryGame.Dispose();

				HelloForm m_HelloForm = new HelloForm();
				m_HelloForm.Close();

				Credits_Image m_Credits_Image = new Credits_Image();
				m_Credits_Image.Hide();
				m_Credits_Image.Visible = false;


				//m_NormalMode.Activate();
				//m_NormalMode.Visible = true;
				NormalModeForm m_NormalMode = new NormalModeForm();
				m_NormalMode.Show();  // Showing new Form        

				m_Musicplayer.controls.stop();

				GarbageCollector();
			}
			catch
			{

			}
		}
				
		private void StartGame_MouseEnter(object sender, EventArgs e)   // NormalMode
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

				//StartGameButton.Height = 63;
				GarbageCollector();
			}
			catch
			{

			}
		}

		private void StartGame_MouseLeave(object sender, EventArgs e)  // NormalMode
		{
			try
			{
				NormalMode_Button.BackColor = Color.YellowGreen;
				Cursor = Cursors.Default;
				m_SoundsYesAndNo.controls.stop();

				CursorGifNormalMode.Visible = false;
				CursorGifNormalMode1.Visible = false;

				//StartGameButton.Height = 55;
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


				Heart_Gif.Dispose();
				Heart_Gif2.Dispose();
				Greengoo_Gif.Dispose();
				Greengoo2_Gif.Dispose();
				Startgame_gif1.Dispose();
				Startgame_gif2.Dispose();
				Startgame_gif3.Dispose();
				Startgame_gif4.Dispose();
				RedSmoke_gif.Dispose();
				RedSmoke2_gif.Dispose();
				LoveXXX_gif.Dispose();
				VersioNumber.Dispose();
				HelloButton.Dispose();
				CursorGifNormalMode.Dispose();
				CursorGifNormalMode1.Dispose();
				CursorGifGuessMode.Dispose();
				CursorGifGuessMode1.Dispose();
				CursorGifMemoryGame.Dispose();
				CursorGifMemoryGame1.Dispose();
				CursorGifQuitGame.Dispose();
				CursorGifQuitGame1.Dispose();
				CursorGifCredits.Dispose();

				m_SoundsYesAndNo.controls.stop();
				m_Musicplayer.controls.stop();

				Credits.Dispose();
				NormalMode_Button.Dispose();
				GuessMode.Dispose();
				QuitStart.Dispose(); // Quit game
				MemoryGame.Dispose();

				
				

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

				//GuessMode.Height = 63;
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
				//GuessMode.Height = 55;
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
				Heart_Gif.Dispose();
				Heart_Gif2.Dispose();
				Greengoo_Gif.Dispose();
				Greengoo2_Gif.Dispose();
				Startgame_gif1.Dispose();
				Startgame_gif2.Dispose();
				Startgame_gif3.Dispose();
				Startgame_gif4.Dispose();
				RedSmoke_gif.Dispose();
				RedSmoke2_gif.Dispose();
				LoveXXX_gif.Dispose();
				VersioNumber.Dispose();
				HelloButton.Dispose();
				CursorGifNormalMode.Dispose();
				CursorGifNormalMode1.Dispose();
				CursorGifGuessMode.Dispose();
				CursorGifGuessMode1.Dispose();
				CursorGifMemoryGame.Dispose();
				CursorGifMemoryGame1.Dispose();
				CursorGifQuitGame.Dispose();
				CursorGifQuitGame1.Dispose();
				CursorGifCredits.Dispose();

				m_SoundsYesAndNo.controls.stop();
				m_Musicplayer.controls.stop();

				Credits.Dispose();
				NormalMode_Button.Dispose();
				GuessMode.Dispose();
				QuitStart.Dispose(); // Quit game
				MemoryGame.Dispose();

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
				m_SoundsYesAndNo.settings.volume = 70;
				MemoryGame.BackColor = Color.Green;
				
				Cursor = Cursors.Hand;
				
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
				//QuitStart.Height = 63;

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
				//QuitStart.Height = 55;
			}
			catch
			{

			}
			
		}
		
		private void Credits_Click(object sender, EventArgs e)
		{
			try
			{
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
				m_SoundsYesAndNo.settings.volume = 70;
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
				HelloForm m_HelloForm = new HelloForm();
				Lightshow m_LightShow = new Lightshow();
				if (m_LightShow.Visible == false)
				{
					m_Musicplayer.controls.stop();
								
					
					m_LightShow.Show();
										
					m_HelloForm.Show();
					this.Hide();
					
				}
								
				GarbageCollector();
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
				m_SoundsYesAndNo.settings.volume = 60;
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
		#endregion

		#region MusicPlayer

		private void MusicPlayer()
		{
			m_Musicplayer.URL = "startgame.mp3";
			m_Musicplayer.controls.play();
			m_Musicplayer.settings.playCount = 90;
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

		
	}
}
