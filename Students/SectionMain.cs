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
    public partial class SectionMain : Form
    {
        private readonly StudentsContext _context;
        public  SectionMain(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void SectionMain_Load(object sender, EventArgs e)
        {
            LoadSection();
        }
        private void LoadSection()
        {
            dataGridViewSection.DataSource = _context.Sections.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadSection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SectionAdd sectionAdd = new SectionAdd(_context);
            sectionAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new SectionEdit(_context);
            editForm.ShowDialog();
            LoadSection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new SectionDelete(_context);
            deleteForm.ShowDialog();
            LoadSection();
        }
    }
}
