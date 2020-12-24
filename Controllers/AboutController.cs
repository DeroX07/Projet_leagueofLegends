using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projet_LeagueofLegends.DAL;

namespace Projet_LeagueofLegends.Controllers
{
    public class AboutController : Controller
    {
        private LeagueContext db = new LeagueContext();

        // GET: About
        public ActionResult Index()
        {
            return View(db.Resultats.ToList());
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
