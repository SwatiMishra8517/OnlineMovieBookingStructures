using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CityService
{
    public class CityQueryService : ICityQueryService
    {
        private readonly ICityRepository repository;
        private CityRepository cr;

        public CityQueryService(ICityRepository repository)
        {
            this.repository = repository;
        }
        public City Get(int id)
        {
            Repository.Entities.City city = cr.GetById(id);
            City c = new City
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode
            };
            return c;
        }

        public List<City> GetAll()
        {
            var retList = cr.GetAll()
            .Select(city => new City()
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode
            })
            .ToList();
            return retList;
        }
    }
}
