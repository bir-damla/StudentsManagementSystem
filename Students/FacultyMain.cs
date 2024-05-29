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
    public partial class FacultyMain : Form
    {
        private readonly StudentsContext _context;

        public FacultyMain(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void FacultyMain_Load(object sender, EventArgs e)
        {
            LoadFaculty();
        }
        private void LoadFaculty()
        {
            dataGridViewFaculty.DataSource = _context.Faculties.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadFaculty();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FacultyAdd facultyAdd = new FacultyAdd(_context);
            facultyAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new FacultyEdit(_context);
            editForm.ShowDialog();
            LoadFaculty();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new FacultyDelete(_context);
            deleteForm.ShowDialog();
            LoadFaculty();
        }
    }
}
