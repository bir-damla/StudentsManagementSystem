namespace Students
{
    partial class StudentLectureDelete
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
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            txtStudentId = new TextBox();
            txtLectureId = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(261, 238);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 57);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 106);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "Lecture ID :";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(183, 57);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(172, 27);
            txtStudentId.TabIndex = 3;
            // 
            // txtLectureId
            // 
            txtLectureId.Location = new Point(183, 106);
            txtLectureId.Name = "txtLectureId";
            txtLectureId.Size = new Size(172, 27);
            txtLectureId.TabIndex = 4;
            // 
            // StudentLectureDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 311);
            Controls.Add(txtLectureId);
            Controls.Add(txtStudentId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Name = "StudentLectureDelete";
            Text = "StudentLectureDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label label1;
        private Label label2;
        private TextBox txtStudentId;
        private TextBox txtLectureId;
    }
}