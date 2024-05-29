namespace Students
{
    partial class StudentLectureListByStudentId
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
            dataGridViewLectures = new DataGridView();
            label1 = new Label();
            txtStudentId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLectures).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(327, 374);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dataGridViewLectures
            // 
            dataGridViewLectures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLectures.Location = new Point(91, 151);
            dataGridViewLectures.Name = "dataGridViewLectures";
            dataGridViewLectures.RowHeadersWidth = 51;
            dataGridViewLectures.Size = new Size(330, 188);
            dataGridViewLectures.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 63);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID : ";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(201, 60);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(220, 27);
            txtStudentId.TabIndex = 3;
            // 
            // StudentLectureListByStudentId
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 433);
            Controls.Add(txtStudentId);
            Controls.Add(label1);
            Controls.Add(dataGridViewLectures);
            Controls.Add(btnList);
            Name = "StudentLectureListByStudentId";
            Text = "StudentLectureListByStudentId";
            Load += StudentLectureListByStudentId_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLectures).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnList;
        private DataGridView dataGridViewLectures;
        private Label label1;
        private TextBox txtStudentId;
    }
}