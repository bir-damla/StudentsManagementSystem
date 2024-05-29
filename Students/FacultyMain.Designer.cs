namespace Students
{
    partial class FacultyMain
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
            dataGridViewFaculty = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculty).BeginInit();
            SuspendLayout();
            // 
            // btnList
            // 
            btnList.Location = new Point(24, 380);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 0;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(186, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(352, 380);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(518, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewFaculty
            // 
            dataGridViewFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFaculty.Location = new Point(0, -3);
            dataGridViewFaculty.Name = "dataGridViewFaculty";
            dataGridViewFaculty.RowHeadersWidth = 51;
            dataGridViewFaculty.Size = new Size(638, 348);
            dataGridViewFaculty.TabIndex = 4;
            // 
            // FacultyMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(dataGridViewFaculty);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Name = "FacultyMain";
            Text = "Faculty CRUD";
            Load += FacultyMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFaculty).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnList;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridViewFaculty;
    }
}