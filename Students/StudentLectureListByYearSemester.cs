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
    public partial class StudentLectureListByYearSemester : Form
    {
        private readonly StudentsContext _context;
        public StudentLectureListByYearSemester(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int year, semester;
            if (int.TryParse(txtYear.Text, out year) && int.TryParse(txtSemester.Text, out semester))
            {
                var lectureCounts = _context.StudenttLectures
                    .Where(sl => sl.Year == year && sl.Semesster == semester)
                    .GroupBy(sl => sl.LectureId)
                    .Select(g => new
                    {
                        LectureId = g.Key,
                        StudentCount = g.Count()
                    }).ToList();

                if (lectureCounts.Any())
                {
                    dataGridViewLecturess.DataSource = lectureCounts;
                }
                else
                {
                    MessageBox.Show("No courses found for this year and semester.");
                    dataGridViewLecturess.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid year and semester.");
            }
        }
    }
}
