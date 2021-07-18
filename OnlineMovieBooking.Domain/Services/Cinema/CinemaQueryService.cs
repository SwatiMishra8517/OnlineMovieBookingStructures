﻿using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Cinema
{
    public class CinemaQueryService : ICinemaQueryService
    {
        private readonly ICinemaRepository repository;

        public CinemaQueryService(ICinemaRepository repository)
        {
            this.repository = repository;
        }
    }
}
