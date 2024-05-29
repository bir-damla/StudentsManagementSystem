using ConsoleApp1.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConsoleApp1.models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<StudentContext>(options =>
                    options.UseSqlServer("Server=MY_DAISY;Database=Students;Integrated Security=true;TrustServerCertificate=True\" providerName=\"System.Data.SqlClient"))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<StudentContext>())
            {
                context.Database.EnsureCreated();
                // Add initial data if needed
                InitializeData(context);
            }

            // Application menu and operations
            RunApp(serviceProvider);
        }

        static void InitializeData(StudentContext context)
        {
            // Initial data seeding if necessary
        }

        static void RunApp(ServiceProvider serviceProvider)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Manage Students");
                Console.WriteLine("2. Manage Lectures");
                Console.WriteLine("3. Manage Sections");
                Console.WriteLine("4. Assign/Unassign Student to/from Lecture");
                Console.WriteLine("5. List Student's Lectures");
                Console.WriteLine("6. List Students in a Lecture");
                Console.WriteLine("0. Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageStudents(serviceProvider);
                        break;
                    case "2":
                        ManageLectures(serviceProvider);
                        break;
                    case "3":
                        ManageSections(serviceProvider);
                        break;
                    //case "4":
                    //    AssignStudentToLecture(serviceProvider);
                    //    break;
                    //case "5":
                    //    ListStudentLectures(serviceProvider);
                    //    break;
                    //case "6":
                    //    ListLectureStudents(serviceProvider);
                    //    break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void ManageStudents(ServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetService<StudentContext>())
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. List Students");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(context);
                        break;
                    case "2":
                        UpdateStudent(context);
                        break;
                    case "3":
                        DeleteStudent(context);
                        break;
                    case "4":
                        ListStudents(context);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddStudent(StudentContext context)
        {
            Console.WriteLine("Enter First Name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter Section ID:");
            var sectionId = int.Parse(Console.ReadLine());

            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                SectionId = sectionId
            };

            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Student added successfully.");
        }

        static void UpdateStudent(StudentContext context)
        {
            Console.WriteLine("Enter Student ID to update:");
            var studentId = int.Parse(Console.ReadLine());
            var student = context.Students.Find(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.WriteLine("Enter new First Name:");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter new Last Name:");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Enter new Section ID:");
            student.SectionId = int.Parse(Console.ReadLine());

            context.SaveChanges();
            Console.WriteLine("Student updated successfully.");
        }

        static void DeleteStudent(StudentContext context)
        {
            Console.WriteLine("Enter Student ID to delete:");
            var studentId = int.Parse(Console.ReadLine());
            var student = context.Students.Find(studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            context.Students.Remove(student);
            context.SaveChanges();
            Console.WriteLine("Student deleted successfully.");
        }

        static void ListStudents(StudentContext context)
        {
            var students = context.Students.Include(s => s.Section).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentId}, Name: {student.FirstName} {student.LastName}, Section: {student.Section.SectionName}");
            }
        }

        static void ManageLectures(ServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetService<StudentContext>())
            {
                Console.WriteLine("1. Add Lecture");
                Console.WriteLine("2. Update Lecture");
                Console.WriteLine("3. Delete Lecture");
                Console.WriteLine("4. List Lecture");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddLecture(context);
                        break;
                    case "2":
                        UpdateLecture(context);
                        break;
                    case "3":
                        DeleteLecture(context);
                        break;
                    case "4":
                        ListLecture(context);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddLecture(StudentContext context)
        {
            Console.WriteLine("Enter Lecture Name:");
            var lectureName = Console.ReadLine();

            var lecture = new Lecture
            {
                LectureName = lectureName,
            };

            context.Lectures.Add(lecture);
            context.SaveChanges();
            Console.WriteLine("Lecture added successfully.");
        }

        static void UpdateLecture(StudentContext context)
        {
            Console.WriteLine("Enter Lecture ID to update:");
            var lectureId = int.Parse(Console.ReadLine());
            var lecture = context.Lectures.Find(lectureId);
            if (lecture == null)
            {
                Console.WriteLine("Lecture not found.");
                return;
            }

            Console.WriteLine("Enter new Lecture Name:");
            lecture.LectureName = Console.ReadLine();


            context.SaveChanges();
            Console.WriteLine("Lecture updated successfully.");
        }

        static void DeleteLecture(StudentContext context)
        {
            Console.WriteLine("Enter Lecture ID to delete:");
            var lectureId = int.Parse(Console.ReadLine());
            var lecture = context.Lectures.Find(lectureId);
            if (lecture == null)
            {
                Console.WriteLine("Lecture not found.");
                return;
            }

            context.Lectures.Remove(lecture);
            context.SaveChanges();
            Console.WriteLine("Lecture deleted successfully.");
        }

        static void ListLecture(StudentContext context)
        {
            var lectures = context.Lectures.ToList();
            foreach (var lecture in lectures)
            {
                Console.WriteLine($"ID: {lecture.LectureId}, Name: {lecture.LectureName}");
            }
        }

        static void ManageSections(ServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetService<StudentContext>())
            {
                Console.WriteLine("1. Add Section");
                Console.WriteLine("2. Update Section");
                Console.WriteLine("3. Delete Section");
                Console.WriteLine("4. List Section");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSection(context);
                        break;
                    case "2":
                        UpdateSection(context);
                        break;
                    case "3":
                        DeleteSection(context);
                        break;
                    case "4":
                        ListSection(context);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddSection(StudentContext context)
        {
            Console.WriteLine("Enter Section Name:");
            var sectionName = Console.ReadLine();
            Console.WriteLine("Enter Faculty ID:");
            var facultyId = int.Parse(Console.ReadLine());

            var section = new Section
            {
                SectionName = sectionName,
                FacultyId = facultyId
            };

            context.Sections.Add(section);
            context.SaveChanges();
            Console.WriteLine("Section added successfully.");
        }

        static void UpdateSection(StudentContext context)
        {
            Console.WriteLine("Enter Section ID to update:");
            var sectionId = int.Parse(Console.ReadLine());
            var section = context.Sections.Find(sectionId);
            if (section == null)
            {
                Console.WriteLine("Section not found.");
                return;
            }

            Console.WriteLine("Enter new Section Name:");
            section.SectionName = Console.ReadLine();
            Console.WriteLine("Enter new Faculty ID:");
            section.FacultyId = int.Parse(Console.ReadLine());


            context.SaveChanges();
            Console.WriteLine("Section updated successfully.");
        }

        static void DeleteSection(StudentContext context)
        {
            Console.WriteLine("Enter Section ID to delete:");
            var sectionId = int.Parse(Console.ReadLine());
            var section = context.Sections.Find(sectionId);
            if (section == null)
            {
                Console.WriteLine("Section not found.");
                return;
            }

            context.Sections.Remove(section);
            context.SaveChanges();
            Console.WriteLine("Section deleted successfully.");
        }

        static void ListSection(StudentContext context)
        {
            var sections = context.Sections.Include(s => s.Faculty).ToList();
            foreach (var section in sections)
            {
                Console.WriteLine($"ID: {section.SectionId}, Name: {section.SectionName}, Faculty: {section.Faculty.FacultyName}");
            }
        }

        static void ManageFaculties(ServiceProvider serviceProvider)
        {
            using (var context = serviceProvider.GetService<StudentContext>())
            {
                Console.WriteLine("1. Add Faculty");
                Console.WriteLine("2. Update Faculty");
                Console.WriteLine("3. Delete Faculty");
                Console.WriteLine("4. List Faculty");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddFaculty(context);
                        break;
                    case "2":
                        UpdateFaculty(context);
                        break;
                    case "3":
                        DeleteFaculty(context);
                        break;
                    case "4":
                        ListFaculty(context);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddFaculty(StudentContext context)
        {
            Console.WriteLine("Enter Faculty Name:");
            var facultyName = Console.ReadLine();

            var faculty = new Faculty
            {
                FacultyName = facultyName,
            };

            context.Faculties.Add(faculty);
            context.SaveChanges();
            Console.WriteLine("Faculty added successfully.");
        }

        static void UpdateFaculty(StudentContext context)
        {
            Console.WriteLine("Enter Faculty ID to update:");
            var facultyId = int.Parse(Console.ReadLine());
            var faculty = context.Faculties.Find(facultyId);
            if (faculty == null)
            {
                Console.WriteLine("Faculty not found.");
                return;
            }

            Console.WriteLine("Enter new Faculty Name:");
            faculty.FacultyName = Console.ReadLine();


            context.SaveChanges();
            Console.WriteLine("Faculty updated successfully.");
        }

        static void DeleteFaculty(StudentContext context)
        {
            Console.WriteLine("Enter Faculty ID to delete:");
            var facultyId = int.Parse(Console.ReadLine());
            var faculty = context.Faculties.Find(facultyId);
            if (faculty == null)
            {
                Console.WriteLine("Faculty not found.");
                return;
            }

            context.Faculties.Remove(faculty);
            context.SaveChanges();
            Console.WriteLine("Faculty deleted successfully.");
        }

        static void ListFaculty(StudentContext context)
        {
            var faculties = context.Faculties.ToList();
            foreach (var faculty in faculties)
            {
                Console.WriteLine($"ID: {faculty.FacultyId}, Name: {faculty.FacultyName}");
            }
        }
    }
}

        //static void AssignStudentToLecture(ServiceProvider serviceProvider)
        //{
        //    // Implement student assignment to lecture
        //}

        //static void ListStudentLectures(ServiceProvider serviceProvider)
        //{
        //    // Implement listing of student's lectures
        //}

        //static void ListLectureStudents(ServiceProvider serviceProvider)
        //{
        //    // Implement listing of students in a lecture
        //}
    



