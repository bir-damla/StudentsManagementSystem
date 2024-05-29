using Microsoft.EntityFrameworkCore;
using Students.Context;
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
    public partial class StudentDelete : Form
    {
        private readonly StudentsContext _context;

        public StudentDelete(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int studentId;
            if (int.TryParse(txtStudentId.Text, out studentId))
            {
                var student = _context.Studentts.FirstOrDefault(s => s.StudenttId == studentId);
                if (student != null)
                {
                    _context.Studentts.Remove(student);
                    _context.SaveChanges();
                    MessageBox.Show("Student deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Student is not defind.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
