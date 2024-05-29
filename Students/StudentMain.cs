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
    public partial class StudentMain : Form
    {
        private readonly StudentsContext _context;

        public StudentMain(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }
        private void studentCRUDForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridViewStudent.DataSource = _context.Studentts.ToList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new StudentDelete(_context);
            deleteForm.ShowDialog();
            LoadStudents();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new StudentEdit(_context);
            editForm.ShowDialog();
            LoadStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd form2 = new StudentAdd(_context);
            form2.Show();

        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
