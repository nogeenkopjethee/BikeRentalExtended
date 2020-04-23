using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BikeRental2.Web.Models;
using BikeRental2.Web.ViewModels;

namespace BikeRental2.Web.Controllers
{
    public class ReservationsController : Controller
    {
        private BikeStoreModel db = new BikeStoreModel();

        public ActionResult Success()
        {
            return View();
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            ReservationsViewModel vm = new ReservationsViewModel();
            return View(vm);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReservationsViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.Confirm == true)
                {
                    vm.GetTotalPrice();
                    vm.Create();
                    return RedirectToAction("Success");
                }
                else
                {
                    vm.GetTotalPrice();
                    vm.Confirm = true;
                    return View(vm);
                }
            }

            return View(vm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
