using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace SchoolProject
{
	public partial class Form3 : Form
	{
		
		public Form3()
		{
			InitializeComponent();

			int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
			style |= NativeWinAPI.WS_EX_COMPOSITED;
			NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
		}

		

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void CloseBtn_MouseEnter(object sender, EventArgs e)
		{
			closeBtn.Image = Properties.Resources.CloseHover;
		}

		private void CloseBtn_MouseLeave(object sender, EventArgs e)
		{
			closeBtn.Image = Properties.Resources.CloseNormal;
		}

		private void BackBtn_MouseEnter(object sender, EventArgs e)
		{
			BackBtn.Image = Properties.Resources.BackHover;
		}

		private void BackBtn_MouseLeave(object sender, EventArgs e)
		{
			BackBtn.Image = Properties.Resources.BackNormal;
		}

		private void HomeBtn_MouseEnter(object sender, EventArgs e)
		{
			HomeBtn.Image = Properties.Resources.homeHover;
		}

		private void HomeBtn_MouseLeave(object sender, EventArgs e)
		{
			HomeBtn.Image = Properties.Resources.homeNormal;
		}

		private void HomeBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();
			f1.ShowDialog();
		}

		private void BackBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void Allstudbtn_MouseEnter(object sender, EventArgs e)
		{
			Allstudbtn.Image = Properties.Resources.AllstudHover;
		}

		private void Allstudbtn_MouseLeave(object sender, EventArgs e)
		{
			Allstudbtn.Image = Properties.Resources.AllstudNormal;
		}

		private void Allstudbtn_Click(object sender, EventArgs e)
		{
			

		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'studentDetailsDataSet1.Table1' table. You can move, or remove it, as needed.
			this.table1TableAdapter.Fill(this.studentDetailsDataSet1.Table1);

		}
	}
}
