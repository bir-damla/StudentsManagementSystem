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
    public partial class FacultyEdit : Form
    {
        private readonly StudentsContext _context;
        private Faculty _faculty;

        public FacultyEdit(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            int facultyId;
            if (int.TryParse(txtFacultyId.Text, out facultyId))
            {
                _faculty = _context.Faculties.FirstOrDefault(s => s.FacultyId == facultyId);
                if (_faculty != null)
                {
                    txtFacultyName.Text = _faculty.FacultyName;
                }
                else
                {
                    MessageBox.Show("Faculty is not defind.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Faculty ID");
            }
        }
    }
}
