using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService
{
    class ShowSeatQueryService : IShowSeatQueryService
    {
        ShowSeatRepository sr = new ShowSeatRepository();
        public List<ShowSeat> GetAll()
        {
            List<DTO.ShowSeat> ds = new List<ShowSeat>();
            List<Repository.Entities.ShowSeat> es = sr.GetAll();
            foreach(var res in es)
            {
                DTO.ShowSeat dts = new ShowSeat();
                dts.ShowSeatId = res.ShowSeatId;
                dts.Status = res.Status;
                dts.Price = res.Price;
                dts.CinemaSeatId = res.CinemaSeatId;
                dts.ShowId = res.ShowId;
                dts.BookingId = res.BookingId;
                ds.Add(dts);
            }
            return ds;
        }

        public ShowSeat GetByBookinId(int id)
        {
            Repository.Entities.ShowSeat res = sr.GetByBookinId(id);
            DTO.ShowSeat dts = new ShowSeat();
            dts.ShowSeatId = res.ShowSeatId;
            dts.Status = res.Status;
            dts.Price = res.Price;
            dts.CinemaSeatId = res.CinemaSeatId;
            dts.ShowId = res.ShowId;
            dts.BookingId = res.BookingId;
            return dts;
        }

        public ShowSeat GetById(int id)
        {
            Repository.Entities.ShowSeat res = sr.GetById(id);
            DTO.ShowSeat dts = new ShowSeat();
            dts.ShowSeatId = res.ShowSeatId;
            dts.Status = res.Status;
            dts.Price = res.Price;
            dts.CinemaSeatId = res.CinemaSeatId;
            dts.ShowId = res.ShowId;
            dts.BookingId = res.BookingId;
            return dts;
        }

        public List<ShowSeat> GetByShowId(int id)
        {
            throw new NotImplementedException();
        }

        public double GetPrice(int id)
        {
            return sr.GetPrice(id);
        }

        public string GetStatus(int id)
        {
            return sr.GetStatus(id);
        }
    }
}
