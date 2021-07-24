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

        public Payment GetById(int id)
        {
            DTO.Payment pm = new Payment();
            Repository.Entities.Payment pym = pr.GetById(id);
            return pm;
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
                dp.UserId = rp.UserId;
                dp.ShowId = rp.ShowId;
                dp.MovieId=rp.MovieId;
                dps.Add(dp);
            }
            return dps;
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
                dp.UserId = rp.UserId;
                dp.ShowId = rp.ShowId;
                dp.MovieId = rp.MovieId;
                dps.Add(dp);
            }
            return dps;
        }
    }
}
