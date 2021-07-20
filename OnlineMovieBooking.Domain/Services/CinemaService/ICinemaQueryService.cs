using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaService
{
    public interface ICinemaQueryService
    {
        Cinema Get(int id);
        List<Cinema> GetAll();
    }
}