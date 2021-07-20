using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CityService
{
    public interface ICityCommandService
    {
        void Add(City city);
        void Delete(int id);
        void Update(int id, City city);
    }
}