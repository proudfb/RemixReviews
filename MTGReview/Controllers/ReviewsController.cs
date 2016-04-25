using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using RemixReview.Models;
using RemixReview.CustomAttributes;

namespace RemixReview.Controllers
{
    public class ReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        // GET: Reviews
        [AllowAnonymous]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer,User")]
        public ActionResult Index(string searchString = null)
        {
            var reviews = db.Reviews.Include(r => r.Music).Include(r => r.User);
            if (!(searchString == null))
            {
                reviews = reviews.Where(r => r.Music.FileName.Contains(searchString));
            }
            return View(reviews.ToList());
        }

        #region Admin CRUD
        // GET: Reviews/Details/5
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Create()
        {
            ViewBag.MusicID = new SelectList(db.Musics, "ID", "FileName");
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Create([Bind(Include = "ID,UserId,MusicID,ReviewText")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MusicID = new SelectList(db.Musics, "ID", "FileName", review.MusicID);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", review.UserId);
            return View(review);
        }

        // GET: Reviews/Edit/5
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.MusicID = new SelectList(db.Musics, "ID", "FileName", review.MusicID);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", review.UserId);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Edit([Bind(Include = "ID,UserId,MusicID,ReviewText")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MusicID = new SelectList(db.Musics, "ID", "FileName", review.MusicID);
            ViewBag.UserId = new SelectList(db.Users, "Id", "Email", review.UserId);
            return View(review);
        }

        // GET: Reviews/Delete/5
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Reviewer CRUD
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin, Music Admin, Reviewer")]
        public ActionResult UserReviews(string searchString = null)
        {
            string currentUser = User.Identity.GetUserId();
            var reviews = db.Reviews.Include(m => m.Music)
                .Where(u => u.User.Id.Equals(currentUser));
            if (!(searchString == null))
            {
                reviews = reviews.Where(r => r.Music.FileName.Contains(searchString));
            }
            return View(reviews.ToList());
        }

        [AllowAnonymous]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer,User")]
        public ActionResult UserReviewDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        [HttpGet]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin, Music Admin, Reviewer")]
        public ActionResult UserCreate(int musicID)
        {
            string userID = User.Identity.GetUserId();
            Review userReview = new Review { UserId = userID, MusicID = musicID };
            return View(userReview);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin, Music Admin, Reviewer")]
        public ActionResult UserCreate(Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("ListOfReviewsByMusic", new { ID = review.MusicID });
            }
            return View(review);
        }

        [HttpGet]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin, Music Admin, Reviewer")]
        public ActionResult UserEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            if (review.UserId != User.Identity.GetUserId())
            {
                return RedirectToAction("AccessDenied", "Error");
            }
            return View(review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer")]
        public ActionResult UserEdit([Bind(Include = "ID,UserId,MusicID,ReviewText")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer")]
        public ActionResult UserDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            if (review.UserId != User.Identity.GetUserId())
            {
                return RedirectToAction("AccessDenied", "Error");
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("UserDelete")]
        [ValidateAntiForgeryToken]
        [AuthorizeOrRedirectAttribute(Roles = "Site Admin,Music Admin,Reviewer")]
        public ActionResult UserDeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
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

        public ActionResult ListOfReviewsByMusic(int ID)
        {
            var reviews = db.Reviews
                .Where(r => r.MusicID == ID)
                .ToList();
            var music = db.Musics.Find(ID);
            ViewBag.musicFileName = music.FileName;
            ViewBag.MusicID = music.ID;
            ViewBag.UserID = User.Identity.GetUserId();
            return View(reviews);
        } 
    }
}
