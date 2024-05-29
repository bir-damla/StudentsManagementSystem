using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    public class StudentLecture
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
        public int MidtermExam { get; set; }
        public int FinalExam { get; set; }
    }
}
