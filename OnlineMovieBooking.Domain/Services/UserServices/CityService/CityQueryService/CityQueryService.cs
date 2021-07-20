using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CityService.CityQueryService
{
    class CityQueryService : ICityQueryService
    {
        CityRepository cr = new CityRepository();
        public DTO.City GetById(int id)
        {
            var city = cr.GetById(id);
            DTO.City c = new DTO.City();
            c.CityId = city.CityId;
            c.Name = city.Name;
            c.State = city.State;
            c.ZipCode = city.ZipCode;
            c.Cinemas = (ICollection<DTO.Cinema>)city.Cinemas;
            return c;
        }

        public List<DTO.City> GetCities()
        {
            List<DTO.City> cityList = new List<DTO.City>();
            List<Repository.Entities.City> cities = cr.GetAll();
            foreach(var city in cities)
            {
                DTO.City c = new DTO.City();
                c.CityId = city.CityId;
                c.Name = city.Name;
                c.State = city.State;
                c.ZipCode = city.ZipCode;
                c.Cinemas = (ICollection<DTO.Cinema>)city.Cinemas;
                cityList.Add(c);
            }
            return cityList;

        }
    }
}
