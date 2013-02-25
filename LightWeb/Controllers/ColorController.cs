using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LightWeb.Models;

namespace LightWeb.Controllers
{ 
    public class ColorController : Controller
    {
        private LightDB db = new LightDB();

        //
        // GET: /Color/

        public ViewResult Index()
        {
            return View(db.Colors.ToList());
        }

        //
        // GET: /Color/Details/5

        public ViewResult Details(int id)
        {
            ColorModel colormodel = db.Colors.Find(id);
            return View(colormodel);
        }

        //
        // GET: /Color/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Color/Create

        [HttpPost]
        public ActionResult Create(ColorModel colormodel)
        {
            if (ModelState.IsValid)
            {
                db.Colors.Add(colormodel);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(colormodel);
        }
        
        //
        // GET: /Color/Edit/5
 
        public ActionResult Edit(int id)
        {
            ColorModel colormodel = db.Colors.Find(id);
            return View(colormodel);
        }

        //
        // POST: /Color/Edit/5

        [HttpPost]
        public ActionResult Edit(ColorModel colormodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colormodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colormodel);
        }

        //
        // GET: /Color/Delete/5
 
        public ActionResult Delete(int id)
        {
            ColorModel colormodel = db.Colors.Find(id);
            return View(colormodel);
        }

        //
        // POST: /Color/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            ColorModel colormodel = db.Colors.Find(id);
            db.Colors.Remove(colormodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}