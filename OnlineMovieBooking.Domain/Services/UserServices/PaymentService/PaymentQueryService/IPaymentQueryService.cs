using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentQueryService
{
    interface IPaymentQueryService
    {
        List<Payment> GetByUserId(int id);
        List<Payment> GetByShowId(int id);
        Payment GetById(int id);
        Payment GetByTransactionId(string id);
        List<Payment> GetByPaymentMethod(string method);
        List<Payment> GetByBookingId(int id);
    }
}
