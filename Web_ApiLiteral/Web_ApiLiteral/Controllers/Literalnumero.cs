using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_ApiLiteral.Controllers
{
    public class Literalnumero : Controller
    {
        // GET: Literalnumero
        public ActionResult Index()
        {
            return View();
        }

        // GET: Literalnumero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Literalnumero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Literalnumero/Create
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

        // GET: Literalnumero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Literalnumero/Edit/5
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

        // GET: Literalnumero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Literalnumero/Delete/5
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
