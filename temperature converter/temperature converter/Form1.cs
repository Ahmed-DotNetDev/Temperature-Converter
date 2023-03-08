using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperature_converter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnconvert_Click(object sender, EventArgs e)
		{
			try
			{
				double celsiusValue = Double.Parse(lblcelsius.Text);
				double result = (celsiusValue * 9 / 5) + 32;
				lblfahrenheit.Text = result.ToString();
			}
			catch (Exception E)
			{

                Console.WriteLine(E.Message);
            }
			
		}
	}
}
