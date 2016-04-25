using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RemixReview.Models;
using RemixReview.CustomAttributes;

namespace RemixReview.Controllers
{
    public class MusicController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        [AllowAnonymous]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer,User")]
        public ActionResult ListMusic(string searchString = null)
        {
            var model = from m in db.Musics
                        select m;
            if (!(searchString==null))
            {
                model = model.Where(m => m.FileName.Contains(searchString));
            }
                //db.Musics.ToList();
            return View(model.ToList());
        }

        [AllowAnonymous]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer,User")]
        public ActionResult ListOfMusicByCategory(string category)
        {
            var music = db.Musics
                .Where(c => c.Category == category)
                .ToList();
            return View(music);
        }

        [AllowAnonymous]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer,User")]
        public ActionResult ViewDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        #region Admin CRUD

        // GET: Music
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Index(string searchString = null)
        {
            var model = from m in db.Musics
                        select m;
            if (!(searchString == null))
            {
                model = model.Where(m => m.FileName.Contains(searchString));
            }
            //db.Musics.ToList();
            return View(model.ToList());
        }

        // GET: Music/Details/5
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // GET: Music/Create
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Create([Bind(Include = "ID,FileName,Source,Duration,Artist,Category")] Music music)
        {
            if (ModelState.IsValid)
            {
                db.Musics.Add(music);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(music);
        }

        // GET: Music/Edit/5
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // POST: Music/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Edit([Bind(Include = "ID,FileName,Source,Duration,Artist,Category")] Music music)
        {
            if (ModelState.IsValid)
            {
                db.Entry(music).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(music);
        }

        // GET: Music/Delete/5
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Music music = db.Musics.Find(id);
            if (music == null)
            {
                return HttpNotFound();
            }
            return View(music);
        }

        // POST: Music/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Music music = db.Musics.Find(id);
            db.Musics.Remove(music);
            db.SaveChanges();
            return RedirectToAction("Index");
        } 
        #endregion

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
