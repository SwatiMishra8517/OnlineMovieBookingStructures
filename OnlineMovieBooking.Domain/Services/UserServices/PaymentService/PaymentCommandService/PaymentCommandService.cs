using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentCommandService
{
    class PaymentCommandService : IPaymentCommandService
    {
        private PaymentRepository pr = new PaymentRepository();
        public void Add(Payment rp)
        {
            Repository.Entities.Payment dp = new Repository.Entities.Payment();
            dp.PaymentId = rp.PaymentId;
            dp.Amount = rp.Amount;
            dp.Time = rp.Time;
            dp.DiscountCouponId = rp.DiscountCouponId;
            dp.RemoteTransactionId = rp.RemoteTransactionId;
            dp.PaymentMethod = rp.PaymentMethod;
            dp.BookingId = rp.BookingId;
            pr.Add(dp);
        }
    }
}
