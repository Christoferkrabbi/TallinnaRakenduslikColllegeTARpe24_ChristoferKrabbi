using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Data;
using TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Models;

namespace TallinnaRakenduslikColllegeTARpe24_ChristoferKrabbi.Controllers
{
    public class StudentControllee : Controller
    {
        public class StudentController : Controller
        {
            private readonly SchoolContext _context;
            public StudentController(SchoolContext context)
            {
                _context = context;
            }
            public async Task<IActionResult> Index()
            {
                return View(await _context.Students.ToListAsync());
            }
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("ID,LastName,FirstName,EnrollmentDate,Gender")] Student student)
            {
                if (ModelState.IsValid)
                {
                    _context.Students.Add(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                    //return RedirectToAction(nameof(Index));
                }
                return View(student);
            }
            [HttpGet]
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
                if (student == null)
                {
                    return NotFound();
                }
                return View(student);
            }
            [HttpPost, ActionName ("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var student = await _context.Students.FindAsync(id);
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
