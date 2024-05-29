using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public partial class StudentLectureEdit : Form
    {
        private readonly StudentsContext _context;
        private StudenttLecture _studentLecture;
        public StudentLectureEdit(StudentsContext context)
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
            int lectureId, studenttId;
            if (int.TryParse(txtLectureId.Text, out lectureId) && int.TryParse(txtStudentId.Text, out studenttId))
            {
                _studentLecture = _context.StudenttLectures.FirstOrDefault(sl => sl.LectureId == lectureId && sl.StudenttId == studenttId);
                if (_studentLecture != null)
                {
                    txtYear.Text = _studentLecture.Year.ToString();
                    txtSemester.Text = _studentLecture.Semesster.ToString();
                    txtMidtermExam.Text = _studentLecture.MidtermExam.ToString();
                    txtFinalExam.Text = _studentLecture.FinalExam.ToString();
                }
                else
                {
                    MessageBox.Show("No Records Found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Lecture ID and Student ID.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_studentLecture == null)
            {
                _studentLecture = new StudenttLecture();
                _context.StudenttLectures.Add(_studentLecture);
            }

            _studentLecture.LectureId = int.Parse(txtLectureId.Text);
            _studentLecture.StudenttId = int.Parse(txtStudentId.Text);
            _studentLecture.Year = int.Parse(txtYear.Text);
            _studentLecture.Semesster = int.Parse(txtSemester.Text);
            _studentLecture.MidtermExam = int.Parse(txtMidtermExam.Text);
            _studentLecture.FinalExam = int.Parse(txtFinalExam.Text);

            _context.SaveChanges();
            MessageBox.Show("Record saved successfully.");
        }

        private void StudentLectureEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
