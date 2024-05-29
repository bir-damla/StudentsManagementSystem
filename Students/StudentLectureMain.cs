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
    public partial class StudentLectureMain : Form
    {
        private readonly StudentsContext _context;
        public StudentLectureMain(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }
        private void LoadLectures()
        {
            dataGridViewLecture.DataSource = _context.StudenttLectures.ToList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new StudentLectureDelete(_context);
            deleteForm.ShowDialog();
            LoadLectures();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            LoadLectures();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentLectureAdd studentLectureAdd = new StudentLectureAdd(_context);
            studentLectureAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new StudentLectureEdit(_context);
            editForm.ShowDialog();
            LoadLectures();
        }

        private void btnListByStudentId_Click(object sender, EventArgs e)
        {
            var listByStudentIdForm = new StudentLectureListByStudentId(_context);
            listByStudentIdForm.ShowDialog();
        }

        private void btnListByYearSemester_Click(object sender, EventArgs e)
        {
            var listByYearSemesterForm = new StudentLectureListByYearSemester(_context);
            listByYearSemesterForm.ShowDialog();
        }
    }
}
