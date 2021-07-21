using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentQueryService
{
    public class PaymentQueryService : IPaymentQueryService
    {
        PaymentRepository pr = new PaymentRepository();
        public List<Payment> GetByBookingId(int id)
        {
            List<DTO.Payment> dps = new List<Payment>();
            List<Repository.Entities.Payment> rps = pr.GetByBookingId(id);
            foreach(var rp in rps)
            {
                DTO.Payment dp = new Payment();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.DiscountCouponId = rp.DiscountCouponId;
                dp.RemoteTransactionId = rp.RemoteTransactionId;
                dp.PaymentMethod = rp.PaymentMethod;
                dp.BookingId = rp.BookingId;
                dps.Add(dp);
            }
            return dps;
        }

        public Payment GetById(int id)
        {
            DTO.Payment pm = new Payment();
            Repository.Entities.Payment pym = pr.GetById(id);
            return pm;
        }

        public List<Payment> GetByPaymentMethod(string method)
        {
            List<DTO.Payment> dps = new List<Payment>();
            List<Repository.Entities.Payment> rps = pr.GetByPaymentMethod(method);
            foreach (var rp in rps)
            {
                DTO.Payment dp = new Payment();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.DiscountCouponId = rp.DiscountCouponId;
                dp.RemoteTransactionId = rp.RemoteTransactionId;
                dp.PaymentMethod = rp.PaymentMethod;
                dp.BookingId = rp.BookingId;
                dps.Add(dp);
            }
            return dps;
        }

        public List<Payment> GetByShowId(int id)
        {
            List<DTO.Payment> dps = new List<Payment>();
            List<Repository.Entities.Payment> rps = pr.GetByShowId(id);
            foreach (var rp in rps)
            {
                DTO.Payment dp = new Payment();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.DiscountCouponId = rp.DiscountCouponId;
                dp.RemoteTransactionId = rp.RemoteTransactionId;
                dp.PaymentMethod = rp.PaymentMethod;
                dp.BookingId = rp.BookingId;
                dps.Add(dp);
            }
            return dps;
        }

        public Payment GetByTransactionId(string id)
        {
            DTO.Payment pm = new Payment();
            Repository.Entities.Payment pym = pr.GetByTransactionId(id);
            return pm;
        }

        public List<Payment> GetByUserId(int id)
        {
            List<DTO.Payment> dps = new List<Payment>();
            List<Repository.Entities.Payment> rps = pr.GetByUserId(id);
            foreach (var rp in rps)
            {
                DTO.Payment dp = new Payment();
                dp.PaymentId = rp.PaymentId;
                dp.Amount = rp.Amount;
                dp.Time = rp.Time;
                dp.DiscountCouponId = rp.DiscountCouponId;
                dp.RemoteTransactionId = rp.RemoteTransactionId;
                dp.PaymentMethod = rp.PaymentMethod;
                dp.BookingId = rp.BookingId;
                dps.Add(dp);
            }
            return dps;
        }
    }
}
