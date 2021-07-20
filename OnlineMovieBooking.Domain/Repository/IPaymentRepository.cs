using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IPaymentRepository
    {
        void Add(Payment payment);
        Payment GetById(int id);
        void Update(int id, Payment payment);
        void Delete(int id);
        List<Payment> GetAll();
        List<Payment> GetByUserId(int id);
        List<Payment> GetByShowId(int id);
        Payment GetByTransactionId(string id);
        List<Payment> GetByPaymentMethod(string method);
        List<Payment> GetByBookingId(int id);
    }
}