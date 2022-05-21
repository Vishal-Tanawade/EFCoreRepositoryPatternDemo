using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRepositoryPatternDemo.Controllers
{
    public class ExperiencePortalController : Controller
    {
        // GET: ExperiencePortalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExperiencePortalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExperiencePortalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExperiencePortalController/Create
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

        // GET: ExperiencePortalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExperiencePortalController/Edit/5
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

        // GET: ExperiencePortalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExperiencePortalController/Delete/5
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
