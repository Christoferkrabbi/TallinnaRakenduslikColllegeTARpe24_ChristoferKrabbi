using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Data;
using TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Models;

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Controllers
{
	public class CoursesController : Controller
	{
		private readonly SchoolContext _context;
		public CoursesController(SchoolContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var courses = _context.Courses.Include(c => c.Department)
				.AsNoTracking();
            return View(courses);
        }
		[HttpGet]
		public IActionResult Create()
		{
			PopulateDepartmentsDropdDownList();
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(Course course)
		{
			if (ModelState.IsValid)
			{
				_context.Add(course);
				await _context.SaveChangesAsync();
				PopulateDepartmentsDropDownList(course.DepartmentID);	
			}
			return RedirectToAction("Index");
		}
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.Courses == null)
			{
				return NotFound();
			}
			var course = await _context.Courses.FindAsync(id);
			if (course != null)
			{
				_context.Courses.Remove(course);
			}
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
			{
			}
		}


	}
}
