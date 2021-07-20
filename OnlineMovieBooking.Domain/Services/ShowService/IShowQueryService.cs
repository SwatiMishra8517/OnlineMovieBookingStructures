using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowService
{
    public interface IShowQueryService
    {
        Show Get(int id);
        List<Show> GetAll();
    }
}