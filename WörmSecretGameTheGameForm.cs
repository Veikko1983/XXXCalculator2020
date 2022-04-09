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
using System.Media;  // U can also use this Audio System for music or fx


namespace XXXCalculator2020
{
	public partial class WörmSecretGameTheGameForm : Form
	{
		readonly WindowsMediaPlayer m_FXPlayer = new WindowsMediaPlayer();
        readonly WindowsMediaPlayer m_FXHollowman = new WindowsMediaPlayer();
        readonly WindowsMediaPlayer m_MusicPlayer = new WindowsMediaPlayer();
        readonly WörmGameApplesAndSpeedForm m_WörmApplesAndSpeedForm = new WörmGameApplesAndSpeedForm();

        int m_Cols = 50, m_Rows = 25, m_Score = 0, m_Dx = 0, m_Dy = 0, m_Front = 0, m_Back = 0;
		Piece[] m_Snake = new Piece[1250];  //This is the Piece Class, player WörmHead
        PieceBody[] m_SnakeBody = new PieceBody[1250]; //This is the Piece Class, player WörmBody

        List<int> m_Available = new List<int>();
		bool[,] m_Visit;
        
		Random m_Random = new Random();
		Timer m_Timer = new Timer();
		public WörmSecretGameTheGameForm()
		{
			InitializeComponent();

            Initial();
			LaunchTimer();
			this.CenterToScreen();
            Cursor.Position = new Point(0,0);
             
            m_WörmApplesAndSpeedForm.Show();
           
		}

        #region GAME LOAD
        private void WörmSecretGameTheGameForm_Load(object sender, EventArgs e)
        {
            Music();
            WomanSingWorm_gif.SendToBack();  // sends picturebox back

        }

        #endregion

        #region GAME SPEED
        private void LaunchTimer()
		{
            m_Timer.Interval = 200;  // this is the wörm speed (200 is good)
            m_Timer.Tick += Player_Move;
            m_Timer.Start();
           
        }
		#endregion

