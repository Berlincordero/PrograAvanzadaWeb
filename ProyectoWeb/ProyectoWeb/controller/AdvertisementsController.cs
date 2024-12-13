using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Api.controller
{
    public class AdvertisementsController : Controller
    {
        // GET: AdvertisementsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdvertisementsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdvertisementsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdvertisementsController/Create
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

        // GET: AdvertisementsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdvertisementsController/Edit/5
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

        // GET: AdvertisementsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdvertisementsController/Delete/5
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
