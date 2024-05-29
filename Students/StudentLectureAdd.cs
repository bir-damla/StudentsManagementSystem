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
    public partial class StudentLectureAdd : Form
    {
        private readonly StudentsContext _context;
        private StudenttLecture _studentLecture;
        public StudentLectureAdd(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _studentLecture = new StudenttLecture
            {
                LectureId = int.Parse(txtLectureId.Text),
                StudenttId = int.Parse(txtStudentId.Text),
                Year = int.Parse(txtYear.Text),
                Semesster = int.Parse(txtSemester.Text),
                MidtermExam = int.Parse(txtMidtermExam.Text),
                FinalExam = int.Parse(txtFinalExam.Text)
            };

            _context.StudenttLectures.Add(_studentLecture);
            _context.SaveChanges();

            MessageBox.Show("New record added successfully.");
        }

        private void StudentLectureAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
