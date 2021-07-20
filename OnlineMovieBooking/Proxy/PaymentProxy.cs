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
        public PaymentProxy() { }
        public PaymentProxy(PaymentQueryService paymentQueryService, PaymentCommandService paymentCommandService)
        {
            this.pcs = paymentCommandService;
            this.pqs = paymentQueryService;
        }

        public void Add(PaymentModel payment)
        {
            var p = new OnlineMovieBooking.Domain.DTO.Payment
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                DiscountCouponId = payment.DiscountCouponId,
                RemoteTransactionId = payment.RemoteTransactionId,
                PaymentMethod = payment.PaymentMethod,
                BookingId = payment.BookingId
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
                    DiscountCouponId = payment.DiscountCouponId,
                    RemoteTransactionId = payment.RemoteTransactionId,
                    PaymentMethod = payment.PaymentMethod,
                    BookingId = payment.BookingId
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
                DiscountCouponId = payment.DiscountCouponId,
                RemoteTransactionId = payment.RemoteTransactionId,
                PaymentMethod = payment.PaymentMethod,
                BookingId = payment.BookingId
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
                DiscountCouponId = payment.DiscountCouponId,
                RemoteTransactionId = payment.RemoteTransactionId,
                PaymentMethod = payment.PaymentMethod,
                BookingId = payment.BookingId
            };
            pcs.Update(id, p);

        }
    }
}