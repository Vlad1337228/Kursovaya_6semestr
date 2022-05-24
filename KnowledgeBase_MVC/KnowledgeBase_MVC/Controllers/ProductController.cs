using KnowledgeBase_MVC.AppContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KnowledgeBase_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppKnowledgeContext _context;

        public ProductController(AppKnowledgeContext context)
        {
            _context = context;
        }

        public ActionResult Read()
        {
            var prod = _context.Product.ToList();
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
            var prod = _context.Product.SingleOrDefault(e => e.Id == id);
            if (prod != null)
            {
                _context.Product.Remove(prod);
                _context.SaveChanges();
            }
            return View("Read", _context.Product.ToList());
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
