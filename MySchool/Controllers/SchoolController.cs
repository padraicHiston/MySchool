using System;
using MySchool.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using MySchool.ViewModels;

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

        public ActionResult AddSchool()
        {
            var counties = _context.Counties.ToList();
            var ethos = _context.Ethos.ToList();

            var viewModel = new SchoolFormViewModel()
            {
                Counties = counties,
                Ethos = ethos
            };

            return View("SchoolForm", viewModel);
        }

        public ActionResult SchoolProfile(int id)
        {
            var school = _context.Schools.SingleOrDefault(s => s.Id == id);

            if (school == null)
            {
                return HttpNotFound();
            }

            return View(school);
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
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new SchoolFormViewModel(school)
            //    {
            //        Counties = _context.Counties.ToList(),
            //        Ethos = _context.Ethos.ToList()
            //    };

            //    return View("SchoolForm", viewModel);
            //}
            if (school.Id == 0)
            {
                _context.Schools.Add(school);
            }
            else
            {
                var schoolInDb = _context.Schools.Single(m => m.Id == school.Id);
                schoolInDb.Name = school.Name;
                schoolInDb.Address = school.Address;
                schoolInDb.CountyId = school.CountyId;
                schoolInDb.RollNumber = school.RollNumber;
                schoolInDb.EthosId = school.EthosId;
                schoolInDb.PhoneNumber = school.PhoneNumber;
                schoolInDb.Email = school.Email;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "School");
        }
    }
}