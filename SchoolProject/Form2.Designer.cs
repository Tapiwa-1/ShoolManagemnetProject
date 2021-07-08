namespace SchoolProject
{
	partial class Form2
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.BackBtn = new System.Windows.Forms.PictureBox();
			this.DelStudBtn = new System.Windows.Forms.PictureBox();
			this.AllstudBtn = new System.Windows.Forms.PictureBox();
			this.AddStuBtn = new System.Windows.Forms.PictureBox();
			this.closeBtn = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DelStudBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AllstudBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddStuBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::SchoolProject.Properties.Resources.HIT_logo;
			this.pictureBox2.Location = new System.Drawing.Point(422, 152);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(161, 79);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// BackBtn
			// 
			this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BackBtn.Image = global::SchoolProject.Properties.Resources.BackNormal;
			this.BackBtn.Location = new System.Drawing.Point(0, 0);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(43, 38);
			this.BackBtn.TabIndex = 4;
			this.BackBtn.TabStop = false;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			this.BackBtn.MouseEnter += new System.EventHandler(this.BackBtn_MouseEnter);
			this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
			// 
			// DelStudBtn
			// 
			this.DelStudBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DelStudBtn.Image = global::SchoolProject.Properties.Resources.DeleteStudNormal;
			this.DelStudBtn.Location = new System.Drawing.Point(340, 408);
			this.DelStudBtn.Name = "DelStudBtn";
			this.DelStudBtn.Size = new System.Drawing.Size(347, 74);
			this.DelStudBtn.TabIndex = 3;
			this.DelStudBtn.TabStop = false;
			this.DelStudBtn.Click += new System.EventHandler(this.DelStudBtn_Click);
			this.DelStudBtn.MouseEnter += new System.EventHandler(this.DelStudBtn_MouseEnter);
			this.DelStudBtn.MouseLeave += new System.EventHandler(this.DelStudBtn_MouseLeave);
			// 
			// AllstudBtn
			// 
			this.AllstudBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AllstudBtn.Image = global::SchoolProject.Properties.Resources.AllstudNormal;
			this.AllstudBtn.Location = new System.Drawing.Point(340, 320);
			this.AllstudBtn.Name = "AllstudBtn";
			this.AllstudBtn.Size = new System.Drawing.Size(347, 82);
			this.AllstudBtn.TabIndex = 2;
			this.AllstudBtn.TabStop = false;
			this.AllstudBtn.Click += new System.EventHandler(this.AllstudBtn_Click);
			this.AllstudBtn.MouseEnter += new System.EventHandler(this.AllstudBtn_MouseEnter);
			this.AllstudBtn.MouseLeave += new System.EventHandler(this.AllstudBtn_MouseLeave);
			// 
			// AddStuBtn
			// 
			this.AddStuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddStuBtn.Image = global::SchoolProject.Properties.Resources.addstutNormal;
			this.AddStuBtn.Location = new System.Drawing.Point(340, 237);
			this.AddStuBtn.Name = "AddStuBtn";
			this.AddStuBtn.Size = new System.Drawing.Size(347, 77);
			this.AddStuBtn.TabIndex = 1;
			this.AddStuBtn.TabStop = false;
			this.AddStuBtn.Click += new System.EventHandler(this.AddStuBtn_Click);
			this.AddStuBtn.MouseEnter += new System.EventHandler(this.AddStuBtn_MouseEnter);
			this.AddStuBtn.MouseLeave += new System.EventHandler(this.AddStuBtn_MouseLeave);
			// 
			// closeBtn
			// 
			this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeBtn.Image = global::SchoolProject.Properties.Resources.CloseNormal;
			this.closeBtn.Location = new System.Drawing.Point(1028, -2);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(37, 40);
			this.closeBtn.TabIndex = 0;
			this.closeBtn.TabStop = false;
			this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			this.closeBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
			this.closeBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
			this.ClientSize = new System.Drawing.Size(1061, 634);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.DelStudBtn);
			this.Controls.Add(this.AllstudBtn);
			this.Controls.Add(this.AddStuBtn);
			this.Controls.Add(this.closeBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DelStudBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AllstudBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddStuBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox closeBtn;
		private System.Windows.Forms.PictureBox AddStuBtn;
		private System.Windows.Forms.PictureBox AllstudBtn;
		private System.Windows.Forms.PictureBox DelStudBtn;
		private System.Windows.Forms.PictureBox BackBtn;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}