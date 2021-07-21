using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.ShowService.ShowQueryService
{
    public class ShowQueryService : IShowQueryService
    {
        ShowRepository sr = new ShowRepository();
        public List<Show> GetByCinemaHallId(int id)
        {
            List<DTO.Show> s = new List<Show>();
            List<Repository.Entities.Show> sl = sr.GetByCinemaHallId(id);
            foreach(var show in sl)
            {
                DTO.Show sh = new Show();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                sh.Bookings = (ICollection<Booking>)show.Bookings;
                sh.ShowSeats = (ICollection<ShowSeat>)show.ShowSeats;
                s.Add(sh);

            }
            return s;
        }

        public List<Show> GetByDate(DateTime date)
        {
            List<DTO.Show> s = new List<Show>();
            List<Repository.Entities.Show> sl = sr.GetByDate(date);
            foreach (var show in sl)
            {
                DTO.Show sh = new Show();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                sh.Bookings = (ICollection<Booking>)show.Bookings;
                sh.ShowSeats = (ICollection<ShowSeat>)show.ShowSeats;
                s.Add(sh);

            }
            return s;
        }

        public Show GetById(int id)
        {
            DTO.Show sh = new Show();
            var show = sr.GetById(id);
            sh.ShowId = show.ShowId;
            sh.Date = show.Date;
            sh.StartTime = show.StartTime;
            sh.EndTime = show.EndTime;
            sh.CinemaHallId = show.CinemaHallId;
            sh.MovieId = show.MovieId;
            sh.Bookings = (ICollection<Booking>)show.Bookings;
            sh.ShowSeats = (ICollection<ShowSeat>)show.ShowSeats;
            return sh;
        }

        public List<Show> GetByMovieId(int id)
        {
            List<DTO.Show> s = new List<Show>();
            List<Repository.Entities.Show> sl = sr.GetByMovieId(id);
            foreach (var show in sl)
            {
                DTO.Show sh = new Show();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                sh.Bookings = (ICollection<Booking>)show.Bookings;
                sh.ShowSeats = (ICollection<ShowSeat>)show.ShowSeats;
                s.Add(sh);

            }
            return s;
        }

        public List<Show> GetByStartTime(DateTime time)
        {
            List<DTO.Show> s = new List<Show>();
            List<Repository.Entities.Show> sl = sr.GetByStartTime(time);
            foreach (var show in sl)
            {
                DTO.Show sh = new Show();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                sh.Bookings = (ICollection<Booking>)show.Bookings;
                sh.ShowSeats = (ICollection<ShowSeat>)show.ShowSeats;
                s.Add(sh);

            }
            return s;
        }
    }
}
