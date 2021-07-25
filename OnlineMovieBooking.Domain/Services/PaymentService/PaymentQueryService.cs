using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.PaymentService
{
    public class PaymentQueryService : IPaymentQueryService
    {
        private readonly IPaymentRepository repository;
        private PaymentRepository pr;
        public PaymentQueryService() { }
        public PaymentQueryService(IPaymentRepository repository)
        {
            this.repository = repository;
        }
        public Payment Get(int id)
        {
            pr = new PaymentRepository();
            Repository.Entities.Payment payment = pr.GetById(id);
            Payment p = new Payment
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                UserId = payment.UserId,
                MovieId = payment.MovieId
            };
            return p;
        }

        public List<Payment> GetAll()
        {
            pr = new PaymentRepository();
            var retList = pr.GetAll()
            .Select(payment => new Payment()
            {
                PaymentId = payment.PaymentId,
                Amount = payment.Amount,
                Time = payment.Time,
                UserId = payment.UserId,
                MovieId = payment.MovieId
            }).ToList();
            return retList;
        }
    }
}
