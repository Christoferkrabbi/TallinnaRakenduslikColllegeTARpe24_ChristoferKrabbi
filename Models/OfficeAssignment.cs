using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int ID { get; set; }
        public Instructor Instructor{ get; set; }
    }
}
