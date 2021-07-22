using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using OnlineMovieBooking.Domain.Services.ShowService;
using OnlineMovieBooking.Domain.Services.BookingService;
using OnlineMovieBooking.Domain.Services.CinemaSeatService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowSeatService
{
    public class ShowSeatQueryService : IShowSeatQueryService
    {
        private readonly IShowSeatRepository repository;
        private ShowSeatRepository ssr;
        private ShowQueryService sqr;
        private BookingQueryService sbr;
        private CinemaSeatQueryService csqr;

        public ShowSeatQueryService() { }
        public ShowSeatQueryService(IShowSeatRepository repository)
        {
            this.repository = repository;
        }
        public ShowSeat Get(int id)
        {
            Repository.Entities.ShowSeat showSeat= ssr.GetById(id);
            ShowSeat ss = new ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                BookingId = showSeat.BookingId,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId
            };
            return ss;
        }

        public List<ShowSeat> GetAll()
        {
            var retList = ssr.GetAll()
            .Select(showSeat => new ShowSeat()
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                BookingId = showSeat.BookingId,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId,
                Show = sqr.Get(showSeat.ShowId),
                Booking = sbr.Get(showSeat.BookingId),
                CinemaSeat = csqr.Get(showSeat.BookingId)
            }).ToList();
            return retList;
        }
    }
}
