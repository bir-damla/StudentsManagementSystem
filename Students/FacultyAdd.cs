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
    public partial class FacultyAdd : Form
    {
        private readonly StudentsContext _context;
        public FacultyAdd(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void FacultyAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var faculties = _context.Faculties.ToList();

            dataGridViewAddFaculty.DataSource = faculties;
        }

        private void dataGridViewAddFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newFaculty = new Faculty
            {
                FacultyName = txtFacultyName.Text,
            };

            _context.Faculties.Add(newFaculty);
            _context.SaveChanges();

            LoadData();
        }
    }
}
