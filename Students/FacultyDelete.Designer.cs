namespace Students
{
    partial class FacultyDelete
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
            txtFacultyId = new TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(299, 178);
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
            label1.Location = new Point(106, 84);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Faculty ID : ";
            // 
            // txtFacultyId
            // 
            txtFacultyId.Location = new Point(220, 77);
            txtFacultyId.Name = "txtFacultyId";
            txtFacultyId.Size = new Size(173, 27);
            txtFacultyId.TabIndex = 2;
            // 
            // FacultyDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 246);
            Controls.Add(txtFacultyId);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Name = "FacultyDelete";
            Text = "FacultyDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Label label1;
        private TextBox txtFacultyId;
    }
}