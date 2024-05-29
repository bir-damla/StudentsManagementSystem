using Microsoft.EntityFrameworkCore;
using Students.Context;
using Students.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class StudentEdit : Form
    {
        private readonly StudentsContext _context;
        private Studentt _student;

        public StudentEdit(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            int studentId;
            if (int.TryParse(txtStudentId.Text, out studentId))
            {
                _student = _context.Studentts.FirstOrDefault(s => s.StudenttId == studentId);
                if (_student != null)
                {
                    txtFirstName.Text = _student.FirstName;
                    txtLastName.Text = _student.LastName;
                    txtSectionId.Text = _student.SectionId.ToString();
                }
                else
                {
                    MessageBox.Show("Student is not defind.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                _student.FirstName = txtFirstName.Text;
                _student.LastName = txtLastName.Text;
                int sectionId;
                if (int.TryParse(txtSectionId.Text, out sectionId))
                {
                    _student.SectionId = sectionId;
                    _context.SaveChanges();
                    MessageBox.Show("Student information has been successfully updated.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Section ID");
                }
            }
            else
            {
                MessageBox.Show("Student information could not be loaded.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
