using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Models
{
	public class OfficeAssignment
	{
		[Key]
		public int InstructorID { get; set; }
		public Instructor? Instructor { get; set; }

		[StringLength(50)]
		[Display(Name = "Office Location")]
		public string Location { get; set; }
	}
}
