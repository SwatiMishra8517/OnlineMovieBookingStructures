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
        private readonly OnlineMovieBooking.Domain.Services.UserServices.CinemaService.CinemaQueryService.CinemaQueryService ucs = new Domain.Services.UserServices.CinemaService.CinemaQueryService.CinemaQueryService();
        public CinemaProxy() { }
        public CinemaProxy(CinemaQueryService cinemaQueryService, CinemaCommandService cinemaCommandService, OnlineMovieBooking.Domain.Services.UserServices.CinemaService.CinemaQueryService.CinemaQueryService uc)
        {
            this.ccs = cinemaCommandService;
            this.cqs = cinemaQueryService;
            this.ucs = uc;
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

        public List<CinemaModel> GetByCityId(int id)
        {
            List<CinemaModel> cinemas = new List<CinemaModel>();
            List<OnlineMovieBooking.Domain.DTO.Cinema> c = ucs.GetByCityId(id);
            foreach (var cit in c)
            {
                CinemaModel cine = new CinemaModel();
                cine.CinemaId = cit.CinemaId;
                cine.Name = cit.Name;
                cine.TotalHalls = cit.TotalHalls;
                cine.CityId = cit.CityId;
                cine.City = cine.City;
                cinemas.Add(cine);
            }
            return cinemas;
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

        public CinemaModel GetByName(string name)
        {
            CinemaModel cine = new CinemaModel();
            OnlineMovieBooking.Domain.DTO.Cinema cit = ucs.GetByName(name);
            cine.CinemaId = cit.CinemaId;
            cine.Name = cit.Name;
            cine.TotalHalls = cit.TotalHalls;
            cine.CityId = cit.CityId;
            cine.City = cine.City;
            return cine;
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