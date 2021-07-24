using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaHallService
{
    public class CinemaHallCommandService : ICinemaHallCommandService
    {
        private readonly ICinemaHallRepository repository; 
        private CinemaHallRepository chr = new CinemaHallRepository();
        public CinemaHallCommandService() { }
        public CinemaHallCommandService(ICinemaHallRepository repository)
        {
            this.repository = repository;
        }
        public void Add(CinemaHall cinemaHall)
        {
            Repository.Entities.CinemaHall ch = new Repository.Entities.CinemaHall
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
            };
            chr.Add(ch);
        }

        public void Delete(int id)
        {
            Repository.Entities.CinemaHall u = new Repository.Entities.CinemaHall();
            chr.Delete(id);
        }

        public void Update(int id, CinemaHall cinemaHall)
        {
            Repository.Entities.CinemaHall ch = chr.GetById(id);
            ch.CinemaHallId = cinemaHall.CinemaHallId;
            ch.Name = cinemaHall.Name;
            chr.Update(id, ch);
        }
    }
}
