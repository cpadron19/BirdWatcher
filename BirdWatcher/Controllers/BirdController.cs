using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdWatcher.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdWatcher.Controllers
{
    public class BirdController : Controller
    {
        // GET: Bird
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bird/Details/5
        public ActionResult Details(int id)
        {
			Bird TestBird = new Bird();

			TestBird.Name = "BigBird";
	
   
			return View(TestBird);
        }

        // GET: Bird/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bird/Create
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

        // GET: Bird/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bird/Edit/5
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

        // GET: Bird/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bird/Delete/5
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