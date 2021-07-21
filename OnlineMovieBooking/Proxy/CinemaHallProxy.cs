using OnlineMovieBooking.Domain.Services.CinemaHallService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class CinemaHallProxy : ICinemaHallProxy
    {
        private readonly CinemaHallCommandService chcs = new CinemaHallCommandService();
        private readonly CinemaHallQueryService chqs = new CinemaHallQueryService();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.CinemaHallService.CinemaHallQueryService.CinemaHallQueryService ucs = new Domain.Services.UserServices.CinemaHallService.CinemaHallQueryService.CinemaHallQueryService();
        public CinemaHallProxy() { }
        public CinemaHallProxy(CinemaHallQueryService cinemaHallQueryService, CinemaHallCommandService cinemaHallCommandService, OnlineMovieBooking.Domain.Services.UserServices.CinemaHallService.CinemaHallQueryService.CinemaHallQueryService uc)
        {
            this.chcs = cinemaHallCommandService;
            this.chqs = cinemaHallQueryService;
            this.ucs = uc;
        }

        public void Add(CinemaHallModel cinemaHall)
        {
            var ch = new OnlineMovieBooking.Domain.DTO.CinemaHall
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
                TotalSeats = cinemaHall.TotalSeats,
                CinemaId = cinemaHall.CinemaId,
            };
            chcs.Add(ch);
        }

        public void Delete(int id)
        {
            chcs.Delete(id);
        }

        public List<CinemaHallModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.CinemaHall> cinemaHalls = chqs.GetAll();
            List<CinemaHallModel> chms = new List<CinemaHallModel>();
            foreach (var cinemaHall in cinemaHalls)
            {
                CinemaHallModel ch = new CinemaHallModel
                {
                    CinemaHallId = cinemaHall.CinemaHallId,
                    Name = cinemaHall.Name,
                    TotalSeats = cinemaHall.TotalSeats,
                    CinemaId = cinemaHall.CinemaId,
                };
                chms.Add(ch);
            }
            return chms;
        }

        public List<CinemaHallModel> GetByCinemaId(int id)
        {
            List<CinemaHallModel> chs = new List<CinemaHallModel>();
            List<OnlineMovieBooking.Domain.DTO.CinemaHall> halls = ucs.GetByCinemaId(id);
            foreach (var ch in halls)
            {
                CinemaHallModel c = new CinemaHallModel();
                c.CinemaHallId = ch.CinemaHallId;
                c.Name = ch.Name;
                c.TotalSeats = ch.TotalSeats;
                c.CinemaId = ch.CinemaId;
                chs.Add(c);
            }
            return chs;
        }

        public CinemaHallModel GetById(int id)
        {
            var cinemaHall = chqs.Get(id);
            CinemaHallModel ch = new CinemaHallModel
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
                TotalSeats = cinemaHall.TotalSeats,
                CinemaId = cinemaHall.CinemaId,
            };
            return ch;
        }

        public CinemaHallModel GetByName(string name)
        {
            OnlineMovieBooking.Domain.DTO.CinemaHall ch = new Domain.DTO.CinemaHall();
            CinemaHallModel c = new CinemaHallModel();
            c.CinemaHallId = ch.CinemaHallId;
            c.Name = ch.Name;
            c.TotalSeats = ch.TotalSeats;
            c.CinemaId = ch.CinemaId;
            return c;
        }

        public void Update(int id, CinemaHallModel cinemaHall)
        {
            var ch = new OnlineMovieBooking.Domain.DTO.CinemaHall
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
                TotalSeats = cinemaHall.TotalSeats,
                CinemaId = cinemaHall.CinemaId,
            };
            chcs.Update(id, ch);

        }
    }
}