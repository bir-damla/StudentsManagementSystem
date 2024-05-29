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
    public partial class SectionAdd : Form
    {
        private readonly StudentsContext _context;
        public SectionAdd(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void SectionAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var sections = _context.Sections.ToList();

            dataGridViewAddSection.DataSource = sections;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var newSection = new Section
            {
                SectionName = txtSectionName.Text,
                FacultyId = int.Parse(txtFacultyId.Text)
            };

            _context.Sections.Add(newSection);
            _context.SaveChanges();

            LoadData();
        }
    }
}
