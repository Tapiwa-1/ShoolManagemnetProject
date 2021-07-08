namespace SchoolProject
{
	partial class DeleteForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.CloseBtn = new System.Windows.Forms.PictureBox();
			this.BackBtn = new System.Windows.Forms.PictureBox();
			this.HomeBtn = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.StudSurname = new System.Windows.Forms.TextBox();
			this.StudName = new System.Windows.Forms.TextBox();
			this.DelStudBtn = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DelStudBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SchoolProject.Properties.Resources.HIT_logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(164, 83);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// CloseBtn
			// 
			this.CloseBtn.Image = global::SchoolProject.Properties.Resources.CloseNormal;
			this.CloseBtn.Location = new System.Drawing.Point(1041, 0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(36, 36);
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.TabStop = false;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			this.CloseBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
			this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
			// 
			// BackBtn
			// 
			this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BackBtn.Image = global::SchoolProject.Properties.Resources.BackNormal;
			this.BackBtn.Location = new System.Drawing.Point(997, 0);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(38, 40);
			this.BackBtn.TabIndex = 2;
			this.BackBtn.TabStop = false;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			this.BackBtn.MouseEnter += new System.EventHandler(this.BackBtn_MouseEnter);
			this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
			// 
			// HomeBtn
			// 
			this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HomeBtn.Image = global::SchoolProject.Properties.Resources.homeNormal;
			this.HomeBtn.Location = new System.Drawing.Point(949, 1);
			this.HomeBtn.Name = "HomeBtn";
			this.HomeBtn.Size = new System.Drawing.Size(42, 39);
			this.HomeBtn.TabIndex = 3;
			this.HomeBtn.TabStop = false;
			this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
			this.HomeBtn.MouseEnter += new System.EventHandler(this.HomeBtn_MouseEnter);
			this.HomeBtn.MouseLeave += new System.EventHandler(this.HomeBtn_MouseLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(337, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 31);
			this.label1.TabIndex = 4;
			this.label1.Text = "DELETING STUDENT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(150, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 31);
			this.label2.TabIndex = 5;
			this.label2.Text = "STUDENT NAME";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(150, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(238, 31);
			this.label3.TabIndex = 6;
			this.label3.Text = "STUDENT SURNAME";
			// 
			// StudSurname
			// 
			this.StudSurname.BackColor = System.Drawing.Color.IndianRed;
			this.StudSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.StudSurname.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudSurname.Location = new System.Drawing.Point(440, 272);
			this.StudSurname.Name = "StudSurname";
			this.StudSurname.Size = new System.Drawing.Size(304, 31);
			this.StudSurname.TabIndex = 7;
			// 
			// StudName
			// 
			this.StudName.BackColor = System.Drawing.Color.IndianRed;
			this.StudName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.StudName.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StudName.Location = new System.Drawing.Point(440, 201);
			this.StudName.Name = "StudName";
			this.StudName.Size = new System.Drawing.Size(304, 31);
			this.StudName.TabIndex = 8;
			// 
			// DelStudBtn
			// 
			this.DelStudBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DelStudBtn.Image = global::SchoolProject.Properties.Resources.DeleteStudNormal;
			this.DelStudBtn.Location = new System.Drawing.Point(343, 383);
			this.DelStudBtn.Name = "DelStudBtn";
			this.DelStudBtn.Size = new System.Drawing.Size(347, 71);
			this.DelStudBtn.TabIndex = 9;
			this.DelStudBtn.TabStop = false;
			this.DelStudBtn.Click += new System.EventHandler(this.DelStudBtn_Click);
			this.DelStudBtn.MouseEnter += new System.EventHandler(this.DelStudBtn_MouseEnter);
			this.DelStudBtn.MouseLeave += new System.EventHandler(this.DelStudBtn_MouseLeave);
			// 
			// DeleteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
			this.ClientSize = new System.Drawing.Size(1077, 673);
			this.Controls.Add(this.DelStudBtn);
			this.Controls.Add(this.StudName);
			this.Controls.Add(this.StudSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.HomeBtn);
			this.Controls.Add(this.BackBtn);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DeleteForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DelStudBtn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox CloseBtn;
		private System.Windows.Forms.PictureBox BackBtn;
		private System.Windows.Forms.PictureBox HomeBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox StudSurname;
		private System.Windows.Forms.TextBox StudName;
		private System.Windows.Forms.PictureBox DelStudBtn;
	}
}