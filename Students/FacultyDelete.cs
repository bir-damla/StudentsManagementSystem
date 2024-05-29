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
    public partial class FacultyDelete : Form
    {
        private readonly StudentsContext _context;
        public FacultyDelete(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int facultyId;
            if (int.TryParse(txtFacultyId.Text, out facultyId))
            {
                var faculty = _context.Faculties.FirstOrDefault(s => s.FacultyId == facultyId);
                if (faculty != null)
                {
                    _context.Faculties.Remove(faculty);
                    _context.SaveChanges();
                    MessageBox.Show("Faculty deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Faculty is not defind.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Faculty ID.");
            }
        }
    }
}
