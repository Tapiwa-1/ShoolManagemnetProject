namespace SchoolProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.UserNmBox = new System.Windows.Forms.TextBox();
			this.PwordBx = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SignInBtn = new System.Windows.Forms.PictureBox();
			this.LoginBtn = new System.Windows.Forms.PictureBox();
			this.CloseBtn = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SignInBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// UserNmBox
			// 
			this.UserNmBox.BackColor = System.Drawing.Color.IndianRed;
			this.UserNmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UserNmBox.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserNmBox.Location = new System.Drawing.Point(336, 219);
			this.UserNmBox.Name = "UserNmBox";
			this.UserNmBox.Size = new System.Drawing.Size(348, 56);
			this.UserNmBox.TabIndex = 3;
			this.UserNmBox.Text = "Username";
			// 
			// PwordBx
			// 
			this.PwordBx.BackColor = System.Drawing.Color.IndianRed;
			this.PwordBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PwordBx.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PwordBx.Location = new System.Drawing.Point(336, 328);
			this.PwordBx.Name = "PwordBx";
			this.PwordBx.Size = new System.Drawing.Size(348, 56);
			this.PwordBx.TabIndex = 4;
			this.PwordBx.Text = "Password";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SchoolProject.Properties.Resources.HIT_logo;
			this.pictureBox1.Location = new System.Drawing.Point(415, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(170, 87);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// SignInBtn
			// 
			this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignInBtn.Image = global::SchoolProject.Properties.Resources.SigninHover;
			this.SignInBtn.Location = new System.Drawing.Point(336, 512);
			this.SignInBtn.Name = "SignInBtn";
			this.SignInBtn.Size = new System.Drawing.Size(349, 78);
			this.SignInBtn.TabIndex = 2;
			this.SignInBtn.TabStop = false;
			this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
			this.SignInBtn.MouseEnter += new System.EventHandler(this.SignInBtn_MouseEnter);
			this.SignInBtn.MouseLeave += new System.EventHandler(this.SignInBtn_MouseLeave);
			// 
			// LoginBtn
			// 
			this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LoginBtn.Image = global::SchoolProject.Properties.Resources.LoginNormal;
			this.LoginBtn.Location = new System.Drawing.Point(336, 421);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(349, 71);
			this.LoginBtn.TabIndex = 1;
			this.LoginBtn.TabStop = false;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			this.LoginBtn.MouseEnter += new System.EventHandler(this.LoginBtn_MouseEnter);
			this.LoginBtn.MouseLeave += new System.EventHandler(this.LoginBtn_MouseLeave);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseBtn.Image = global::SchoolProject.Properties.Resources.CloseHover;
			this.CloseBtn.Location = new System.Drawing.Point(1024, 0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(35, 36);
			this.CloseBtn.TabIndex = 0;
			this.CloseBtn.TabStop = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			this.CloseBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
			this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
			this.ClientSize = new System.Drawing.Size(1061, 634);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PwordBx);
			this.Controls.Add(this.UserNmBox);
			this.Controls.Add(this.SignInBtn);
			this.Controls.Add(this.LoginBtn);
			this.Controls.Add(this.CloseBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SignInBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LoginBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox CloseBtn;
		private System.Windows.Forms.PictureBox LoginBtn;
		private System.Windows.Forms.PictureBox SignInBtn;
		private System.Windows.Forms.TextBox UserNmBox;
		private System.Windows.Forms.TextBox PwordBx;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

