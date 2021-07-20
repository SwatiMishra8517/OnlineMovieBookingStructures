using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CityService.CityQueryService
{
    interface ICityQueryService
    {
        List<DTO.City> GetCities();
        DTO.City GetById(int id);
    }
}
