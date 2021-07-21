using OnlineMovieBooking.Domain.Services.PaymentService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IPaymentProxy
    {
        void Add(PaymentModel payment);
        void Delete(int id);
        void Update(int id, PaymentModel payment);
        PaymentModel GetById(int id);
        List<PaymentModel> GetAll();
        List<PaymentModel> GetByUserId(int id);
        List<PaymentModel> GetByShowId(int id);

        PaymentModel GetByTransactionId(string id);
        List<PaymentModel> GetByPaymentMethod(string method);
        List<PaymentModel> GetByBookingId(int id);
    }
}