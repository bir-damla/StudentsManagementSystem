namespace Students
{
    partial class FacultyAdd
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
            btnSave = new Button();
            label1 = new Label();
            dataGridViewAddFaculty = new DataGridView();
            txtFacultyName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddFaculty).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(274, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 58);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "Faculty Name : ";
            // 
            // dataGridViewAddFaculty
            // 
            dataGridViewAddFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddFaculty.Location = new Point(62, 124);
            dataGridViewAddFaculty.Name = "dataGridViewAddFaculty";
            dataGridViewAddFaculty.RowHeadersWidth = 51;
            dataGridViewAddFaculty.Size = new Size(306, 135);
            dataGridViewAddFaculty.TabIndex = 2;
            dataGridViewAddFaculty.CellContentClick += dataGridViewAddFaculty_CellContentClick;
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(166, 55);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(202, 27);
            txtFacultyName.TabIndex = 3;
            // 
            // FacultyAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 353);
            Controls.Add(txtFacultyName);
            Controls.Add(dataGridViewAddFaculty);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "FacultyAdd";
            Text = "FacultyAdd";
            Load += FacultyAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddFaculty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private DataGridView dataGridViewAddFaculty;
        private TextBox txtFacultyName;
    }
}