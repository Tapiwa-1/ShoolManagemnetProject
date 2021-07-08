namespace SchoolProject
{
	partial class Form3
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.HomeBtn = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.closeBtn = new System.Windows.Forms.PictureBox();
			this.BackBtn = new System.Windows.Forms.PictureBox();
			this.Allstudbtn = new System.Windows.Forms.PictureBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.studentDetailsDataSet = new SchoolProject.studentDetailsDataSet();
			this.studentDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentDetailsDataSet1 = new SchoolProject.studentDetailsDataSet1();
			this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.table1TableAdapter = new SchoolProject.studentDetailsDataSet1TableAdapters.Table1TableAdapter();
			this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Allstudbtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(311, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(353, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "SHOWING ALL STUDENTS";
			// 
			// HomeBtn
			// 
			this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HomeBtn.Image = global::SchoolProject.Properties.Resources.homeNormal;
			this.HomeBtn.Location = new System.Drawing.Point(928, 0);
			this.HomeBtn.Name = "HomeBtn";
			this.HomeBtn.Size = new System.Drawing.Size(43, 42);
			this.HomeBtn.TabIndex = 5;
			this.HomeBtn.TabStop = false;
			this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
			this.HomeBtn.MouseEnter += new System.EventHandler(this.HomeBtn_MouseEnter);
			this.HomeBtn.MouseLeave += new System.EventHandler(this.HomeBtn_MouseLeave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::SchoolProject.Properties.Resources.HIT_logo;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(174, 81);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// closeBtn
			// 
			this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeBtn.Image = global::SchoolProject.Properties.Resources.CloseNormal;
			this.closeBtn.Location = new System.Drawing.Point(1024, 0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(36, 38);
			this.closeBtn.TabIndex = 1;
			this.closeBtn.TabStop = false;
			this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			this.closeBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
			this.closeBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
			// 
			// BackBtn
			// 
			this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BackBtn.Image = global::SchoolProject.Properties.Resources.BackNormal;
			this.BackBtn.Location = new System.Drawing.Point(977, 0);
			this.BackBtn.Name = "BackBtn";
			this.BackBtn.Size = new System.Drawing.Size(41, 42);
			this.BackBtn.TabIndex = 0;
			this.BackBtn.TabStop = false;
			this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
			this.BackBtn.MouseEnter += new System.EventHandler(this.BackBtn_MouseEnter);
			this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
			// 
			// Allstudbtn
			// 
			this.Allstudbtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Allstudbtn.Image = global::SchoolProject.Properties.Resources.AllstudNormal;
			this.Allstudbtn.Location = new System.Drawing.Point(402, 560);
			this.Allstudbtn.Name = "Allstudbtn";
			this.Allstudbtn.Size = new System.Drawing.Size(346, 70);
			this.Allstudbtn.TabIndex = 6;
			this.Allstudbtn.TabStop = false;
			this.Allstudbtn.Click += new System.EventHandler(this.Allstudbtn_Click);
			this.Allstudbtn.MouseEnter += new System.EventHandler(this.Allstudbtn_MouseEnter);
			this.Allstudbtn.MouseLeave += new System.EventHandler(this.Allstudbtn_MouseLeave);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentAgeDataGridViewTextBoxColumn,
            this.studentClassDataGridViewTextBoxColumn,
            this.studentGenderDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.table1BindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(203, 126);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(645, 349);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// studentDetailsDataSet
			// 
			this.studentDetailsDataSet.DataSetName = "studentDetailsDataSet";
			this.studentDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// studentDetailsDataSetBindingSource
			// 
			this.studentDetailsDataSetBindingSource.DataSource = this.studentDetailsDataSet;
			this.studentDetailsDataSetBindingSource.Position = 0;
			// 
			// studentDetailsDataSet1
			// 
			this.studentDetailsDataSet1.DataSetName = "studentDetailsDataSet1";
			this.studentDetailsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// table1BindingSource
			// 
			this.table1BindingSource.DataMember = "Table1";
			this.table1BindingSource.DataSource = this.studentDetailsDataSet1;
			// 
			// table1TableAdapter
			// 
			this.table1TableAdapter.ClearBeforeFill = true;
			// 
			// studentIdDataGridViewTextBoxColumn
			// 
			this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
			this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
			this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
			// 
			// studentNameDataGridViewTextBoxColumn
			// 
			this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
			this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
			this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
			// 
			// studentSurnameDataGridViewTextBoxColumn
			// 
			this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
			this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
			this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
			// 
			// studentAgeDataGridViewTextBoxColumn
			// 
			this.studentAgeDataGridViewTextBoxColumn.DataPropertyName = "StudentAge";
			this.studentAgeDataGridViewTextBoxColumn.HeaderText = "StudentAge";
			this.studentAgeDataGridViewTextBoxColumn.Name = "studentAgeDataGridViewTextBoxColumn";
			// 
			// studentClassDataGridViewTextBoxColumn
			// 
			this.studentClassDataGridViewTextBoxColumn.DataPropertyName = "StudentClass";
			this.studentClassDataGridViewTextBoxColumn.HeaderText = "StudentClass";
			this.studentClassDataGridViewTextBoxColumn.Name = "studentClassDataGridViewTextBoxColumn";
			// 
			// studentGenderDataGridViewTextBoxColumn
			// 
			this.studentGenderDataGridViewTextBoxColumn.DataPropertyName = "StudentGender";
			this.studentGenderDataGridViewTextBoxColumn.HeaderText = "StudentGender";
			this.studentGenderDataGridViewTextBoxColumn.Name = "studentGenderDataGridViewTextBoxColumn";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(163)))));
			this.ClientSize = new System.Drawing.Size(1061, 634);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Allstudbtn);
			this.Controls.Add(this.HomeBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.BackBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Allstudbtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentDetailsDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox BackBtn;
		private System.Windows.Forms.PictureBox closeBtn;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox HomeBtn;
		private System.Windows.Forms.PictureBox Allstudbtn;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource studentDetailsDataSetBindingSource;
		private studentDetailsDataSet studentDetailsDataSet;
		private studentDetailsDataSet1 studentDetailsDataSet1;
		private System.Windows.Forms.BindingSource table1BindingSource;
		private studentDetailsDataSet1TableAdapters.Table1TableAdapter table1TableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentAgeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentClassDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn studentGenderDataGridViewTextBoxColumn;
	}
}