using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.ViewModels;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class FeedbacksController : Controller
    {
        private FeedbackControllerService fcs = new FeedbackControllerService();


        // GET: Feedbacks
        public ActionResult Index()
        {
            List<FeedbackModel> fml = fcs.GetAll();
            List<FeedbackViewModel> fvl = new List<FeedbackViewModel>();
            foreach(var feedback in fml)
            {
                var f = new FeedbackViewModel
                {
                    FeedbackId = feedback.FeedbackId,
                    Review = feedback.Review,
                    UserId = feedback.UserId,
                    MovieId = feedback.MovieId,
                };
                fvl.Add(f);
            }
            return View(fvl);
        }

        // GET: Feedbacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModel feedback = fcs.GetById(id: (int)id);
            FeedbackViewModel f =new FeedbackViewModel()
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
            };
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // GET: Feedbacks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModel feedback = fcs.GetById((int)id);
            var f = new FeedbackViewModel()
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
            };
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fcs.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
