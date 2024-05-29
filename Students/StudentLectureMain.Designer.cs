namespace Students
{
    partial class StudentLectureMain
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridViewLecture = new DataGridView();
            btnListByStudentId = new Button();
            btnListByYearSemester = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecture).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(71, 368);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(244, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(414, 368);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(586, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewLecture
            // 
            dataGridViewLecture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLecture.Location = new Point(1, 1);
            dataGridViewLecture.Name = "dataGridViewLecture";
            dataGridViewLecture.RowHeadersWidth = 51;
            dataGridViewLecture.Size = new Size(799, 338);
            dataGridViewLecture.TabIndex = 4;
            // 
            // btnListByStudentId
            // 
            btnListByStudentId.Location = new Point(159, 409);
            btnListByStudentId.Name = "btnListByStudentId";
            btnListByStudentId.Size = new Size(94, 29);
            btnListByStudentId.TabIndex = 5;
            btnListByStudentId.Text = "Student ID";
            btnListByStudentId.UseVisualStyleBackColor = true;
            btnListByStudentId.Click += btnListByStudentId_Click;
            // 
            // btnListByYearSemester
            // 
            btnListByYearSemester.Location = new Point(478, 409);
            btnListByYearSemester.Name = "btnListByYearSemester";
            btnListByYearSemester.Size = new Size(129, 29);
            btnListByYearSemester.TabIndex = 6;
            btnListByYearSemester.Text = "Year Semester";
            btnListByYearSemester.UseVisualStyleBackColor = true;
            btnListByYearSemester.Click += btnListByYearSemester_Click;
            // 
            // StudentLectureMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListByYearSemester);
            Controls.Add(btnListByStudentId);
            Controls.Add(dataGridViewLecture);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Name = "StudentLectureMain";
            Text = "StudentLectureMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnList;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridViewLecture;
        private Button btnListByStudentId;
        private Button btnListByYearSemester;
    }
}