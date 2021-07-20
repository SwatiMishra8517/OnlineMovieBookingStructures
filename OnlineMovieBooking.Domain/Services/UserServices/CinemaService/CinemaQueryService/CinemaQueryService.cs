using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CinemaService.CinemaQueryService
{
    class CinemaQueryService : ICinemaQueryService
    {
        CinemaRepository cr = new CinemaRepository();
        public List<DTO.Cinema> GetByCityId(int id)
        {
            List<DTO.Cinema> cinemas = new List<DTO.Cinema>();
            List<Repository.Entities.Cinema> c = cr.GetByCityId(id);
            foreach(var cit in c)
            {
                DTO.Cinema cine = new DTO.Cinema();
                cine.CinemaId = cit.CinemaId;
                cine.Name = cit.Name;
                cine.TotalHalls = cit.TotalHalls;
                cine.CityId = cit.CityId;
                cine.City = cine.City;
                cine.CinemaHalls = (ICollection<DTO.CinemaHall>)cit.CinemaHalls;
                cinemas.Add(cine);
            }
            return cinemas;
        }

        public DTO.Cinema GetById(int id)
        {
            Repository.Entities.Cinema cit = cr.GetById(id);
            DTO.Cinema cine = new DTO.Cinema();
            cine.CinemaId = cit.CinemaId;
            cine.Name = cit.Name;
            cine.TotalHalls = cit.TotalHalls;
            cine.CityId = cit.CityId;
            cine.City = cine.City;
            cine.CinemaHalls = (ICollection<DTO.CinemaHall>)cit.CinemaHalls;
            return cine;
        }

        public DTO.Cinema GetByName(string name)
        {
            Repository.Entities.Cinema cit = cr.GetByName(name);
            DTO.Cinema cine = new DTO.Cinema();
            cine.CinemaId = cit.CinemaId;
            cine.Name = cit.Name;
            cine.TotalHalls = cit.TotalHalls;
            cine.CityId = cit.CityId;
            cine.City = cine.City;
            cine.CinemaHalls = (ICollection<DTO.CinemaHall>)cit.CinemaHalls;
            return cine;
        }
    }
}
