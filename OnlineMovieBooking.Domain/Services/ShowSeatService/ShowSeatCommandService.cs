using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowSeatService
{
    public class ShowSeatCommandService : IShowSeatCommandService
    {
        private readonly IShowSeatRepository repository;
        public ShowSeatCommandService() { }
        
        public ShowSeatCommandService(IShowSeatRepository repository)
        {
            this.repository = repository;
        }
        private ShowSeatRepository ssr = new ShowSeatRepository();

        public void Add(ShowSeat showSeat)
        {
            Repository.Entities.ShowSeat ss = new Repository.Entities.ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                Price = showSeat.Price,
                BookingId = showSeat.BookingId,
                CinemaSeatId = showSeat.CinemaSeatId,
                ShowId = showSeat.ShowId
            };
            ssr.Add(ss);
        }

        public void Delete(int id)
        {
            Repository.Entities.ShowSeat u = new Repository.Entities.ShowSeat();
            ssr.Delete(id);
        }

        public void Update(int id, ShowSeat showSeat)
        {
            Repository.Entities.ShowSeat ss = ssr.GetById(id);
            ss.ShowSeatId = showSeat.ShowSeatId;
            ss.Status = showSeat.Status;
            ss.Price = showSeat.Price;
            ss.BookingId = showSeat.BookingId;
            ss.CinemaSeatId = showSeat.CinemaSeatId;
            ss.ShowId = showSeat.ShowId;
            ssr.Update(id, ss);
        }
    }
}
