using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Entities
{
    public class StudenttLecture
    {
        public int LectureId { get; set; }
        public int StudenttId { get; set; }
        public int Year { get; set; }
        public int Semesster { get; set; }
        public int MidtermExam {  get; set; }
        public int FinalExam { get; set; }
        public Studentt Studentt { get; set; }

    }
}
