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
    public class ResultatController : Controller
    {
        private LeagueContext db = new LeagueContext();

        // GET: Resultat
        public ActionResult Index()
        {
            var resultats = db.Resultats.Include(r => r.equipe1);
            return View(resultats.ToList());
        }

        // GET: Resultat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resultat resultat = db.Resultats.Find(id);
            if (resultat == null)
            {
                return HttpNotFound();
            }
            return View(resultat);
        }

        // GET: Resultat/Create
        public ActionResult Create()
        {
            ViewBag.IDEquipe1 = new SelectList(db.Equipes, "IDEquipe", "TeamName");
            return View();
        }

        // POST: Resultat/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDResultat,IDEquipe1,IDEquipe2,victoire")] Resultat resultat)
        {
            if (ModelState.IsValid)
            {
                db.Resultats.Add(resultat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDEquipe1 = new SelectList(db.Equipes, "IDEquipe", "TeamName", resultat.IDEquipe1);
            return View(resultat);
        }

        // GET: Resultat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resultat resultat = db.Resultats.Find(id);
            if (resultat == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDEquipe1 = new SelectList(db.Equipes, "IDEquipe", "TeamName", resultat.IDEquipe1);
            return View(resultat);
        }

        // POST: Resultat/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDResultat,IDEquipe1,IDEquipe2,victoire")] Resultat resultat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resultat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDEquipe1 = new SelectList(db.Equipes, "IDEquipe", "TeamName", resultat.IDEquipe1);
            return View(resultat);
        }

        // GET: Resultat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resultat resultat = db.Resultats.Find(id);
            if (resultat == null)
            {
                return HttpNotFound();
            }
            return View(resultat);
        }

        // POST: Resultat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Resultat resultat = db.Resultats.Find(id);
            db.Resultats.Remove(resultat);
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
