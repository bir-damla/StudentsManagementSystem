﻿namespace Students
{
    partial class SectionAdd
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
            dataGridViewAddSection = new DataGridView();
            label1 = new Label();
            txtSectionName = new TextBox();
            txtFacultyId = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddSection).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(263, 275);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridViewAddSection
            // 
            dataGridViewAddSection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddSection.Location = new Point(59, 142);
            dataGridViewAddSection.Name = "dataGridViewAddSection";
            dataGridViewAddSection.RowHeadersWidth = 51;
            dataGridViewAddSection.Size = new Size(298, 109);
            dataGridViewAddSection.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Section Name :";
            // 
            // txtSectionName
            // 
            txtSectionName.Location = new Point(161, 40);
            txtSectionName.Name = "txtSectionName";
            txtSectionName.Size = new Size(196, 27);
            txtSectionName.TabIndex = 3;
            // 
            // txtFacultyId
            // 
            txtFacultyId.Location = new Point(161, 96);
            txtFacultyId.Name = "txtFacultyId";
            txtFacultyId.Size = new Size(196, 27);
            txtFacultyId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 96);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 5;
            label2.Text = "Faculty ID :";
            // 
            // SectionAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 335);
            Controls.Add(label2);
            Controls.Add(txtFacultyId);
            Controls.Add(txtSectionName);
            Controls.Add(label1);
            Controls.Add(dataGridViewAddSection);
            Controls.Add(btnSave);
            Name = "SectionAdd";
            Text = "SectionAdd";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddSection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private DataGridView dataGridViewAddSection;
        private Label label1;
        private TextBox txtSectionName;
        private TextBox txtFacultyId;
        private Label label2;
    }
}