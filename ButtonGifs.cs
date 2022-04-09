using System.Windows.Forms;

namespace XXXCalculator2020
{
	public partial class ButtonGifs : Form
	{       // u can do it also this way (Forms new start position) 
	        //Form m_FormNewPlace = new Form();   
		public ButtonGifs()
		{
			InitializeComponent();
			// u can do it also this way (Forms new start position)
		      this.StartPosition = FormStartPosition.Manual;
			  this.Location = new System.Drawing.Point(0,0);   
		}

		private void ButtonGifs_Load(object sender, System.EventArgs e)
		{
			try
			{
				//m_FormNewPlace.Location = new System.Drawing.Point(0,0);  // new location on load (this form) but form need to set manual on UI
			}
			catch
			{

			}
		}
	}
}
