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
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;


namespace SchoolProject
{
	
	public partial class DeleteForm : Form
	{
		public DeleteForm()
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
			CloseBtn.Image = Properties.Resources.CloseHover;
		}

		private void CloseBtn_MouseLeave(object sender, EventArgs e)
		{
			CloseBtn.Image = Properties.Resources.CloseNormal;
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
	
		private void DelStudBtn_Click(object sender, EventArgs e)
		{
			System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
			conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=studentDetails.accdb";
			string stdName = StudName.Text;
			String stdSurn = StudSurname.Text;
			try

			{
				conn.Open();

				String my_query = "DELETE FROM `Table1` WHERE StudentName = '"+stdName+"' AND StudentSurname ='"+stdSurn+"'";

				OleDbCommand cmd = new OleDbCommand(my_query, conn);
				cmd.ExecuteNonQuery();

				MessageBox.Show("Student Deleted");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{

				conn.Close();
			}
		
				this.Hide();
				Form2 f2 = new Form2();
				f2.ShowDialog();
			
		}

		private void DelStudBtn_MouseEnter(object sender, EventArgs e)
		{
			DelStudBtn.Image = Properties.Resources.DeleteStudHover;
		}

		private void DelStudBtn_MouseLeave(object sender, EventArgs e)
		{
			DelStudBtn.Image = Properties.Resources.DeleteStudNormal;
		}
	}
}
