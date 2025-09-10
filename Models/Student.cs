using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int? DaysSurvived { get; set; }
        public ICollection<Image>? Images { get; set; }
        public string? DeepBackstory { get; set; }
    }
}
