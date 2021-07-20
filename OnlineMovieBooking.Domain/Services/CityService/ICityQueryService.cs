using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CityService
{
    public interface ICityQueryService
    {
        City Get(int id);
        List<City> GetAll();
    }
}