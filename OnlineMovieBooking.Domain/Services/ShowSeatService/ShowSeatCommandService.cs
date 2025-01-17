﻿using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowSeatService
{
    public class ShowSeatCommandService : IShowSeatCommandService
    {
        private readonly IShowSeatRepository repository;
        private ShowSeatRepository ssr;
        public ShowSeatCommandService() { }
        
        public ShowSeatCommandService(IShowSeatRepository repository)
        {
            this.repository = repository;
        }

        public void Add(ShowSeat showSeat)
        {
            ssr = new ShowSeatRepository();
            Repository.Entities.ShowSeat ss = new Repository.Entities.ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                ShowId = showSeat.ShowId
            };
            ssr.Add(ss);
        }

        public void Delete(int id)
        {
            ssr = new ShowSeatRepository();
            Repository.Entities.ShowSeat u = new Repository.Entities.ShowSeat();
            ssr.Delete(id);
        }

        public void Update(int id, ShowSeat showSeat)
        {
            ssr = new ShowSeatRepository();
            Repository.Entities.ShowSeat ss = ssr.GetById(id);
            ss.ShowSeatId = showSeat.ShowSeatId;
            ss.Status = showSeat.Status;
            ss.ShowId = showSeat.ShowId;
            ssr.Update(id, ss);
        }
    }
}
