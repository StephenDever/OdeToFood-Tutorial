using Portfolio_Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio_Site.Controllers
{
    public class ManufacturersController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from m in _models
                orderby m.Year descending
                select m;

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
            var model = _models.Single(m => m.Id == id);

            return View(model);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var model = _models.Single(m => m.Id == id);
            if (TryUpdateModel(model))
            {
                // save to db, once db is created
                return RedirectToAction("Index");
            }
            return View(model);
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
        static List<BicycleManufacturer> _models = new List<BicycleManufacturer>
        {
            new BicycleManufacturer
            {
                Id = 1,
                Model = "Sirrus",
                Manufacturer = "Specialized",
                Year = 1991,
                Rating = 6,
                Info = "Suntour Edge group, 7-speed."
            },
            new BicycleManufacturer
            {
                Id = 2,
                Model = "912",
                Manufacturer = "Miyata",
                Year = 1981,
                Rating = 8,
                Info = "Shimano 600 Arabesque group, 6-speed."
            },
            new BicycleManufacturer
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
