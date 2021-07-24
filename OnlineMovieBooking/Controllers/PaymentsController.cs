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
    public class PaymentsController : Controller
    {
        private PaymentControllerService pcs = new PaymentControllerService();
        

        // GET: Payments
        public ActionResult Index()
        {
            List<PaymentModel> pms = pcs.GetAll();
            List<PaymentViewModel> pvms = new List<PaymentViewModel>();
            foreach (var payment in pms)
            {
                PaymentViewModel p = new PaymentViewModel
                {
                    PaymentId = payment.PaymentId,
                    Amount = payment.Amount,
                    Time = payment.Time,
                    UserId = payment.UserId,
                    ShowId = payment.ShowId,
                    MovieId = payment.MovieId
                };
                pvms.Add(p);
            }
            var payments = pcs.GetAll();
            return View(pvms);
        }

        // GET: Payments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentModel payment = pcs.GetById((int)id);
            PaymentViewModel p = new PaymentViewModel
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                UserId = payment.UserId,
                ShowId = payment.ShowId,
                MovieId = payment.MovieId
            };
            if (payment == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }
        //Commented in view of not able to alter booking data


        // GET: Payments/Create
        //public ActionResult Create()
        //{
        //    ViewBag.BookingId = new SelectList(bcs.GetAll(), "BookingId", "Status");
        //    ViewBag.BookingId = new SelectList(bcs.GetAll(), "BookingId", "Status");
        //    ViewBag.BookingId = new SelectList(bcs.GetAll(), "BookingId", "Status");
        //    return View();
        //}

        //// POST: Payments/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "PaymentId,Amount,Time,DiscountCouponId,RemoteTransactionId,PaymentMethod,BookingId")] PaymentViewModel payment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        payment.Time = DateTime.Now;
        //        PaymentModel p = new PaymentModel
        //        {
        //            PaymentId = payment.PaymentId,
        //            Amount = payment.Amount,
        //            Time = payment.Time,
        //            UserId = payment.UserId,
        //            ShowId = payment.ShowId,
        //            MovieId = payment.MovieId
        //        };
        //        pcs.Add(p);
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.BookingId = new SelectList(bcs.GetAll(), "BookingId", "Status", payment.BookingId);
        //    return View(payment);
        //}
    }
}
