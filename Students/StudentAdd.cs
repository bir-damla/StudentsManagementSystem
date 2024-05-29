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
    public partial class StudentAdd : Form
    {
        private readonly StudentsContext _context;
        public StudentAdd(StudentsContext context)
        {
            InitializeComponent();
            _context = context;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var students = _context.Studentts.ToList();

            dataGridView1.DataSource = students;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSectionId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newStudent = new Studentt
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                SectionId = int.Parse(txtSectionId.Text)
            };

            _context.Studentts.Add(newStudent);
            _context.SaveChanges();

            LoadData();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
