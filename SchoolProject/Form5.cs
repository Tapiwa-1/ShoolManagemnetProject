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
	
	public partial class addStud : Form
	{
		public addStud()
		{
			InitializeComponent();

			int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
			style |= NativeWinAPI.WS_EX_COMPOSITED;
			NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
		}

		private void HomeBtn_MouseEnter(object sender, EventArgs e)
		{
			HomeBtn.Image = Properties.Resources.homeHover;
		}

		private void HomeBtn_MouseLeave(object sender, EventArgs e)
		{
			HomeBtn.Image = Properties.Resources.homeNormal;
		}

		private void BackBtn_MouseEnter(object sender, EventArgs e)
		{
			BackBtn.Image = Properties.Resources.BackHover;
		}

		private void BackBtn_MouseLeave(object sender, EventArgs e)
		{
			BackBtn.Image = Properties.Resources.BackNormal;
		}

		private void CloseBtn_MouseEnter(object sender, EventArgs e)
		{
			CloseBtn.Image = Properties.Resources.CloseHover;
		}

		private void CloseBtn_MouseLeave(object sender, EventArgs e)
		{
			CloseBtn.Image = Properties.Resources.CloseNormal;
		}

		private void AddStudentBtn_MouseEnter(object sender, EventArgs e)
		{
			AddStudentBtn.Image = Properties.Resources.addstutHover;
		}

		private void AddStudentBtn_MouseLeave(object sender, EventArgs e)
		{
			AddStudentBtn.Image = Properties.Resources.addstutNormal;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BackBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}

		private void HomeBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();
			f1.ShowDialog();
		}
		
		private void AddStudentBtn_Click(object sender, EventArgs e)
		{
			

			string StudName="", StudSurn="", StudGender = "", StudClass = "", studage="";
			StudName = StudentName.Text;
			StudSurn = StudentSurnmae.Text;
			studage = StudentAge.Text;
			int numericValue;
			bool Isnum;
			if (isarb.Checked)
			{
				StudClass = "ISA";
			}
			if(serb.Checked)
			{
				StudClass = "SE";
			}
			if (csrb.Checked)
			{
				StudClass = "CS";
			}
			if (itrb.Checked)
			{
				StudClass = "IT";
			}
			if (malerb.Checked)
			{
				StudGender = "Male";
			}
			if (femalerb.Checked)
			{
				StudGender = "Female";
			}
			if(StudClass == "" ||studage ==""||studage ==""||StudName ==""||StudSurn =="")
			{
				MessageBox.Show("All fields Must be filled");
				
			}else
			{
				bool containsInt = StudSurn.Any(char.IsDigit);
				bool containsInt2 = StudSurn.Any(char.IsDigit);
				bool isNumber = int.TryParse(studage, out numericValue);
				if (containsInt == true || containsInt2 == true)
				{
					MessageBox.Show("Name and Surname Should not contain a number");
				}
				else
				{
					if (isNumber == true)
					{
						System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
						conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=studentDetails.accdb";

						try

						{
							conn.Open();

							String my_query = "INSERT INTO `Table1` (`StudentName`,`StudentSurname`,`StudentAge`,`StudentClass`,`StudentGender`) VALUES ('" + StudName + "', '" + StudSurn + "','" + studage + "', '" + StudClass + "','" + StudGender + "')";

							OleDbCommand cmd = new OleDbCommand(my_query, conn);
							cmd.ExecuteNonQuery();

							MessageBox.Show("Saved");

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
					else
					{
						MessageBox.Show("Age should be a number");
					}
				}
				
				
			}
			
				
				
			
			
		}
	}
}

