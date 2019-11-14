using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdWatcher.Controllers
{
    public class SpottedController : Controller
    {
        // GET: Spotted
        public ActionResult Index()
        {
            return View();
        }

        // GET: Spotted/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Spotted/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Spotted/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Spotted/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Spotted/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Spotted/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Spotted/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}