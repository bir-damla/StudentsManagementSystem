namespace Students
{
    partial class FacultyEdit
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
            label1 = new Label();
            label2 = new Label();
            txtFacultyId = new TextBox();
            txtFacultyName = new TextBox();
            btnLoad = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 80);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Faculty ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 147);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Faculty Name :";
            // 
            // txtFacultyId
            // 
            txtFacultyId.Location = new Point(225, 77);
            txtFacultyId.Name = "txtFacultyId";
            txtFacultyId.Size = new Size(163, 27);
            txtFacultyId.TabIndex = 2;
            // 
            // txtFacultyName
            // 
            txtFacultyName.Location = new Point(225, 144);
            txtFacultyName.Name = "txtFacultyName";
            txtFacultyName.Size = new Size(163, 27);
            txtFacultyName.TabIndex = 3;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(104, 273);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(294, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FacultyEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 357);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(txtFacultyName);
            Controls.Add(txtFacultyId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FacultyEdit";
            Text = "FacultyEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFacultyId;
        private TextBox txtFacultyName;
        private Button btnLoad;
        private Button btnSave;
    }
}