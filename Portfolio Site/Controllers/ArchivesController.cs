using Portfolio_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Site.Controllers
{
    public class ArchivesController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from ex in _examples
                orderby ex.Year descending
                select ex;

            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            var example = _examples.Single(ex => ex.Id == id);

            return View(example);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var example = _examples.Single(ex => ex.Id == id);
            if (TryUpdateModel(example))
            {
                // save to db, once db is created
                return RedirectToAction("Index");
            }
            return View(example);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        static List<BicycleArchive> _examples = new List<BicycleArchive>
        {
            new BicycleArchive
            {
                Id = 1,
                Model = "Sirrus",
                Manufacturer = "Specialized",
                Year = 1991,
                Rating = 6,
                Info = "Suntour Edge group, 7-speed."
            },
            new BicycleArchive
            {
                Id = 2,
                Model = "912",
                Manufacturer = "Miyata",
                Year = 1981,
                Rating = 8,
                Info = "Shimano 600 Arabesque group, 6-speed."
            },
            new BicycleArchive
            {
                Id = 3,
                Model = "Prestige",
                Manufacturer = "Nishiki",
                Year = 1986,
                Rating = 6,
                Info = "Suntour Accushift group 6-speed."
            }
        };
    }
}
