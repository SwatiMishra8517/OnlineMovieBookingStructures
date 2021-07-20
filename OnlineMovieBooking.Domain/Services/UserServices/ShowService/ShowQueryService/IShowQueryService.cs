using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.ShowService.ShowQueryService
{
    interface IShowQueryService
    {
        Show GetById(int id);
        List<Show> GetByDate(DateTime date);
        List<Show> GetByStartTime(DateTime time);
        List<Show> GetByCinemaHallId(int id);
        List<Show> GetByMovieId(int id);
    }
}
