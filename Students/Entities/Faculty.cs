using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Entities
{
    public class Faculty
    {
        public Faculty() {
        Sections = new List<Section>();
        }
        public int FacultyId { get; set; }
        public string FacultyName { get; set; }
        public List<Section> Sections { get; set; }
    }
}
