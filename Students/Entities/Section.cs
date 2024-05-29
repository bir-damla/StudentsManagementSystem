using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Entities
{
    public class Section
    {
        public Section() {
            Studentts = new List<Studentt>();
        }
        public int SectionId { get; set; }
        public int FacultyId { get; set; }
        public string SectionName { get; set; }
        public Faculty Faculty { get; set; }
        public List<Studentt> Studentts { get; set;}
    }
}
