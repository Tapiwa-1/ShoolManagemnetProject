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
using System.Runtime.InteropServices;


namespace SchoolProject
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			PwordBx.PasswordChar = '*';
			PwordBx.MaxLength = 10;
			int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
			style |= NativeWinAPI.WS_EX_COMPOSITED;
			NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
		}

		private void CloseBtn_MouseEnter(object sender, EventArgs e)
		{
			CloseBtn.Image = Properties.Resources.CloseHover;
		}

		private void CloseBtn_MouseLeave(object sender, EventArgs e)
		{
			CloseBtn.Image = Properties.Resources.CloseNormal;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void LoginBtn_MouseEnter(object sender, EventArgs e)
		{
			LoginBtn.Image = Properties.Resources.LoginHover;
		}

		private void LoginBtn_MouseLeave(object sender, EventArgs e)
		{
			LoginBtn.Image = Properties.Resources.LoginNormal;
		}

		private void SignInBtn_MouseEnter(object sender, EventArgs e)
		{
			SignInBtn.Image = Properties.Resources.SigninHover;
		}

		private void SignInBtn_MouseLeave(object sender, EventArgs e)
		{
			SignInBtn.Image = Properties.Resources.SigninNormal;
		}
		public void signUP()
		{

		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			string path = System.AppDomain.CurrentDomain.BaseDirectory;
			FileStream f = new FileStream(path + "UsernameAndPassword.txt", FileMode.Open);
			StreamReader s = new StreamReader(f);

			string Uname, Pword;
			bool found = false;


			Uname = UserNmBox.Text;
			Pword = PwordBx.Text;
			string line = "";

			while ((line = s.ReadLine()) != null)
			{
				if (line.Contains(Uname) == true && line.Contains(Pword))
				{
					this.Hide();
					found = true;
					s.Close();
					f.Close();
					Form2 f2 = new Form2();
					f2.ShowDialog();
					break;
				}
			}
			if (found == false)
			{
				MessageBox.Show("UserName Detail Not Found Reinput or Signin UP");
				s.Close();
				f.Close();
			}
		}
		private void SignInBtn_Click(object sender, EventArgs e)
		{
			string path = System.AppDomain.CurrentDomain.BaseDirectory;
			FileStream f1 = new FileStream(path + "UsernameAndPassword.txt", FileMode.OpenOrCreate);
			StreamReader s1 = new StreamReader(f1);

			string Uname, Pword;
			bool found = false;


			Uname = UserNmBox.Text;
			Pword = PwordBx.Text;
			string line = "";

			while ((line = s1.ReadLine()) != null)
			{
				if ((line.Contains(Uname) == true && line.Contains(Pword)))
				{
					MessageBox.Show("Details already Entered");
					found = true;
					break;
				}

			}
			s1.Close();
			f1.Close();
			if (found == false)
			{
				Entering_New_user(ref Uname, ref Pword);
			}
		}
		public void Entering_New_user(ref string Unmae, ref string Pword)
			{
			string path = System.AppDomain.CurrentDomain.BaseDirectory;
			FileStream f1 = new FileStream(path + "UsernameAndPassword.txt", FileMode.Append);
			StreamWriter s1 = new StreamWriter(f1);

			s1.WriteLine(Unmae + "\t" + Pword);
			MessageBox.Show("Username Created Now Log in");
			s1.Close();
			f1.Close();
		}
		
		

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
