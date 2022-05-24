using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KnowledgeBase_MVC;
using KnowledgeBase_MVC.AppContext;

namespace KnowledgeBase_MVC.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppKnowledgeContext _context;

        public CompanyController(AppKnowledgeContext context)
        {
            _context = context;
        }

        public ActionResult Read()
        {
            var company  = _context.Company.ToList();
            return View(company);
        }

        
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Details(int id)
        {
            return View();
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Delete(int id)
        {
            var comp = _context.Company.SingleOrDefault(e=>e.Id == id);
            if (comp != null)
            {
                _context.Company.Remove(comp);
                _context.SaveChanges();
            }
            return View("Read",_context.Company.ToList());
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
