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
        public ShowSeatProxy() { }
        public ShowSeatProxy(ShowSeatQueryService userQueryService, ShowSeatCommandService userCommandService)
        {
            this.sscs = userCommandService;
            this.ssqs = userQueryService;
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