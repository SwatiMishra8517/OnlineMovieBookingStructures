using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.ViewModels;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class CitiesController : Controller
    {
        private CityControllerService cts = new CityControllerService();

        // GET: Cities
        public ActionResult Index()
        {
            List<CityModel> cls = cts.GetAll();
            List<CityViewModel> cms = new List<CityViewModel>();
            foreach (var city in cls)
            {
                CityViewModel c = new CityViewModel
                {
                    CityId = city.CityId,
                    Name = city.Name,
                    State = city.State,
                    ZipCode = city.ZipCode,
                };
                cms.Add(c);
            }
            return View(cms);
        }

        // GET: Cities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityViewModel ct = new CityViewModel();
            CityModel city = cts.GetById((int)id);
            CityViewModel c = new CityViewModel
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode,
            };
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityId,Name,State,ZipCode")] CityViewModel city)
        {
            if (ModelState.IsValid)
            {
                CityModel c = new CityModel
                {
                    CityId = city.CityId,
                    Name = city.Name,
                    State = city.State,
                    ZipCode = city.ZipCode,
                };
                cts.Add(c);
                return RedirectToAction("Index");
            }

            return View(city);
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityModel city = cts.GetById((int)id);
            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityId,Name,State,ZipCode")] CityViewModel city)
        {
            if (ModelState.IsValid)
            {
                CityModel c = new CityModel
                {
                    CityId = city.CityId,
                    Name = city.Name,
                    State = city.State,
                    ZipCode = city.ZipCode,
                };
                cts.Update(c.CityId, c);
                return RedirectToAction("Index");
            }
            return View(city);
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CityModel city = cts.GetById((int)id);
            if (city == null)
            {
                return HttpNotFound();
            }
            CityViewModel c = new CityViewModel
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode,
            };
            return View(c);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CityModel city = cts.GetById(id);
            cts.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