		#region PLAYER'S REACTIONS TO THE ENVIRONMENT
		private void Player_Move(object sender, EventArgs e)
        {
            int x = m_Snake[m_Front].Location.X, y = m_Snake[m_Front].Location.Y;
                
            if (m_Dx == 0 && m_Dy == 0) return;
            //push any arrow key to start, dispose controls image and other
            Controls_picturebox.Dispose();
            Ball1_gif.Dispose();
            Ball_gif.Dispose();
            Esc_pictureBox.Dispose();
            Warning_label.Dispose();

			if (GameOver(x + m_Dx, y + m_Dy))
			{
				m_Timer.Stop();

				FX_Sounds_GameOver_or_WörmHits();
				//MessageBox.Show("Game Over");

				m_MusicPlayer.controls.stop();
				this.Close();
				Game_Over_Wörm game_Over_Wörm = new Game_Over_Wörm();
				game_Over_Wörm.Show();

				return;
			}

			// if player hits Hollowman, this don`t work
			//if ((CollisionHollowman(x + m_Dx, y + m_Dy)) || (CollisionHollowman2(x + m_Dx, y + m_Dy)) || (CollisionHollowman3(x + m_Dx, y + m_Dy)) || (CollisionHollowman4(x + m_Dx, y + m_Dy)) || (CollisionHollowman5(x + m_Dx, y + m_Dy)) || (CollisionHollowman6(x + m_Dx, y + m_Dy)))
			//{
			//    if (true)
			//    {
			//        m_Timer.Stop();

			//        FX_Sounds_GameOver_or_WörmHits();
			//        //MessageBox.Show("Game Over");

			//        m_MusicPlayer.controls.stop();
			//        this.Close();
			//        Game_Over_Wörm game_Over_Wörm = new Game_Over_Wörm();
			//        game_Over_Wörm.Show();

			//        return;
			//    }

			//}

			if (CollisionFood(x + m_Dx, y + m_Dy))   
            {
                m_Score += 1;
                //Old scores!!! Not in use!!!
                //lblScore.Text = "Apples: " + m_Score.ToString();

                // Converts int to string in textbox
                m_WörmApplesAndSpeedForm.Apples_textBox.Text = "" + m_Score.ToString();
                // Hollowman apairs if u get certain amount of apples
                if (m_WörmApplesAndSpeedForm.Apples_textBox.Text == "20")
				{
                    DontHitHolloman_gif.Visible = true;
                    DontHitHolloman_gif.Enabled = true;
                    DontHitHolloman_gif.BringToFront();
                    FX_Sounds_Hollowman();
                  
                }
               else  if (m_WörmApplesAndSpeedForm.Apples_textBox.Text == "40")
                {
                    DontHitHolloman2_gif.Visible = true;
                    DontHitHolloman2_gif.Enabled = true;
                    DontHitHolloman2_gif.BringToFront();
                    FX_Sounds_Hollowman();
                }
                else if (m_WörmApplesAndSpeedForm.Apples_textBox.Text == "60")
                {
                    DontHitHolloman3_gif.Visible = true;
                    DontHitHolloman3_gif.Enabled = true;
                    DontHitHolloman3_gif.BringToFront();
                    FX_Sounds_Hollowman();
                }
                else if (m_WörmApplesAndSpeedForm.Apples_textBox.Text == "80")
                {
                    DontHitHolloman4_gif.Visible = true;
                    DontHitHolloman4_gif.Enabled = true;
                    DontHitHolloman4_gif.BringToFront();
                    FX_Sounds_Hollowman();
                }
                else if (m_WörmApplesAndSpeedForm.Apples_textBox.Text == "100")
                {
                    DontHitHolloman5_gif.Visible = true;
                    DontHitHolloman5_gif.Enabled = true;
                    DontHitHolloman5_gif.BringToFront();
                    FX_Sounds_Hollowman();
                }
                else if (m_WörmApplesAndSpeedForm.Apples_textBox.Text == "120")
                {
                    DontHitHolloman6_gif.Visible = true;
                    DontHitHolloman6_gif.Enabled = true;
                    DontHitHolloman6_gif.BringToFront();
                    FX_Sounds_Hollowman();
                }

                if (Player_Hits((y + m_Dy) / 20, (x + m_Dx) / 20)) return;
				//Piece m_Head = new Piece(x + m_Dx, y + m_Dy);
				//PieceBody m_Body = new PieceBody(x + m_Dx, y + m_Dy);

				//m_Front = (m_Front - 1 + 1250) % 1250;
				//m_Snake[m_Front] = m_Head;
				//m_Visit[m_Head.Location.Y / 20, m_Head.Location.X / 20] = true;
				//Controls.Add(m_Body);
				//m_Body.BringToFront();  // when new head spawns, it spawns front of the background.gif
				//FX_Sounds_ApplePick();
				//RandomFood();

				//Old style, only 1 bodypart
				Piece m_Head = new Piece(x + m_Dx, y + m_Dy);

				m_Front = (m_Front - 1 + 1250) % 1250;
				m_Snake[m_Front] = m_Head;
				m_Visit[m_Head.Location.Y / 20, m_Head.Location.X / 20] = true;
				Controls.Add(m_Head);
				m_Head.BringToFront();  // when new head spawns, it spawns front of the background.gif
				FX_Sounds_ApplePick();
				RandomFood();

				// When wörm eats apple wörm become faster 
				if (true)
				{
                    m_Timer.Interval -= 2;
                    // adds time interval readings to other form also coverts int to string(Text)
                   // m_WörmApplesAndSpeedForm.WörmSpeed_textBox.Text = "" + m_Timer.Interval.ToString();

                }
            }
			
			else
			{
				if (Player_Hits((y + m_Dy) / 20, (x + m_Dx) / 20)) return;
				{

					m_Visit[m_Snake[m_Back].Location.Y / 20, m_Snake[m_Back].Location.X / 20] = false;
					m_Front = (m_Front - 1 + 1250) % 1250;
					m_Snake[m_Front] = m_Snake[m_Back];
					m_Snake[m_Front].Location = new Point(x + m_Dx, y + m_Dy);
					m_Back = (m_Back - 1 + 1250) % 1250;
					m_Visit[(y + m_Dy) / 20, (x + m_Dx) / 20] = true;

				}
			} 
                           
        }
        #endregion

