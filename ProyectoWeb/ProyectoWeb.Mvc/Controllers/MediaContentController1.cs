﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Mvc.Controllers
{
    public class MediaContentController1 : Controller
    {
        // GET: MediaContentController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: MediaContentController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaContentController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaContentController1/Create
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

        // GET: MediaContentController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaContentController1/Edit/5
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

        // GET: MediaContentController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaContentController1/Delete/5
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