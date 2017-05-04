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
    }
}