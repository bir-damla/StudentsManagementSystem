namespace Students
{
    partial class MainForm
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
            btnStudent = new Button();
            btnSection = new Button();
            btnFaculty = new Button();
            btnStudentLecture = new Button();
            SuspendLayout();
            // 
            // btnStudent
            // 
            btnStudent.Location = new Point(61, 62);
            btnStudent.Margin = new Padding(3, 4, 3, 4);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(172, 110);
            btnStudent.TabIndex = 0;
            btnStudent.Text = "Öğrenci Sistemi Girişi";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnSection
            // 
            btnSection.Location = new Point(336, 62);
            btnSection.Margin = new Padding(3, 4, 3, 4);
            btnSection.Name = "btnSection";
            btnSection.Size = new Size(186, 110);
            btnSection.TabIndex = 1;
            btnSection.Text = "Bölüm Sistemi Girişi";
            btnSection.UseVisualStyleBackColor = true;
            btnSection.Click += btnSection_Click;
            // 
            // btnFaculty
            // 
            btnFaculty.Location = new Point(61, 296);
            btnFaculty.Margin = new Padding(3, 4, 3, 4);
            btnFaculty.Name = "btnFaculty";
            btnFaculty.Size = new Size(172, 105);
            btnFaculty.TabIndex = 2;
            btnFaculty.Text = "Fakülte Sistemi Girişi";
            btnFaculty.UseVisualStyleBackColor = true;
            btnFaculty.Click += btnFaculty_Click;
            // 
            // btnStudentLecture
            // 
            btnStudentLecture.Location = new Point(336, 296);
            btnStudentLecture.Margin = new Padding(3, 4, 3, 4);
            btnStudentLecture.Name = "btnStudentLecture";
            btnStudentLecture.Size = new Size(186, 105);
            btnStudentLecture.TabIndex = 3;
            btnStudentLecture.Text = "Öğrenci-Ders Sistemi Girişi";
            btnStudentLecture.UseVisualStyleBackColor = true;
            btnStudentLecture.Click += btnStudentLecture_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 485);
            Controls.Add(btnStudentLecture);
            Controls.Add(btnFaculty);
            Controls.Add(btnSection);
            Controls.Add(btnStudent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnStudentLecture;
    }
}
