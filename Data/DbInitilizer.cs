using TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Models;

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Data
{

    public class DbInitilizer
    {
        public static void Initializer(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;
            }

            var Students = new Student[]
            {
                new Student
                {
                    FirstName = "Christofer",
                    LastName = "Krabbi",
                    EnrollmentDate = DateTime.Now,
                }
            };
        }
    }
}
