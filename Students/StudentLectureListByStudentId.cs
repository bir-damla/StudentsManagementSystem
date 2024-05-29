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
    public partial class StudentLectureListByStudentId : Form
    {
        private readonly StudentsContext _context;
        public StudentLectureListByStudentId(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void StudentLectureListByStudentId_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int studentId;
            if (int.TryParse(txtStudentId.Text, out studentId))
            {
                var lectures = _context.StudenttLectures
                    .Where(sl => sl.StudenttId == studentId)
                    .Select(sl => new
                    {
                        sl.LectureId,
                        sl.Year,
                        sl.Semesster,
                        sl.MidtermExam,
                        sl.FinalExam
                    }).ToList();

                if (lectures.Any())
                {
                    dataGridViewLectures.DataSource = lectures;
                }
                else
                {
                    MessageBox.Show("No lecture found for this student.");
                    dataGridViewLectures.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID.");
            }
        }
    }
}
