﻿using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaHallService
{
    public class CinemaHallQueryService : ICinemaHallQueryService
    {
        private readonly ICinemaHallRepository repository;
        private CinemaHallRepository chr = new CinemaHallRepository();
        public CinemaHallQueryService() { }
        public CinemaHallQueryService(ICinemaHallRepository repository)
        {
            this.repository = repository;
        }
        public CinemaHall Get(int id)
        {
            Repository.Entities.CinemaHall cinemaHall = chr.GetById(id);
            CinemaHall ch = new CinemaHall
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name
            };
            return ch;
        }

        public List<CinemaHall> GetAll()
        {
            var retList = chr.GetAll()
            .Select(cinemaHall => new CinemaHall()
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
            })
            .ToList();
            return retList;
        }
    }
}
