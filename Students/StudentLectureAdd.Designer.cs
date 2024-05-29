namespace Students
{
    partial class StudentLectureAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStudentId = new TextBox();
            txtSemester = new TextBox();
            txtMidtermExam = new TextBox();
            txtFinalExam = new TextBox();
            txtLectureId = new TextBox();
            txtYear = new TextBox();
            dataGridViewAddLecture = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddLecture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Year :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 116);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Semester :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(484, 34);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 1;
            label4.Text = "Lecture ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 72);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 1;
            label5.Text = "MidtermExam :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 116);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 1;
            label6.Text = "FinalExam :";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(157, 27);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(269, 27);
            txtStudentId.TabIndex = 2;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(157, 113);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(269, 27);
            txtSemester.TabIndex = 2;
            // 
            // txtMidtermExam
            // 
            txtMidtermExam.Location = new Point(599, 72);
            txtMidtermExam.Name = "txtMidtermExam";
            txtMidtermExam.Size = new Size(269, 27);
            txtMidtermExam.TabIndex = 2;
            txtMidtermExam.TextChanged += textBox3_TextChanged;
            // 
            // txtFinalExam
            // 
            txtFinalExam.Location = new Point(599, 113);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(269, 27);
            txtFinalExam.TabIndex = 2;
            // 
            // txtLectureId
            // 
            txtLectureId.Location = new Point(599, 27);
            txtLectureId.Name = "txtLectureId";
            txtLectureId.Size = new Size(269, 27);
            txtLectureId.TabIndex = 2;
            txtLectureId.TextChanged += textBox3_TextChanged;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(157, 72);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(269, 27);
            txtYear.TabIndex = 2;
            // 
            // dataGridViewAddLecture
            // 
            dataGridViewAddLecture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddLecture.Location = new Point(50, 182);
            dataGridViewAddLecture.Name = "dataGridViewAddLecture";
            dataGridViewAddLecture.RowHeadersWidth = 51;
            dataGridViewAddLecture.Size = new Size(818, 155);
            dataGridViewAddLecture.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(774, 420);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // StudentLectureAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 481);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewAddLecture);
            Controls.Add(txtFinalExam);
            Controls.Add(txtLectureId);
            Controls.Add(txtMidtermExam);
            Controls.Add(txtSemester);
            Controls.Add(txtYear);
            Controls.Add(txtStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentLectureAdd";
            Text = "StudentLectureAdd";
            Load += StudentLectureAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddLecture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStudentId;
        private TextBox txtSemester;
        private TextBox txtMidtermExam;
        private TextBox txtFinalExam;
        private TextBox txtLectureId;
        private TextBox txtYear;
        private DataGridView dataGridViewAddLecture;
        private Button btnSave;
    }
}