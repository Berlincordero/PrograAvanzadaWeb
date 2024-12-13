using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Mvc.Controllers
{
    public class WeatherController1 : Controller
    {
        // GET: WeatherController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: WeatherController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WeatherController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherController1/Create
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

        // GET: WeatherController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WeatherController1/Edit/5
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

        // GET: WeatherController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WeatherController1/Delete/5
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
