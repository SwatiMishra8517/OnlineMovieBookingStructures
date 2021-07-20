using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowSeatService
{
    public interface IShowSeatQueryService
    {
        ShowSeat Get(int id);
        List<ShowSeat> GetAll();
    }
}