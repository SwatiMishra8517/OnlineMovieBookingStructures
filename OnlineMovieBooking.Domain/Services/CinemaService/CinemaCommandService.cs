using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaService
{
    public class CinemaCommandService : ICinemaCommandService
    {
        private readonly ICinemaRepository repository;
        private CinemaRepository cr;
        public CinemaCommandService() { }
        public CinemaCommandService(ICinemaRepository repository)
        {
            this.repository = repository;
        }
        public void Add(Cinema cinema)
        {
            Repository.Entities.Cinema c = new Repository.Entities.Cinema
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId
            };
            cr.Add(c);
        }

        public void Delete(int id)
        {
            Repository.Entities.City c = new Repository.Entities.City();
            cr.Delete(id);
        }

        public void Update(int id, Cinema cinema)
        {
            Repository.Entities.Cinema c = cr.GetById(id);
            c.CinemaId = cinema.CinemaId;
            c.Name = cinema.Name;
            c.TotalHalls = cinema.TotalHalls;
            c.CityId = cinema.CityId;
            cr.Update(id, c);
        }
    }
}
