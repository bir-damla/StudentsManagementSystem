namespace Students
{
    partial class StudentEdit
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
            btnLoad = new Button();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSectionId = new TextBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(82, 319);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(260, 319);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 48);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 97);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 153);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Last Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 217);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 5;
            label4.Text = "Section ID :";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(206, 45);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(185, 27);
            txtStudentId.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(206, 97);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(206, 153);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtSectionId
            // 
            txtSectionId.Location = new Point(206, 210);
            txtSectionId.Name = "txtSectionId";
            txtSectionId.Size = new Size(185, 27);
            txtSectionId.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 402);
            Controls.Add(txtSectionId);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSectionId;
    }
}