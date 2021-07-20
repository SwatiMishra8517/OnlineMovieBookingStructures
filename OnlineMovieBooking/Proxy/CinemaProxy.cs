using OnlineMovieBooking.Domain.Services.CinemaService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class CinemaProxy : ICinemaProxy
    {
        private readonly CinemaCommandService ccs = new CinemaCommandService();
        private readonly CinemaQueryService cqs = new CinemaQueryService();
        public CinemaProxy() { }
        public CinemaProxy(CinemaQueryService cinemaQueryService, CinemaCommandService cinemaCommandService)
        {
            this.ccs = cinemaCommandService;
            this.cqs = cinemaQueryService;
        }

        public void Add(CinemaModel cinema)
        {
            var c = new OnlineMovieBooking.Domain.DTO.Cinema
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId,
            };
            ccs.Add(c);
        }

        public void Delete(int id)
        {
            ccs.Delete(id);
        }

        public List<CinemaModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.Cinema> cinemas = cqs.GetAll();
            List<CinemaModel> cms = new List<CinemaModel>();
            foreach (var cinema in cinemas)
            {
                CinemaModel c = new CinemaModel
                {
                    CinemaId = cinema.CinemaId,
                    Name = cinema.Name,
                    TotalHalls = cinema.TotalHalls,
                    CityId = cinema.CityId,
                };
                cms.Add(c);
            }
            return cms;
        }

        public CinemaModel GetById(int id)
        {
            var cinema = cqs.Get(id);
            CinemaModel c = new CinemaModel
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId,
            };
            return c;
        }

        public void Update(int id, CinemaModel cinema)
        {
            var c = new OnlineMovieBooking.Domain.DTO.Cinema
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId,
            };
            ccs.Update(id, c);

        }
    }
}