        #region PLAYER CONTROLS
        private void WörmSecretGameTheGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            m_Dx = 0;   // m_Dx Right = 20, m_Dx Left = -20
            m_Dy = 0;   // m_Dy Down = 20, m_Dy Up = -20
           
			try
			{

                #region Player Opposite Move Direction Disabler

                if (m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text == "Right" && e.KeyCode == Keys.Left)
                {

                    m_Dx = 20;
                   


                }
               else  if (m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text == "Left" &&  e.KeyCode == Keys.Right)
                {

                    m_Dx = -20;
                   

                }
                else if (m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text == "Up" && e.KeyCode == Keys.Down)
                {

                    m_Dy = -20;
                    

                }
                else if(m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text == "Down" && e.KeyCode == Keys.Up)
                {

                    m_Dy = 20;
                   

                }
                #endregion

                #region Player Controls

                else if (e.KeyCode == Keys.Right && e.KeyCode != Keys.Left)
                    {
                         m_Dx = 20;


                    if (m_Dx > 0)
                    {
                        m_Dx = 20;
                        m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text = "Right";
                        
                    }

                }

                else if (e.KeyCode == Keys.Left && e.KeyCode != Keys.Right)
                    {
                          m_Dx = -20;
                    if(m_Dx < 0)
					{
                            m_Dx = -20;
                        m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text = "Left";                        
                    }
                             
                    }
                  
               else  if (e.KeyCode == Keys.Up && e.KeyCode != Keys.Down)
                    {
                        m_Dy = -20;

                    if(m_Dy < 0)
					{
                             m_Dy = -20;
                        m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text = "Up";                    
                    }
                        
                    }
                  
                else if (e.KeyCode == Keys.Down && e.KeyCode != Keys.Up)
                    {
                            m_Dy = 20;
					if (m_Dy > 0)
					{
                               m_Dy = 20;
                        m_WörmApplesAndSpeedForm.PlayerControlsTextBox.Text = "Down";
                    }
                        
                    }
				#endregion            
                                   
            }
            
            catch
			{

			}
        }
        #endregion

        #region APPLE, RANDOM SPAWN POINTS
        private void RandomFood()
        {
            m_Available.Clear();

            for (int i = 0; i < m_Rows; i++)
                for (int j = 0; j < m_Cols; j++)
                    if (!m_Visit[i, j]) m_Available.Add(i * m_Cols + j);  
            int idx = m_Random.Next(m_Available.Count) % m_Available.Count;
            lblFood_Picturebox.Left = (m_Available[idx] * 20) % Width;
            lblFood_Picturebox.Top = (m_Available[idx] * 20) / Width * 20;
           
            //lblFood_Picturebox.BringToFront();           
                        
        }

		#endregion

		#region PLAYER HITS SELF
		private bool Player_Hits(int x, int y)
        {
            if (m_Visit[x, y])
            {
                m_Timer.Stop();
                FX_Sounds_GameOver_or_WörmHits();
                m_MusicPlayer.controls.stop();
                //MessageBox.Show("Snake hit his Body");
               
                this.Close();
                Game_Over_Wörm game_Over_Wörm = new Game_Over_Wörm();
                game_Over_Wörm.Show();

                //return true;  // THIS IS FROM OLD CODE
            }
            return false;
        }
		#endregion

		#region FOOD COLLISION, HOLLOWMAN_GIF COLLISION AND GAME OVER
        //Collosions to apples
		private bool CollisionFood(int x, int y)
        {
            return x == lblFood_Picturebox.Location.X && y == lblFood_Picturebox.Location.Y;
        }
       
