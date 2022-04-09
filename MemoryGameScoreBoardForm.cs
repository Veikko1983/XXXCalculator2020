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
using System.IO;

namespace XXXCalculator2020
{
	public partial class MemoryGameScoreBoardForm : Form
	{
		
		// GuessModeScoreBoardForm m_GuessModeScoreBoardForm = new GuessModeScoreBoardForm();
		

		
		public MemoryGameScoreBoardForm()
		{
			InitializeComponent();
			
			this.Location = new Point(0,0);  // Location of this form on windowns desktop, 0,0 means top of the left upcorner
			
						
		}
		#region Exit Button Click,Enter,Leave
		private void HighScoreMGameButton_Click(object sender, EventArgs e)  // Exit button X, close 2 forms
		{
			try
			{
												
				// Close the form if it`s already open
				GuessModeScoreBoardForm m_GuessModeScoreBoardForm = (GuessModeScoreBoardForm)Application.OpenForms["GuessModeScoreBoardForm"];
				m_GuessModeScoreBoardForm.Close();

				ExitButtonToMGameScoreB.Visible = false;
				
				MainMenuForm m_MainMenuForm = new MainMenuForm();
				m_MainMenuForm.Show();


				this.Close();  // Close this form
					
			}
			catch
			{

			}
		}

