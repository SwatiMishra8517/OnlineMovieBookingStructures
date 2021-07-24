using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.PaymentService
{
    public class PaymentCommandService : IPaymentCommandService
    {
        private readonly IPaymentRepository repository;
        private PaymentRepository pr;

        public PaymentCommandService() { }
        public PaymentCommandService(IPaymentRepository repository)
        {
            this.repository = repository;
        }
        public void Add(Payment payment)
        {
            pr = new PaymentRepository();
            Repository.Entities.Payment p = new Repository.Entities.Payment
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                DiscountCouponId = payment.DiscountCouponId,
                RemoteTransactionId = payment.RemoteTransactionId,
                PaymentMethod = payment.PaymentMethod,
                BookingId = payment.BookingId
            };
            pr.Add(p);
        }

        public void Delete(int id)
        {
            pr = new PaymentRepository();
            Repository.Entities.Payment p = new Repository.Entities.Payment();
            pr.Delete(id);
        }

        public void Update(int id, Payment payment)
        {
            pr = new PaymentRepository();
            Repository.Entities.Payment p = pr.GetById(id);
            p.PaymentId = payment.PaymentId;
            p.Amount = payment.Amount;
            p.Time = payment.Time;
            p.DiscountCouponId = payment.DiscountCouponId;
            p.RemoteTransactionId = payment.RemoteTransactionId;
            p.PaymentMethod = payment.PaymentMethod;
            p.BookingId = payment.BookingId;
            pr.Update(id, p);
        }
    }
}
