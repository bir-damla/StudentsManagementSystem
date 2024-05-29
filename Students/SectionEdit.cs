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
    public partial class SectionEdit : Form
    {
        private readonly StudentsContext _context;
        private Section _section;

        public SectionEdit(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            int sectionId;
            if (int.TryParse(txtSectionId.Text, out sectionId))
            {
                _section = _context.Sections.FirstOrDefault(s => s.SectionId == sectionId);
                if (_section != null)
                {
                    txtSectionName.Text = _section.SectionName;
                    txtFacultyId.Text = _section.FacultyId.ToString();
                }
                else
                {
                    MessageBox.Show("Section is not defind.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Section ID");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_section != null)
            {
                _section.SectionName = txtSectionName.Text;
                int facultyId;
                if (int.TryParse(txtFacultyId.Text, out facultyId))
                {
                    _section.FacultyId = facultyId;
                    _context.SaveChanges();
                    MessageBox.Show("Section information has been successfully updated.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Faculty ID");
                }
            }
            else
            {
                MessageBox.Show("Section information could not be loaded.");
            }
        }
    }
}
