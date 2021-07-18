using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Payment
{
    public class PaymentQueryService : IPaymentQueryService
    {
        private readonly IPaymentRepository repository;

        public PaymentQueryService(IPaymentRepository repository)
        {
            this.repository = repository;
        }
    }
}
