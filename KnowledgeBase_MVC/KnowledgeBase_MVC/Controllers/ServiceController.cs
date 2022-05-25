using KnowledgeBase_MVC.AppContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeBase_MVC.Controllers
{
    public class ServiceController : Controller
    {


        private readonly AppKnowledgeContext _context;

        public ServiceController(AppKnowledgeContext context)
        {
            _context = context;
        }

        public ActionResult Read()
        {
            var prod = _context.Service.ToList();
            return View(prod);
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
            var prod = _context.Service.SingleOrDefault(e => e.Id == id);
            if (prod != null)
            {
                _context.Service.Remove(prod);
                _context.SaveChanges();
            }
            return View("Read", _context.Service.ToList());
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
