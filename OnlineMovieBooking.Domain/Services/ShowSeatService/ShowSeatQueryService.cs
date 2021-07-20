using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
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
                ShowId = showSeat.ShowId
            }).ToList();
            return retList;
        }
    }
}
