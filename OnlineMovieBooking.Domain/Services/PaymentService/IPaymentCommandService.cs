using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.PaymentService
{
    public interface IPaymentCommandService
    {
        void Add(Payment payment);
        void Delete(int id);
        void Update(int id, Payment payment);
    }
}