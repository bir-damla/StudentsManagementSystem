namespace Students
{
    partial class StudentLectureEdit
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
            btnLoad = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStudentId = new TextBox();
            txtLectureId = new TextBox();
            txtYear = new TextBox();
            txtSemester = new TextBox();
            txtFinalExam = new TextBox();
            txtMidtermExam = new TextBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(100, 414);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(328, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 55);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 100);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Lecture ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 149);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "Year :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 200);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Semester :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 252);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 6;
            label5.Text = "Midterm Exam :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 301);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 7;
            label6.Text = "Final Exam :";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(227, 52);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(232, 27);
            txtStudentId.TabIndex = 8;
            // 
            // txtLectureId
            // 
            txtLectureId.Location = new Point(227, 97);
            txtLectureId.Name = "txtLectureId";
            txtLectureId.Size = new Size(232, 27);
            txtLectureId.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(227, 146);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(232, 27);
            txtYear.TabIndex = 8;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(227, 193);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(232, 27);
            txtSemester.TabIndex = 8;
            // 
            // txtFinalExam
            // 
            txtFinalExam.Location = new Point(227, 294);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(232, 27);
            txtFinalExam.TabIndex = 8;
            // 
            // txtMidtermExam
            // 
            txtMidtermExam.Location = new Point(227, 245);
            txtMidtermExam.Name = "txtMidtermExam";
            txtMidtermExam.Size = new Size(232, 27);
            txtMidtermExam.TabIndex = 8;
            // 
            // StudentLectureEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 513);
            Controls.Add(txtMidtermExam);
            Controls.Add(txtFinalExam);
            Controls.Add(txtSemester);
            Controls.Add(txtYear);
            Controls.Add(txtLectureId);
            Controls.Add(txtStudentId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Name = "StudentLectureEdit";
            Text = "StudentLectureEdit";
            Load += StudentLectureEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtStudentId;
        private TextBox txtLectureId;
        private TextBox txtYear;
        private TextBox txtSemester;
        private TextBox txtFinalExam;
        private TextBox txtMidtermExam;
    }
}