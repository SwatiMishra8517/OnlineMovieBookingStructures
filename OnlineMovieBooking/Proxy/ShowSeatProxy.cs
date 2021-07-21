using OnlineMovieBooking.Domain.Services.ShowSeatService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class ShowSeatProxy : IShowSeatProxy
    {
        private readonly ShowSeatCommandService sscs = new ShowSeatCommandService();
        private readonly ShowSeatQueryService ssqs = new ShowSeatQueryService();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService.ShowSeatQueryService uss = new Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService.ShowSeatQueryService();
        public ShowSeatProxy() { }
        public ShowSeatProxy(ShowSeatQueryService userQueryService, ShowSeatCommandService userCommandService, OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService.ShowSeatQueryService us)
        {
            this.sscs = userCommandService;
            this.ssqs = userQueryService;
            this.uss = us;
        }

        public void Add(ShowSeatModel showSeat)
        {
            var ss = new OnlineMovieBooking.Domain.DTO.ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId,
                BookingId = showSeat.BookingId
            };
            sscs.Add(ss);
        }

        public void Delete(int id)
        {
            sscs.Delete(id);
        }

        public List<ShowSeatModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.ShowSeat> showSeats = ssqs.GetAll();
            List<ShowSeatModel> ums = new List<ShowSeatModel>();
            foreach (var showSeat in showSeats)
            {
                ShowSeatModel ss = new ShowSeatModel
                {
                    ShowSeatId = showSeat.ShowSeatId,
                    Status = showSeat.Status,
                    Price = showSeat.Price,
                    CinemaSeatId = showSeat.CinemaSeatId,
                    ShowId = showSeat.ShowId,
                    BookingId = showSeat.BookingId
                };
                ums.Add(ss);
            }
            return ums;
        }

        public ShowSeatModel GetByBookinId(int id)
        {
            OnlineMovieBooking.Domain.DTO.ShowSeat res = uss.GetByBookinId(id);
            ShowSeatModel dts = new ShowSeatModel();
            dts.ShowSeatId = res.ShowSeatId;
            dts.Status = res.Status;
            dts.Price = res.Price;
            dts.CinemaSeatId = res.CinemaSeatId;
            dts.ShowId = res.ShowId;
            dts.BookingId = res.BookingId;
            return dts;
        }

        public ShowSeatModel GetById(int id)
        {
            var showSeat = ssqs.Get(id);
            ShowSeatModel ss = new ShowSeatModel
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId,
                BookingId = showSeat.BookingId
            };
            return ss;
        }

        public List<ShowSeatModel> GetByShowId(int id)
        {
            List<ShowSeatModel> ds = new List<ShowSeatModel>();
            List<OnlineMovieBooking.Domain.DTO.ShowSeat> es = uss.GetByShowId(id);
            foreach (var res in es)
            {
                ShowSeatModel dts = new ShowSeatModel();
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

        public double GetPrice(int id)
        {
            return uss.GetPrice(id);
        }

        public string GetStatus(int id)
        {
            return uss.GetStatus(id);
        }

        public void Update(int id, ShowSeatModel showSeat)
        {
            var ss = new OnlineMovieBooking.Domain.DTO.ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId,
                BookingId = showSeat.BookingId
            };
            sscs.Update(id, ss);

        }
    }
}