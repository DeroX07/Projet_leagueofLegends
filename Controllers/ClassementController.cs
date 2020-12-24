using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projet_LeagueofLegends.DAL;
using Projet_LeagueofLegends.Models;

namespace Projet_LeagueofLegends.Controllers
{
    public class ClassementController : Controller
    {
        private LeagueContext db = new LeagueContext();

        // GET: Classement
        public ActionResult Index()
        {
            var classements = db.Classements.Include(c => c.equipe);
            return View(classements.ToList());
        }

        // GET: Classement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classement classement = db.Classements.Find(id);
            if (classement == null)
            {
                return HttpNotFound();
            }
            return View(classement);
        }

        // GET: Classement/Create
        public ActionResult Create()
        {
            ViewBag.IDEquipe = new SelectList(db.Equipes, "IDEquipe", "TeamName");
            return View();
        }

        // POST: Classement/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDClassement,IDEquipe")] Classement classement)
        {
            if (ModelState.IsValid)
            {
                db.Classements.Add(classement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDEquipe = new SelectList(db.Equipes, "IDEquipe", "TeamName", classement.IDEquipe);
            return View(classement);
        }

        // GET: Classement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classement classement = db.Classements.Find(id);
            if (classement == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDEquipe = new SelectList(db.Equipes, "IDEquipe", "TeamName", classement.IDEquipe);
            return View(classement);
        }

        // POST: Classement/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDClassement,IDEquipe")] Classement classement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDEquipe = new SelectList(db.Equipes, "IDEquipe", "TeamName", classement.IDEquipe);
            return View(classement);
        }

        // GET: Classement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Classement classement = db.Classements.Find(id);
            if (classement == null)
            {
                return HttpNotFound();
            }
            return View(classement);
        }

        // POST: Classement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Classement classement = db.Classements.Find(id);
            db.Classements.Remove(classement);
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
    }
}
