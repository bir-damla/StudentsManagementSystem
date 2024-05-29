using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Students.Context;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Students
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<StudentsContext>(options =>
                    options.UseSqlServer(ConfigurationManager.ConnectionStrings["StudentsDatabase"].ConnectionString))
                .BuildServiceProvider();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var context = serviceProvider.GetService<StudentsContext>();

            // Uncomment the form you want to run
            // System.Windows.Forms.Application.Run(new StudentMain(context));
            // System.Windows.Forms.Application.Run(new FacultyMain(context));
            // System.Windows.Forms.Application.Run(new SectionMain(context));
            //System.Windows.Forms.Application.Run(new StudentLectureMain(context));
            System.Windows.Forms.Application.Run(new MainForm(context));
        }
    }
}
