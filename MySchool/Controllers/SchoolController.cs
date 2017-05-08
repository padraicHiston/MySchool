using MySchool.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MySchool.Controllers
{
    public class SchoolController : Controller
    {
        private ApplicationDbContext _context;

        public SchoolController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: School
        public ActionResult Index()
        {
            var schools = _context.Schools.Include(s => s.County).ToList();

            return View(schools);
        }

        public ActionResult EditSchool(int id)
        {
            var school = _context.Schools.SingleOrDefault(s => s.Id == id);

            if (school == null)
            {
                return HttpNotFound();
            }


            return View(school);
        }

        public ActionResult Save(School school)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("EditSchool", "School");
            }

            return RedirectToAction("Index", "School");
        }
    }
}