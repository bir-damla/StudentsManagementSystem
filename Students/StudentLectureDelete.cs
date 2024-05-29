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
    public partial class StudentLectureDelete : Form
    {
        private readonly StudentsContext _context;
        public StudentLectureDelete(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                int studentId;
                int lectureId;

                if (int.TryParse(txtStudentId.Text, out studentId) && int.TryParse(txtLectureId.Text, out lectureId))
                {
                    var studentLecture = _context.StudenttLectures
                        .FirstOrDefault(sl => sl.StudenttId == studentId && sl.LectureId == lectureId);

                    if (studentLecture != null)
                    {
                        _context.StudenttLectures.Remove(studentLecture);
                        _context.SaveChanges();
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record is not defind.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Student ID and Lecture ID.");
                }
            }
        }
    }
}
