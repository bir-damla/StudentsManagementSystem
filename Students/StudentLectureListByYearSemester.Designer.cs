namespace Students
{
    partial class StudentLectureListByYearSemester
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
            btnList = new Button();
            label1 = new Label();
            label2 = new Label();
            txtYear = new TextBox();
            txtSemester = new TextBox();
            dataGridViewLecturess = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecturess).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(306, 394);
            btnList.Name = "btnList";
            btnList.Size = new Size(81, 27);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 98);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "Year :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 177);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Semester :";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(191, 95);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(196, 27);
            txtYear.TabIndex = 3;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(191, 174);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(196, 27);
            txtSemester.TabIndex = 4;
            // 
            // dataGridViewLecturess
            // 
            dataGridViewLecturess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLecturess.Location = new Point(89, 241);
            dataGridViewLecturess.Name = "dataGridViewLecturess";
            dataGridViewLecturess.RowHeadersWidth = 51;
            dataGridViewLecturess.Size = new Size(298, 116);
            dataGridViewLecturess.TabIndex = 5;
            // 
            // StudentLectureListByYearSemester
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(dataGridViewLecturess);
            Controls.Add(txtSemester);
            Controls.Add(txtYear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnList);
            Name = "StudentLectureListByYearSemester";
            Text = "StudentLectureListByYearSemester";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecturess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnList;
        private Label label1;
        private Label label2;
        private TextBox txtYear;
        private TextBox txtSemester;
        private DataGridView dataGridViewLecturess;
    }
}