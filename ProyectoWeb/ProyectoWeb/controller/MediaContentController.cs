using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Api.controller
{
    public class MediaContentController : Controller
    {
        // GET: MediaContentController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MediaContentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaContentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaContentController/Create
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

        // GET: MediaContentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaContentController/Edit/5
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

        // GET: MediaContentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaContentController/Delete/5
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
