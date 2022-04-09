using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    // file saver & loader


namespace XXXCalculator2020
{
	public partial class ExitAndErazeScoreboardsForm : Form
	{

		//readonly MemoryGameScoreBoardForm m_MemoryGameScoreBoardForm = new MemoryGameScoreBoardForm();
		//readonly GuessModeScoreBoardForm m_GuessModeScoreBoard = new GuessModeScoreBoardForm();

		public ExitAndErazeScoreboardsForm()
		{
			InitializeComponent();
			this.CenterToScreen();  // form is center to screen
		}
		#region MAIN MENU & ERAZE BUTTONS, Mouse leave/enter
		private void MainMenuButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Close the form if it`s already open
				GuessModeScoreBoardForm m_GuessModeScoreBoardForm = (GuessModeScoreBoardForm)Application.OpenForms["GuessModeScoreBoardForm"];
				m_GuessModeScoreBoardForm.Close();

				MemoryGameScoreBoardForm m_MemoryGaméScoreBoardForm = (MemoryGameScoreBoardForm)Application.OpenForms["MemoryGameScoreBoardForm"];
				m_MemoryGaméScoreBoardForm.Close();

				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();


				this.Close();  // Close this form
			}
			catch
			{

			}
		}

		private void MainMenuButton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				MainMenuButton.BackColor = Color.Yellow;
			}
			catch
			{

			}
		}

		private void MainMenuButton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				MainMenuButton.BackColor = Color.YellowGreen;
			}
			catch
			{

			}
		}

		private void ErazeScoresButton_Click(object sender, EventArgs e)
		{
			try
			{
				Yes_CheckBox.Visible = true;
				No_CheckBox.Visible = true;
				AreUSure_textBox.Visible = true;
				


			}
			catch
			{

			}
		}

		private void ErazeScoresButton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Hand;
				ErazeScoresButton.BackColor = Color.Red;
			}
			catch
			{

			}
		}

		private void ErazeScoresButton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.Default;
				ErazeScoresButton.BackColor = Color.YellowGreen;
			}
			catch
			{

			}
		}

		#endregion

		private void Yes_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				MemoryGameScoreBoardForm m_MemoryGameScoreBoardForm = new MemoryGameScoreBoardForm();
				GuessModeScoreBoardForm m_GuessModeScoreBoardForm = new GuessModeScoreBoardForm();

				#region MemoryGame Eraze Names and Scores

				#region MemoryGame ScoreBoard Names Eraze


				TextWriter m_TextWriter1 = new StreamWriter("XXXCalculator2020Name1mg.txt");
				m_TextWriter1.Write(m_MemoryGameScoreBoardForm.HSMG_Name_Textb1.Text = "");
				m_TextWriter1.Close();

				TextReader m_TextReader1 = new StreamReader("XXXCalculator2020Name1mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Name_Textb1.Text = m_TextReader1.ReadLine();
				m_TextReader1.Close();

				TextWriter m_TextWriter2 = new StreamWriter("XXXCalculator2020Name2mg.txt");
				m_TextWriter2.Write(m_MemoryGameScoreBoardForm.HSMG_Name_Textb2.Text = "");
				m_TextWriter2.Close();

				TextReader m_TextReader2 = new StreamReader("XXXCalculator2020Name2mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Name_Textb1.Text = m_TextReader2.ReadLine();
				m_TextReader2.Close();

				TextWriter m_TextWriter3 = new StreamWriter("XXXCalculator2020Name3mg.txt");
				m_TextWriter3.Write(m_MemoryGameScoreBoardForm.HSMG_Name_Textb3.Text = "");
				m_TextWriter3.Close();

				TextReader m_TextReader3 = new StreamReader("XXXCalculator2020Name3mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Name_Textb3.Text = m_TextReader3.ReadLine();
				m_TextReader3.Close();

				TextWriter m_TextWriter4 = new StreamWriter("XXXCalculator2020Name4mg.txt");
				m_TextWriter4.Write(m_MemoryGameScoreBoardForm.HSMG_Name_Textb4.Text = "");
				m_TextWriter4.Close();

				TextReader m_TextReader4 = new StreamReader("XXXCalculator2020Name4mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Name_Textb4.Text = m_TextReader4.ReadLine();
				m_TextReader4.Close();

				TextWriter m_TextWriter5 = new StreamWriter("XXXCalculator2020Name5mg.txt");
				m_TextWriter5.Write(m_MemoryGameScoreBoardForm.HSMG_Name_Textb5.Text = "");
				m_TextWriter5.Close();

				TextReader m_TextReader5 = new StreamReader("XXXCalculator2020Name5mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Name_Textb5.Text = m_TextReader5.ReadLine();
				m_TextReader5.Close();

				#endregion

				#region MemoryGame ScoreBoard Score Eraze

				TextWriter m_TextWriterScore1 = new StreamWriter("XXXCalculator20201mg.txt");
				m_TextWriterScore1.Write(m_MemoryGameScoreBoardForm.HSMG_Score_Textb1.Text = "-950");
				m_TextWriterScore1.Close();
				//StreamReader didn`t work in realtime, figure it out
				TextReader m_TextReaderScore1 = new StreamReader("XXXCalculator20201mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Score_Textb1.Text = m_TextReaderScore1.ReadLine();
				m_TextReaderScore1.Close();

				TextWriter m_TextWriterScore2 = new StreamWriter("XXXCalculator20202mg.txt");
				m_TextWriterScore2.Write(m_MemoryGameScoreBoardForm.HSMG_Score_Textb2.Text = "-960");
				m_TextWriterScore2.Close();

				TextReader m_TextReaderScore2 = new StreamReader("XXXCalculator20202mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Score_Textb1.Text = m_TextReaderScore2.ReadLine();
				m_TextReaderScore2.Close();


				TextWriter m_TextWriterScore3 = new StreamWriter("XXXCalculator20203mg.txt");
				m_TextWriterScore3.Write(m_MemoryGameScoreBoardForm.HSMG_Score_Textb3.Text = "-970");
				m_TextWriterScore3.Close();

				TextReader m_TextReaderScore3 = new StreamReader("XXXCalculator20203mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Score_Textb3.Text = m_TextReaderScore3.ReadLine();
				m_TextReaderScore3.Close();


				TextWriter m_TextWriterScore4 = new StreamWriter("XXXCalculator20204mg.txt");
				m_TextWriterScore4.Write(m_MemoryGameScoreBoardForm.HSMG_Score_Textb4.Text = "-980");
				m_TextWriterScore4.Close();

				TextReader m_TextReaderScore4 = new StreamReader("XXXCalculator20204mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Score_Textb4.Text = m_TextReaderScore4.ReadLine();
				m_TextReaderScore4.Close();


				TextWriter m_TextWriterScore5 = new StreamWriter("XXXCalculator20205mg.txt");
				m_TextWriterScore5.Write(m_MemoryGameScoreBoardForm.HSMG_Score_Textb5.Text = "-990");
				m_TextWriterScore5.Close();

				TextReader m_TextReaderScore5 = new StreamReader("XXXCalculator20205mg.txt");
				m_MemoryGameScoreBoardForm.HSMG_Score_Textb5.Text = m_TextReaderScore5.ReadLine();
				m_TextReaderScore5.Close();

				#endregion

				#endregion

				#region GuessMode Eraze Names and Scores

				#region GuessMode ScoreBoard Names Eraze
				//m_MemoryGameScoreBoardForm.HSMG_Name_Textb1.ReadOnly = false;
				//m_MemoryGameScoreBoardForm.HSMG_Name_Textb2.ReadOnly = false;
				//m_MemoryGameScoreBoardForm.HSMG_Name_Textb3.ReadOnly = false;
				//m_MemoryGameScoreBoardForm.HSMG_Name_Textb4.ReadOnly = false;
				//m_MemoryGameScoreBoardForm.HSMG_Name_Textb5.ReadOnly = false;

				TextWriter m_TextWriterS1 = new StreamWriter("XXXCalculator2020Name1.txt");
				m_TextWriterS1.Write(m_GuessModeScoreBoardForm.HSGM_Name_Textb1.Text = "");
				m_TextWriterS1.Close();

				TextReader m_TextReaderS1 = new StreamReader("XXXCalculator2020Name1.txt");
				m_GuessModeScoreBoardForm.HSGM_Name_Textb1.Text = m_TextReaderS1.ReadLine();
				m_TextReaderS1.Close();

				TextWriter m_TextWriterS2 = new StreamWriter("XXXCalculator2020Name2.txt");
				m_TextWriterS2.Write(m_GuessModeScoreBoardForm.HSGM_Name_Textb2.Text = "");
				m_TextWriterS2.Close();

				TextReader m_TextReaderS2 = new StreamReader("XXXCalculator2020Name2.txt");
				m_GuessModeScoreBoardForm.HSGM_Name_Textb1.Text = m_TextReaderS2.ReadLine();
				m_TextReaderS2.Close();


				TextWriter m_TextWriterS3 = new StreamWriter("XXXCalculator2020Name3.txt");
				m_TextWriterS3.Write(m_GuessModeScoreBoardForm.HSGM_Name_Textb3.Text = "");
				m_TextWriterS3.Close();

				TextReader m_TextReaderS3 = new StreamReader("XXXCalculator2020Name3.txt");
				m_GuessModeScoreBoardForm.HSGM_Name_Textb3.Text = m_TextReaderS3.ReadLine();
				m_TextReaderS3.Close();


				TextWriter m_TextWriterS4 = new StreamWriter("XXXCalculator2020Name4.txt");
				m_TextWriterS4.Write(m_GuessModeScoreBoardForm.HSGM_Name_Textb4.Text = "");
				m_TextWriterS4.Close();

				TextReader m_TextReaderS4 = new StreamReader("XXXCalculator2020Name4.txt");
				m_GuessModeScoreBoardForm.HSGM_Name_Textb4.Text = m_TextReaderS4.ReadLine();
				m_TextReaderS4.Close();


				TextWriter m_TextWriterS5 = new StreamWriter("XXXCalculator2020Name5.txt");
				m_TextWriterS5.Write(m_GuessModeScoreBoardForm.HSGM_Name_Textb5.Text = "");
				m_TextWriterS5.Close();

				TextReader m_TextReaderS5 = new StreamReader("XXXCalculator2020Name5.txt");
				m_GuessModeScoreBoardForm.HSGM_Name_Textb5.Text = m_TextReaderS5.ReadLine();
				m_TextReaderS5.Close();

				#endregion

				#region GuessMode ScoreBoard Score Eraze

				TextWriter m_TextWriterScoreS1 = new StreamWriter("XXXCalculator20201.txt");
				m_TextWriterScoreS1.Write(m_GuessModeScoreBoardForm.HSGM_Score_Textb1.Text = "-1");
				m_TextWriterScoreS1.Close();
				//StreamReader didn`t work in realtime, figure it out
				TextReader m_TextReaderScoreS1 = new StreamReader("XXXCalculator20201.txt");
				m_GuessModeScoreBoardForm.HSGM_Score_Textb1.Text = m_TextReaderScoreS1.ReadLine();
				m_TextReaderScoreS1.Close();


				TextWriter m_TextWriterScoreS2 = new StreamWriter("XXXCalculator20202.txt");
				m_TextWriterScoreS2.Write(m_GuessModeScoreBoardForm.HSGM_Score_Textb2.Text = "-2");
				m_TextWriterScoreS2.Close();

				TextReader m_TextReaderScoreS2 = new StreamReader("XXXCalculator20202.txt");
				m_GuessModeScoreBoardForm.HSGM_Score_Textb1.Text = m_TextReaderScoreS2.ReadLine();
				m_TextReaderScoreS2.Close();


				TextWriter m_TextWriterScoreS3 = new StreamWriter("XXXCalculator20203.txt");
				m_TextWriterScoreS3.Write(m_GuessModeScoreBoardForm.HSGM_Score_Textb3.Text = "-3");
				m_TextWriterScoreS3.Close();

				TextReader m_TextReaderScoreS3 = new StreamReader("XXXCalculator20203.txt");
				m_GuessModeScoreBoardForm.HSGM_Score_Textb3.Text = m_TextReaderScoreS3.ReadLine();
				m_TextReaderScoreS3.Close();


				TextWriter m_TextWriterScoreS4 = new StreamWriter("XXXCalculator20204.txt");
				m_TextWriterScoreS4.Write(m_GuessModeScoreBoardForm.HSGM_Score_Textb4.Text = "-4");
				m_TextWriterScoreS4.Close();

				TextReader m_TextReaderScoreS4 = new StreamReader("XXXCalculator20204.txt");
				m_GuessModeScoreBoardForm.HSGM_Score_Textb4.Text = m_TextReaderScoreS4.ReadLine();
				m_TextReaderScoreS4.Close();


				TextWriter m_TextWriterScoreS5 = new StreamWriter("XXXCalculator20205.txt");
				m_TextWriterScoreS5.Write(m_GuessModeScoreBoardForm.HSGM_Score_Textb5.Text = "-5");
				m_TextWriterScoreS5.Close();

				TextReader m_TextReaderScoreS5 = new StreamReader("XXXCalculator20205.txt");
				m_GuessModeScoreBoardForm.HSGM_Score_Textb5.Text = m_TextReaderScoreS5.ReadLine();
				m_TextReaderScoreS5.Close();

				#endregion

				//m_MemoryGameScoreBoardForm.HSMG_Score_Textb1.ForeColor = Color.Black;
				//m_MemoryGameScoreBoardForm.HSMG_Score_Textb2.ForeColor = Color.Black;
				//m_MemoryGameScoreBoardForm.HSMG_Score_Textb3.ForeColor = Color.Black;
				//m_MemoryGameScoreBoardForm.HSMG_Score_Textb4.ForeColor = Color.Black;
				//m_MemoryGameScoreBoardForm.HSMG_Score_Textb5.ForeColor = Color.Black;

				//m_GuessModeScoreBoardForm.HSGM_Score_Textb1.ForeColor = Color.Black;
				//m_GuessModeScoreBoardForm.HSGM_Score_Textb2.ForeColor = Color.Black;
				//m_GuessModeScoreBoardForm.HSGM_Score_Textb3.ForeColor = Color.Black;
				//m_GuessModeScoreBoardForm.HSGM_Score_Textb4.ForeColor = Color.Black;
				//m_GuessModeScoreBoardForm.HSGM_Score_Textb5.ForeColor = Color.Black;

				//MessageBox.Show("NAHKA VEIKKO");

				#endregion

				#region Loads GuessMode/MemoryGame Forms again
				// Close the form if it`s already open


				m_GuessModeScoreBoardForm = (GuessModeScoreBoardForm)Application.OpenForms["GuessModeScoreBoardForm"];
				m_GuessModeScoreBoardForm.Close();

				m_MemoryGameScoreBoardForm = (MemoryGameScoreBoardForm)Application.OpenForms["MemoryGameScoreBoardForm"];
				m_MemoryGameScoreBoardForm.Close();

				MessageBox.Show("SCOREBOARDS ARE NOW ERAZED");

				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();
				this.Close();



				#endregion
			}
			catch
			{

			}
		}

		private void No_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				Yes_CheckBox.Visible = false;
				No_CheckBox.Visible = false;
				AreUSure_textBox.Visible = false;
				No_CheckBox.CheckState = CheckState.Unchecked;

			}
			catch
			{

			}
		}
	}
}
