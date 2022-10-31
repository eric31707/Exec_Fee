using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			moneylbl.Text = string.Empty;
			reasonlbl.Text = string.Empty;
		}

		private void calcubtn_Click(object sender, EventArgs e)
		{
			try
			{
				int age = Convert.ToInt32(agetxt.Text);
				if (age <= 3)
				{
					moneylbl.Text = "0元";
					reasonlbl.Text = "三歲以下免費";
				}
				else if (age >= 70 && boybtn.Checked)
				{
					moneylbl.Text = "2元";
					reasonlbl.Text = "超過70歲男性";
				}
				else if (age >= 60 && girlbtn.Checked)
				{
					moneylbl.Text = "3元";
					reasonlbl.Text = "超過60歲女性";
				}
				else
				{
					moneylbl.Text = "15元";
					reasonlbl.Text = "全票";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
