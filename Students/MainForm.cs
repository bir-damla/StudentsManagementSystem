using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Students.Context;
using Students.Entities;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Students
{
    public partial class MainForm : Form
    {
        private readonly StudentsContext _context;

        public MainForm(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentMain studentMain = new StudentMain(_context);
            studentMain.Show();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            SectionMain sectionMain = new SectionMain(_context);
            sectionMain.Show();
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            FacultyMain facultyMain = new FacultyMain(_context);
            facultyMain.Show();
        }

        private void btnStudentLecture_Click(object sender, EventArgs e)
        {
            StudentLectureMain studentLectureMain = new StudentLectureMain(_context);
            studentLectureMain.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
