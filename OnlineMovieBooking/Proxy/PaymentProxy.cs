using OnlineMovieBooking.Domain.Services.PaymentService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class PaymentProxy : IPaymentProxy
    {
        private readonly PaymentCommandService pcs = new PaymentCommandService();
        private readonly PaymentQueryService pqs = new PaymentQueryService();
        public  OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentQueryService.PaymentQueryService ups = new Domain.Services.UserServices.PaymentService.PaymentQueryService.PaymentQueryService();

        public PaymentProxy() { }
        public PaymentProxy(PaymentQueryService paymentQueryService, PaymentCommandService paymentCommandService, OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentQueryService.PaymentQueryService up)
        {
            this.pcs = paymentCommandService;
            this.pqs = paymentQueryService;
            this.ups = up;
        }

        public void Add(PaymentModel payment)
        {
            var p = new OnlineMovieBooking.Domain.DTO.Payment
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                UserId = payment.UserId,
                ShowId = payment.ShowId,
                MovieId = payment.MovieId,
            };
            pcs.Add(p);
        }

        public void Delete(int id)
        {
            pcs.Delete(id);
        }

        public List<PaymentModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.Payment> payments = pqs.GetAll();
            List<PaymentModel> pms = new List<PaymentModel>();
            foreach (var payment in payments)
            {
                PaymentModel p = new PaymentModel
                {
                    PaymentId = payment.PaymentId,
                    Amount = payment.Amount,
                    Time = payment.Time,
                    UserId = payment.UserId,
                    ShowId = payment.ShowId,
                    MovieId = payment.MovieId,
                };
                pms.Add(p);
            }
            return pms;
        }

        public PaymentModel GetById(int id)
        {
            var payment = pqs.Get(id);
            PaymentModel p = new PaymentModel
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                UserId = payment.UserId,
                ShowId = payment.ShowId,
                MovieId = payment.MovieId,
            };
            return p;
        }

        public void Update(int id, PaymentModel payment)
        {
            var p = new OnlineMovieBooking.Domain.DTO.Payment
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                UserId = payment.UserId,
                ShowId = payment.ShowId,
                MovieId = payment.MovieId,
            };
            pcs.Update(id, p);

        }
        public List<PaymentModel> GetByShowId(int id)
        {
            List<PaymentModel> dps = new List<PaymentModel>();
            List<OnlineMovieBooking.Domain.DTO.Payment> rps = ups.GetByShowId(id);
            foreach (var rp in rps)
            {
                PaymentModel dp = new PaymentModel();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.UserId = rp.UserId;
                dp.ShowId = rp.ShowId;
                dp.MovieId = rp.MovieId;
                dps.Add(dp);
            }
            return dps;
        }

        public List<PaymentModel> GetByUserId(int id)
        {
            List<PaymentModel> dps = new List<PaymentModel>();
            List<OnlineMovieBooking.Domain.DTO.Payment> rps = ups.GetByUserId(id);
            foreach (var rp in rps)
            {
                PaymentModel dp = new PaymentModel();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.UserId = rp.UserId;
                dp.ShowId = rp.ShowId;
                dp.MovieId = rp.MovieId;
                dps.Add(dp);
            }
            return dps;
        }
        public List<PaymentModel> GetByMovieId(int id)
        {
            List<PaymentModel> dps = new List<PaymentModel>();
            List<OnlineMovieBooking.Domain.DTO.Payment> rps = ups.GetByMovieId(id);
            foreach (var rp in rps)
            {
                PaymentModel dp = new PaymentModel();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.UserId = rp.UserId;
                dp.ShowId = rp.ShowId;
                dp.MovieId = rp.MovieId;
                dps.Add(dp);
            }
            return dps;
        }
    }
}