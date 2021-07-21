using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CinemaHallService.CinemaHallQueryService
{
    public class CinemaHallQueryService : ICinemaHallQueryService
    {
        private CinemaHallRepository chr = new CinemaHallRepository();
        public List<CinemaHall> GetAll()
        {
            List<DTO.CinemaHall> chs = new List<CinemaHall>();
            List<Repository.Entities.CinemaHall> halls = chr.GetAll();
            foreach(var ch in halls)
            {
                DTO.CinemaHall c = new CinemaHall();
                c.CinemaHallId = ch.CinemaHallId;
                c.Name = ch.Name;
                c.TotalSeats = ch.TotalSeats;
                c.CinemaId = ch.CinemaId;
                c.CinemaSeats = (ICollection<CinemaSeat>)ch.CinemaSeats;
                c.Shows = (ICollection<Show>)ch.Shows;
                chs.Add(c);
            }
            return chs;
        }

        public List<CinemaHall> GetByCinemaId(int id)
        {
            List<DTO.CinemaHall> chs = new List<CinemaHall>();
            List<Repository.Entities.CinemaHall> halls = chr.GetByCinemaId(id);
            foreach (var ch in halls)
            {
                DTO.CinemaHall c = new CinemaHall();
                c.CinemaHallId = ch.CinemaHallId;
                c.Name = ch.Name;
                c.TotalSeats = ch.TotalSeats;
                c.CinemaId = ch.CinemaId;
                c.CinemaSeats = (ICollection<CinemaSeat>)ch.CinemaSeats;
                c.Shows = (ICollection<Show>)ch.Shows;
                chs.Add(c);
            }
            return chs;
        }

        public CinemaHall GetById(int id)
        {
                Repository.Entities.CinemaHall ch = chr.GetById(id);
                DTO.CinemaHall c = new CinemaHall();
                c.CinemaHallId = ch.CinemaHallId;
                c.Name = ch.Name;
                c.TotalSeats = ch.TotalSeats;
                c.CinemaId = ch.CinemaId;
                c.CinemaSeats = (ICollection<CinemaSeat>)ch.CinemaSeats;
                c.Shows = (ICollection<Show>)ch.Shows;
            
            return c;
        }

        public CinemaHall GetByName(string name)
        {
            Repository.Entities.CinemaHall ch = chr.GetByName(name);
            DTO.CinemaHall c = new CinemaHall();
            c.CinemaHallId = ch.CinemaHallId;
            c.Name = ch.Name;
            c.TotalSeats = ch.TotalSeats;
            c.CinemaId = ch.CinemaId;
            c.CinemaSeats = (ICollection<CinemaSeat>)ch.CinemaSeats;
            c.Shows = (ICollection<Show>)ch.Shows;

            return c;
        }
    }
}
