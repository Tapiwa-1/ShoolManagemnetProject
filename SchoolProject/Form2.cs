using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SchoolProject
{
	internal static class NativeWinAPI
	{
		internal static readonly int GWL_EXSTYLE = -20;
		internal static readonly int WS_EX_COMPOSITED = 0x02000000;

		[DllImport("user32")]
		internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32")]
		internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
	}
	public partial class Form2 : Form
	{
		public Form2()
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

		private void BackBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();
			f1.ShowDialog();
		}

		private void BackBtn_MouseEnter(object sender, EventArgs e)
		{
			BackBtn.Image = Properties.Resources.BackHover;
		}

		private void BackBtn_MouseLeave(object sender, EventArgs e)
		{
			BackBtn.Image = Properties.Resources.BackNormal;
		}

		private void AddStuBtn_MouseEnter(object sender, EventArgs e)
		{
			AddStuBtn.Image = Properties.Resources.addstutHover;
		}

		private void AddStuBtn_MouseLeave(object sender, EventArgs e)
		{
			AddStuBtn.Image = Properties.Resources.addstutNormal;
		}

		private void AllstudBtn_MouseEnter(object sender, EventArgs e)
		{
			AllstudBtn.Image = Properties.Resources.AllstudHover;
		}

		private void AllstudBtn_MouseLeave(object sender, EventArgs e)
		{
			AllstudBtn.Image = Properties.Resources.AllstudNormal;
		}

		private void DelStudBtn_MouseEnter(object sender, EventArgs e)
		{
			DelStudBtn.Image = Properties.Resources.DeleteStudHover;
		}

		private void DelStudBtn_MouseLeave(object sender, EventArgs e)
		{
			DelStudBtn.Image = Properties.Resources.DeleteStudNormal;
		}

		private void AllstudBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form3 f3 = new Form3();
			f3.ShowDialog();
		}

		private void DelStudBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			DeleteForm d4 = new DeleteForm();
			d4.ShowDialog();
		}

		private void AddStuBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			addStud add1 = new addStud();
			add1.ShowDialog();
		}
	}
}
