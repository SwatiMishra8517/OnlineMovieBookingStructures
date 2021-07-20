using OnlineMovieBooking.Domain.Services.CityService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class CityProxy : ICityProxy
    {
        private readonly CityCommandService ccs = new CityCommandService();
        private readonly CityQueryService cqs = new CityQueryService();
        public CityProxy() { }
        public CityProxy(CityQueryService cityQueryService, CityCommandService cityCommandService)
        {
            this.ccs = cityCommandService;
            this.cqs = cityQueryService;
        }

        public void Add(CityModel city)
        {
            var c = new OnlineMovieBooking.Domain.DTO.City
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode,
            };
            ccs.Add(c);
        }

        public void Delete(int id)
        {
            ccs.Delete(id);
        }

        public List<CityModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.City> cities = cqs.GetAll();
            List<CityModel> cms = new List<CityModel>();
            foreach (var city in cities)
            {
                CityModel c = new CityModel
                {
                    CityId = city.CityId,
                    Name = city.Name,
                    State = city.State,
                    ZipCode = city.ZipCode,
                };
                cms.Add(c);
            }
            return cms;
        }

        public CityModel GetById(int id)
        {
            var city = cqs.Get(id);
            CityModel c = new CityModel
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode,
            };
            return c;
        }

        public void Update(int id, CityModel city)
        {
            var u = new OnlineMovieBooking.Domain.DTO.City
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State,
                ZipCode = city.ZipCode,
            };
            ccs.Update(id, u);

        }
    }
}