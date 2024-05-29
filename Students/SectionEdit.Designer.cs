namespace Students
{
    partial class SectionEdit
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
            btnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSectionId = new TextBox();
            txtFacultyId = new TextBox();
            txtSectionName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(278, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(106, 319);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 79);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Section ID :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 130);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "Section Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 186);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Faculty ID :";
            // 
            // txtSectionId
            // 
            txtSectionId.Location = new Point(173, 76);
            txtSectionId.Name = "txtSectionId";
            txtSectionId.Size = new Size(251, 27);
            txtSectionId.TabIndex = 3;
            // 
            // txtFacultyId
            // 
            txtFacultyId.Location = new Point(173, 183);
            txtFacultyId.Name = "txtFacultyId";
            txtFacultyId.Size = new Size(251, 27);
            txtFacultyId.TabIndex = 3;
            // 
            // txtSectionName
            // 
            txtSectionName.Location = new Point(173, 130);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(251, 27);
            txtSectionName.TabIndex = 3;
            // 
            // SectionEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 406);
            Controls.Add(txtSectionName);
            Controls.Add(txtFacultyId);
            Controls.Add(txtSectionId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Name = "SectionEdit";
            Text = "SectionEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnLoad;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSectionId;
        private TextBox txtFacultyId;
        private TextBox txtSectionName;
    }
}