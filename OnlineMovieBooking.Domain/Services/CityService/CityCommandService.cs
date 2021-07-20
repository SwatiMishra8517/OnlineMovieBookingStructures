using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CityService
{
    public class CityCommandService : ICityCommandService
    {
        private readonly ICityRepository repository;
        private CityRepository cr;
        public CityCommandService() { }
        public CityCommandService(ICityRepository repository)
        {
            this.repository = repository;
        }
        public void Add(City city)
        {
            Repository.Entities.City c = new Repository.Entities.City
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode
            };
            cr.Add(c);
        }

        public void Delete(int id)
        {
            Repository.Entities.City c = new Repository.Entities.City();
            cr.Delete(id);
        }

        public void Update(int id, City city)
        {
            Repository.Entities.City c = cr.GetById(id);
            c.CityId = city.CityId;
            c.Name = city.Name;
            c.State = city.State;
            c.ZipCode = city.ZipCode;
            cr.Update(id, c);
        }
    }
}