		private void HighScoreMGameButton_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				ExitButtonToMGameScoreB.BackColor = Color.Red;
				Cursor = Cursors.Hand;

			}
			catch
			{

			}
		}

		private void HighScoreMGameButton_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				ExitButtonToMGameScoreB.BackColor = Color.WhiteSmoke;
				Cursor = Cursors.Default;

			}
			catch
			{

			}
		}
		#endregion

		#region Form Load
		private void MemoryGameScoreBoardForm_Load(object sender, EventArgs e)
		{
			try
			{
				
					try
					{
					
					    #region TextReaderScoreAndName1

					    TextReader m_TextReader1 = new StreamReader("XXXCalculator20201mg.txt");
						HSMG_Score_Textb1.Text = m_TextReader1.ReadLine();
						m_TextReader1.Close();

						TextReader m_TextReaderName1 = new StreamReader("XXXCalculator2020Name1mg.txt");
						HSMG_Name_Textb1.Text = m_TextReaderName1.ReadLine();
						m_TextReaderName1.Close();
						#endregion

						#region TextReaderScoreAndName2
						TextReader m_TextReader2 = new StreamReader("XXXCalculator20202mg.txt");
						HSMG_Score_Textb2.Text = m_TextReader2.ReadLine();
						m_TextReader2.Close();

						TextReader m_TextReaderName2 = new StreamReader("XXXCalculator2020Name2mg.txt");
						HSMG_Name_Textb2.Text = m_TextReaderName2.ReadLine();
						m_TextReaderName2.Close();
						#endregion

						#region TextReaderScoreAndName3
						TextReader m_TextReader3 = new StreamReader("XXXCalculator20203mg.txt");
						HSMG_Score_Textb3.Text = m_TextReader3.ReadLine();
						m_TextReader3.Close();

						TextReader m_TextReaderName3 = new StreamReader("XXXCalculator2020Name3mg.txt");
						HSMG_Name_Textb3.Text = m_TextReaderName3.ReadLine();
						m_TextReaderName3.Close();
						#endregion

						#region TextReaderScoreAndName4
						TextReader m_TextReader4 = new StreamReader("XXXCalculator20204mg.txt");
						HSMG_Score_Textb4.Text = m_TextReader4.ReadLine();
						m_TextReader4.Close();

						TextReader m_TextReaderName4 = new StreamReader("XXXCalculator2020Name4mg.txt");
						HSMG_Name_Textb4.Text = m_TextReaderName4.ReadLine();
						m_TextReaderName4.Close();
						#endregion

						#region TextReaderScoreAndName5
						TextReader m_TextReader5 = new StreamReader("XXXCalculator20205mg.txt");
						HSMG_Score_Textb5.Text = m_TextReader5.ReadLine();
						m_TextReader5.Close();

						TextReader m_TextReaderName5 = new StreamReader("XXXCalculator2020Name5mg.txt");
						HSMG_Name_Textb5.Text = m_TextReaderName5.ReadLine();
						m_TextReaderName5.Close();
					#endregion

					if ((HSMG_Score_Textb1.Text == "-950") && (HSMG_Name_Textb1.BackColor == Color.Black))
					{
						HSMG_Score_Textb1.ForeColor = Color.Black;
						HSMG_Score_Textb2.ForeColor = Color.Black;
						HSMG_Score_Textb3.ForeColor = Color.Black;
						HSMG_Score_Textb4.ForeColor = Color.Black;
						HSMG_Score_Textb5.ForeColor = Color.Black;
						
					}
					else if ((HSMG_Score_Textb2.Text == "-960") && (HSMG_Name_Textb2.BackColor == Color.Black))
					{
						HSMG_Score_Textb2.ForeColor = Color.Black;
						HSMG_Score_Textb3.ForeColor = Color.Black;
						HSMG_Score_Textb4.ForeColor = Color.Black;
						HSMG_Score_Textb5.ForeColor = Color.Black;
						
					}
					else if ((HSMG_Score_Textb3.Text == "-970") && (HSMG_Name_Textb3.BackColor == Color.Black))
					{

						HSMG_Score_Textb3.ForeColor = Color.Black;
						HSMG_Score_Textb4.ForeColor = Color.Black;
						HSMG_Score_Textb5.ForeColor = Color.Black;
						
					}
					else if ((HSMG_Score_Textb4.Text == "-980") && (HSMG_Name_Textb4.BackColor == Color.Black))
					{

						HSMG_Score_Textb4.ForeColor = Color.Black;
						HSMG_Score_Textb5.ForeColor = Color.Black;
						
					}
					else if ((HSMG_Score_Textb5.Text == "-990") && (HSMG_Name_Textb5.BackColor == Color.Black))
					{

						HSMG_Score_Textb5.ForeColor = Color.Black;
						
					}

										
				}
					catch
					{

					}
				

			}
			catch
			{

			}
		}
		#endregion

		#region ALL HSMG NAME TEXTBOXES KEYDOWNS(Enter) & NAME FILE SAVER

		private void HSMG_Name_TextbALL_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					#region Name1
					TextWriter m_TextWriter1 = new StreamWriter("XXXCalculator2020Name1mg.txt");
					m_TextWriter1.Write(HSMG_Name_Textb1.Text);
					m_TextWriter1.Close();

					TextReader m_TextReader1 = new StreamReader("XXXCalculator2020Name1mg.txt");
					HSMG_Name_Textb1.Text = m_TextReader1.ReadLine();
					m_TextReader1.Close();
					HSMG_Name_Textb1.BackColor = Color.Black;
					HSMG_Name_Textb1.ReadOnly = true;
					HSMG_Name_Textb1.Enabled = false;
					#endregion

					#region Name2
					TextWriter m_TextWriter2 = new StreamWriter("XXXCalculator2020Name2mg.txt");
					m_TextWriter2.Write(HSMG_Name_Textb2.Text);
					m_TextWriter2.Close();

					TextReader m_TextReader2 = new StreamReader("XXXCalculator2020Name2mg.txt");
					HSMG_Name_Textb2.Text = m_TextReader2.ReadLine();
					m_TextReader2.Close();
					HSMG_Name_Textb2.BackColor = Color.Black;
					HSMG_Name_Textb2.ReadOnly = true;
					HSMG_Name_Textb2.Enabled = false;
					#endregion

					#region Name3
					TextWriter m_TextWriter3 = new StreamWriter("XXXCalculator2020Name3mg.txt");
					m_TextWriter3.Write(HSMG_Name_Textb3.Text);
					m_TextWriter3.Close();

					TextReader m_TextReader3 = new StreamReader("XXXCalculator2020Name3mg.txt");
					HSMG_Name_Textb3.Text = m_TextReader3.ReadLine();
					m_TextReader3.Close();
					HSMG_Name_Textb3.BackColor = Color.Black;
					HSMG_Name_Textb3.ReadOnly = true;
					HSMG_Name_Textb3.Enabled = false;
					#endregion

					#region Name4
					TextWriter m_TextWriter4 = new StreamWriter("XXXCalculator2020Name4mg.txt");
					m_TextWriter4.Write(HSMG_Name_Textb4.Text);
					m_TextWriter4.Close();

					TextReader m_TextReader4 = new StreamReader("XXXCalculator2020Name4mg.txt");
					HSMG_Name_Textb4.Text = m_TextReader4.ReadLine();
					m_TextReader4.Close();
					HSMG_Name_Textb4.BackColor = Color.Black;
					HSMG_Name_Textb4.ReadOnly = true;
					HSMG_Name_Textb4.Enabled = false;
					#endregion

					#region Name5
					TextWriter m_TextWriter5 = new StreamWriter("XXXCalculator2020Name5mg.txt");
					m_TextWriter5.Write(HSMG_Name_Textb5.Text);
					m_TextWriter5.Close();

					TextReader m_TextReader5 = new StreamReader("XXXCalculator2020Name5mg.txt");
					HSMG_Name_Textb5.Text = m_TextReader5.ReadLine();
					m_TextReader5.Close();
					HSMG_Name_Textb5.BackColor = Color.Black;
					HSMG_Name_Textb5.ReadOnly = true;
					HSMG_Name_Textb5.Enabled = false;
					#endregion


				}
			}
			catch
			{

			}
		}

		#endregion
	}
}
