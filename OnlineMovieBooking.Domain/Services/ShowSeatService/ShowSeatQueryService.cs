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

        public ShowSeatQueryService() { }
        public ShowSeatQueryService(IShowSeatRepository repository)
        {
            this.repository = repository;
        }
        public ShowSeat Get(int id)
        {
            ssr = new ShowSeatRepository();
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
            ssr = new ShowSeatRepository();
            var retList = ssr.GetAll()
            .Select(showSeat => new ShowSeat()
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                BookingId = showSeat.BookingId,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId
            }).ToList();
            return retList;
        }
    }
}
