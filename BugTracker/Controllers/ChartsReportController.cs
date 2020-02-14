using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class ChartsReportController : Controller
    {
        // GET: ChartsReport
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChartsReport/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChartsReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChartsReport/Create
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

        // GET: ChartsReport/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChartsReport/Edit/5
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

        // GET: ChartsReport/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChartsReport/Delete/5
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