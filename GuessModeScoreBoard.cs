using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  // file saver or loader

namespace XXXCalculator2020
{
	public partial class GuessModeScoreBoardForm : Form
	{
		 // problem lies here if scoreboards get stucked
		public GuessModeScoreBoardForm()
		{
			InitializeComponent();
			
			this.Location = new Point(1200,0);   // Location of this form on windowns desktop
			

		}
		#region ALL HSGM NAME TEXTBOXES KEYDOWNS(Enter) & NAME FILE SAVER

		private void HSGM_Name_TextbALL_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Enter)
				{
					#region Name1
					TextWriter m_TextWriter1 = new StreamWriter("XXXCalculator2020Name1.txt");
					m_TextWriter1.Write(HSGM_Name_Textb1.Text);
					m_TextWriter1.Close();

					TextReader m_TextReader1 = new StreamReader("XXXCalculator2020Name1.txt");
					HSGM_Name_Textb1.Text = m_TextReader1.ReadLine();
					m_TextReader1.Close();
					HSGM_Name_Textb1.BackColor = Color.Black;
					HSGM_Name_Textb1.ReadOnly = true;
					HSGM_Name_Textb1.Enabled = false;
					#endregion

					#region Name2
					TextWriter m_TextWriter2 = new StreamWriter("XXXCalculator2020Name2.txt");
					m_TextWriter2.Write(HSGM_Name_Textb2.Text);
					m_TextWriter2.Close();

					TextReader m_TextReader2 = new StreamReader("XXXCalculator2020Name2.txt");
					HSGM_Name_Textb2.Text = m_TextReader2.ReadLine();
					m_TextReader2.Close();
					HSGM_Name_Textb2.BackColor = Color.Black;
					HSGM_Name_Textb2.ReadOnly = true;
					HSGM_Name_Textb2.Enabled = false;
					#endregion

					#region Name3
					TextWriter m_TextWriter3 = new StreamWriter("XXXCalculator2020Name3.txt");
					m_TextWriter3.Write(HSGM_Name_Textb3.Text);
					m_TextWriter3.Close();

					TextReader m_TextReader3 = new StreamReader("XXXCalculator2020Name3.txt");
					HSGM_Name_Textb3.Text = m_TextReader3.ReadLine();
					m_TextReader3.Close();
					HSGM_Name_Textb3.BackColor = Color.Black;
					HSGM_Name_Textb3.ReadOnly = true;
					HSGM_Name_Textb3.Enabled = false;
					#endregion

					#region Name4
					TextWriter m_TextWriter4 = new StreamWriter("XXXCalculator2020Name4.txt");
					m_TextWriter4.Write(HSGM_Name_Textb4.Text);
					m_TextWriter4.Close();

					TextReader m_TextReader4 = new StreamReader("XXXCalculator2020Name4.txt");
					HSGM_Name_Textb4.Text = m_TextReader4.ReadLine();
					m_TextReader4.Close();
					HSGM_Name_Textb4.BackColor = Color.Black;
					HSGM_Name_Textb4.ReadOnly = true;
					HSGM_Name_Textb4.Enabled = false;
					#endregion

					#region Name5
					TextWriter m_TextWriter5 = new StreamWriter("XXXCalculator2020Name5.txt");
					m_TextWriter5.Write(HSGM_Name_Textb5.Text);
					m_TextWriter5.Close();

					TextReader m_TextReader5 = new StreamReader("XXXCalculator2020Name5.txt");
					HSGM_Name_Textb5.Text = m_TextReader5.ReadLine();
					m_TextReader5.Close();
					HSGM_Name_Textb5.BackColor = Color.Black;
					HSGM_Name_Textb5.ReadOnly = true;
					HSGM_Name_Textb5.Enabled = false;
					#endregion
									

				}
			}
			catch
			{

			}
		}

		#endregion

		#region FORM LOAD (Loads saved files)
		private void GuessModeScoreBoardForm_Load(object sender, EventArgs e)
		{
			try
			{
				#region TextReaderScoreAndName1

				TextReader m_TextReader1 = new StreamReader("XXXCalculator20201.txt");
				HSGM_Score_Textb1.Text = m_TextReader1.ReadLine();
				m_TextReader1.Close();

				TextReader m_TextReaderName1 = new StreamReader("XXXCalculator2020Name1.txt");
				HSGM_Name_Textb1.Text = m_TextReaderName1.ReadLine();
				m_TextReaderName1.Close();
				#endregion

				#region TextReaderScoreAndName2
				TextReader m_TextReader2 = new StreamReader("XXXCalculator20202.txt");
				HSGM_Score_Textb2.Text = m_TextReader2.ReadLine();
				m_TextReader2.Close();

				TextReader m_TextReaderName2 = new StreamReader("XXXCalculator2020Name2.txt");
				HSGM_Name_Textb2.Text = m_TextReaderName2.ReadLine();
				m_TextReaderName2.Close();
				#endregion

				#region TextReaderScoreAndName3
				TextReader m_TextReader3 = new StreamReader("XXXCalculator20203.txt");
				HSGM_Score_Textb3.Text = m_TextReader3.ReadLine();
				m_TextReader3.Close();

				TextReader m_TextReaderName3 = new StreamReader("XXXCalculator2020Name3.txt");
				HSGM_Name_Textb3.Text = m_TextReaderName3.ReadLine();
				m_TextReaderName3.Close();
				#endregion

				#region TextReaderScoreAndName4
				TextReader m_TextReader4 = new StreamReader("XXXCalculator20204.txt");
				HSGM_Score_Textb4.Text = m_TextReader4.ReadLine();
				m_TextReader4.Close();

				TextReader m_TextReaderName4 = new StreamReader("XXXCalculator2020Name4.txt");
				HSGM_Name_Textb4.Text = m_TextReaderName4.ReadLine();
				m_TextReaderName4.Close();
				#endregion

				#region TextReaderScoreAndName5
				TextReader m_TextReader5 = new StreamReader("XXXCalculator20205.txt");
				HSGM_Score_Textb5.Text = m_TextReader5.ReadLine();
				m_TextReader5.Close();

				TextReader m_TextReaderName5 = new StreamReader("XXXCalculator2020Name5.txt");
				HSGM_Name_Textb5.Text = m_TextReaderName5.ReadLine();
				m_TextReaderName5.Close();
				#endregion


				#region After Eraze
								
				if ((HSGM_Score_Textb1.Text == "-1") && (HSGM_Name_Textb1.BackColor == Color.Black))
			    {
					
					HSGM_Score_Textb1.ForeColor = Color.Black;
				    HSGM_Score_Textb2.ForeColor = Color.Black;
					HSGM_Score_Textb3.ForeColor = Color.Black;
					HSGM_Score_Textb4.ForeColor = Color.Black;
					HSGM_Score_Textb5.ForeColor = Color.Black;
					
				}
				    				   
				else if ((HSGM_Score_Textb2.Text == "-2") && (HSGM_Name_Textb2.BackColor == Color.Black))
				{
					HSGM_Score_Textb2.ForeColor = Color.Black;
					HSGM_Score_Textb3.ForeColor = Color.Black;
					HSGM_Score_Textb4.ForeColor = Color.Black;
					HSGM_Score_Textb5.ForeColor = Color.Black;
					
				}
				   
								
				 else if ((HSGM_Score_Textb3.Text == "-3") && (HSGM_Name_Textb3.BackColor == Color.Black))
				{
					
					HSGM_Score_Textb3.ForeColor = Color.Black;
					HSGM_Score_Textb4.ForeColor = Color.Black;
					HSGM_Score_Textb5.ForeColor = Color.Black;
					
				}
				
				
				else if ((HSGM_Score_Textb4.Text == "-4") && (HSGM_Name_Textb4.BackColor == Color.Black))
				{
										
					HSGM_Score_Textb4.ForeColor = Color.Black;
					HSGM_Score_Textb5.ForeColor = Color.Black;
					
				}
				
								
				else  if ((HSGM_Score_Textb5.Text == "-5") && (HSGM_Name_Textb5.BackColor == Color.Black))
				{
										
					HSGM_Score_Textb5.ForeColor = Color.Black;
					
				}
				
				
				#endregion

			}
			catch
			{

			}
		}
		#endregion
	}
}
