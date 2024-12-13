using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Mvc.Controllers
{
    public class AdvertisementsController1 : Controller
    {
        // GET: AdvertisementsController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdvertisementsController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdvertisementsController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdvertisementsController1/Create
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

        // GET: AdvertisementsController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdvertisementsController1/Edit/5
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

        // GET: AdvertisementsController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdvertisementsController1/Delete/5
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
