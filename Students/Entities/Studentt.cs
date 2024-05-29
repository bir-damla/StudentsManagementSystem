using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Entities
{
    public class Studentt
    {
        public Studentt()
        { 
            StudenttLectures = new List<StudenttLecture>(); 
        }
        public int StudenttId { get; set; }
        public int SectionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Section Section { get; set; }
        public List<StudenttLecture> StudenttLectures { get; set; }

    }
}
