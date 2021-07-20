using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain;

namespace OnlineMovieBooking.Domain.Services.ShowSeatService
{
    public interface IShowSeatCommandService
    {
        void Add(ShowSeat showSeat);
        void Delete(int id);
        void Update(int id, ShowSeat u);
    }
}