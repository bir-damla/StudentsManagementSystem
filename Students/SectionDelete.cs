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
    public partial class SectionDelete : Form
    {
        private readonly StudentsContext _context;
        public SectionDelete(StudentsContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int sectionId;
            if (int.TryParse(txtSectionId.Text, out sectionId))
            {
                var section = _context.Sections.FirstOrDefault(s => s.SectionId == sectionId);
                if (section != null)
                {
                    _context.Sections.Remove(section);
                    _context.SaveChanges();
                    MessageBox.Show("Section deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Section is not defind.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Faculty ID.");
            }
        }
    }
}
