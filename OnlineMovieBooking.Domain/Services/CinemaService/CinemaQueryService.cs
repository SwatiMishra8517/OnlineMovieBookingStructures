using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaService
{
    public class CinemaQueryService : ICinemaQueryService
    {
        private readonly ICinemaRepository repository;
        private CinemaRepository cr;
        public CinemaQueryService() { }
        public CinemaQueryService(ICinemaRepository repository)
        {
            this.repository = repository;
        }
        public Cinema Get(int id)
        {
            Repository.Entities.Cinema cinema = cr.GetById(id);
            Cinema c = new Cinema
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId
            };
            return c;
        }

        public List<Cinema> GetAll()
        {
            var retList = cr.GetAll()
            .Select(cinema => new Cinema()
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId
            })
            .ToList();
            return retList;
        }
    }
}
