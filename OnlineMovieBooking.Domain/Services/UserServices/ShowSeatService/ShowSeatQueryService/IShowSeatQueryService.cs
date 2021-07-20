using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService
{
    interface IShowSeatQueryService
    {
        ShowSeat GetById(int id);
        List<ShowSeat> GetAll();
        List<ShowSeat> GetByShowId(int id);
        ShowSeat GetByBookinId(int id);
        string GetStatus(int id);
        double GetPrice(int id);
    }
}
