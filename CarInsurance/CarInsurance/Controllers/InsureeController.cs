﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LasttName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insurees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insurees);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LasttName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insurees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insurees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insurees);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees insurees = db.Insurees.Find(id);
            if (insurees == null)
            {
                return HttpNotFound();
            }
            return View(insurees);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees insurees = db.Insurees.Find(id);
            db.Insurees.Remove(insurees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult CalculateQuote(int Id)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees.Find(Id);
                var dateOfBirth = insuree.DateOfBirth;
                var carYear = insuree.CarYear;
                var carModel = insuree.CarModel;
                var carMake = insuree.CarMake;
                var speedingTickets = insuree.SpeedingTickets;
                var dui = insuree.DUI;
                var coverageType = insuree.CoverageType;

                var quote = 50.0M;

                if (dateOfBirth.Year >= 2003)
                {
                    quote = quote + 100.00M;
                }
                else if (dateOfBirth.Year <= 2001 && dateOfBirth.Year >= 1996)
                {
                    quote = quote + 50.0M;
                }
                else if (dateOfBirth.Year < 1996)
                {
                    quote = quote + 25.0M;
                }

                if (carYear < 2000)
                {
                    quote = quote + 25.0M;
                }
                else if (carYear > 2015)
                {
                    quote = quote + 25.0M;
                }

                if (carMake == "Porsche")
                {
                    quote = quote + 25.0M;
                }

                if (carMake == "Porsche" && carModel == "911 Carrera")
                {
                    quote = quote + 25.0M;
                }

                quote = quote + (speedingTickets * 10.0M);

                if (dui == true)
                {
                    quote = quote + (quote / 4.0M);
                }

                if (coverageType == true)
                {
                    quote = quote + (quote / 2.0M);
                }
                insuree.Quote = quote;
                db.SaveChanges();

            }
            return View("Index");
        }
    }
}