        //Collosions to Hollowman, not in use(beter this way))
        //private bool CollisionHollowman(int x, int y)
        //{
        //    return x == DontHitHolloman_gif.Location.X && y  == DontHitHolloman_gif.Location.Y;
           
        //}
        //private bool CollisionHollowman2(int x, int y)
        //{
           
        //    return x == DontHitHolloman2_gif.Location.X && y == DontHitHolloman2_gif.Location.Y;
            
        //}
        //private bool CollisionHollowman3(int x, int y)
        //{
           
        //    return x == DontHitHolloman3_gif.Location.X && y == DontHitHolloman3_gif.Location.Y;
            
        //}
        //private bool CollisionHollowman4(int x, int y)
        //{
           
           
        //    return x == DontHitHolloman4_gif.Location.X && y == DontHitHolloman4_gif.Location.Y;
           
        //}
        //private bool CollisionHollowman5(int x, int y)
        //{
           
        //    return x == DontHitHolloman5_gif.Location.X && y == DontHitHolloman5_gif.Location.Y;
           
        //}
        //private bool CollisionHollowman6(int x, int y)
        //{
           
        //    return x == DontHitHolloman6_gif.Location.X && y == DontHitHolloman6_gif.Location.Y;
        //}		

		// Collosions to GameOver
		private bool GameOver(int x, int y)
        {
            return x < 0 || y < 0 || x > 980 || y > 480;
        }
		#endregion

		#region INITIAL
		private void Initial()
        {
            m_Visit = new bool[m_Rows, m_Cols];
            
            Piece m_Head = new Piece((m_Random.Next() % m_Cols) * 20, (m_Random.Next() % m_Rows) * 20);
           
            lblFood_Picturebox.Location = new Point((m_Random.Next() % m_Cols) * 20, (m_Random.Next() % m_Rows) * 20);

            for (int i = 0; i < m_Rows; i++)

                for (int j = 0; j < m_Cols; j++)
                {
                    m_Visit[i, j] = false;   
                    m_Available.Add(i * m_Cols + j);
                }
            m_Visit[m_Head.Location.Y / 20, m_Head.Location.X / 20] = true;
            m_Available.Remove(m_Head.Location.Y / 20 * m_Cols + m_Head.Location.X / 20);
            Controls.Add(m_Head);
            m_Snake[m_Front] = m_Head;

            m_Head.BringToFront();
            // Player Wörm start potition begin of the game(Eliminates random start position)
            // this might cause bug, try to eliminate random,Next in code that maybe will help
            //m_Head.Location = new Point(500, 300);
            
        }
		#endregion
        	
		#region FX_SOUNDS
		private void FX_Sounds_ApplePick()
		{
			try
			{
                m_FXPlayer.URL = "NonomWörm.mp3";
                m_FXPlayer.settings.volume = 80;
                m_FXPlayer.settings.playCount = 1;
                m_FXPlayer.controls.play();
               

            }
			catch
			{

			}
		}
        private void FX_Sounds_GameOver_or_WörmHits()
		{
            try
            {
                m_FXPlayer.URL = "Nooooo.mp3";
                m_FXPlayer.settings.volume = 80;
                m_FXPlayer.settings.playCount = 1;
                m_FXPlayer.controls.play();


            }
            catch
            {

            }
        }

        private void FX_Sounds_Hollowman()
        {
            try
            {
                m_FXHollowman.URL = "Hollowman.mp3";
                m_FXHollowman.settings.volume = 30;
                m_FXHollowman.settings.playCount = 1;
                m_FXHollowman.controls.play();


            }
            catch
            {

            }
        }
        #endregion

        #region MUSIC

        private void Music()
		{
			try
			{
                m_MusicPlayer.URL = "LadyWörmTrack.mp3";
                m_MusicPlayer.settings.playCount = 1;
                m_MusicPlayer.settings.setMode("Loop", true);   // Music is looping!!
                m_MusicPlayer.controls.play();
               
                m_MusicPlayer.settings.volume = 60;
               
            }
			catch
			{

			}
		}

		#endregion

       
		
	}
}
