namespace Students
{
    partial class SectionMain
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
            dataGridViewSection = new DataGridView();
            btnList = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSection).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSection
            // 
            dataGridViewSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSection.Location = new Point(2, 0);
            dataGridViewSection.Name = "dataGridViewSection";
            dataGridViewSection.RowHeadersWidth = 51;
            dataGridViewSection.Size = new Size(611, 308);
            dataGridViewSection.TabIndex = 0;
            // 
            // btnList
            // 
            btnList.Location = new Point(50, 369);
            btnList.Name = "btnList";
            btnList.Size = new Size(86, 36);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(182, 369);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 36);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(308, 369);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(446, 369);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // SectionMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnList);
            Controls.Add(dataGridViewSection);
            Name = "SectionMain";
            Text = "SectionMain";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSection).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewSection;
        private Button btnList;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}