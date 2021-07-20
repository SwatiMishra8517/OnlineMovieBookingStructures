using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CinemaSeatService.CinemaSeatQueryService
{
    class CinemaSeatQueryService : ICinemaSeatQueryService
    {
        CinemaSeatRepository csr = new CinemaSeatRepository();
        public List<CinemaSeat> GetAll()
        {
            List<DTO.CinemaSeat> cs = new List<CinemaSeat>();
            List<Repository.Entities.CinemaSeat> css = csr.GetAll();
            foreach(var cseat in css)
            {
                DTO.CinemaSeat cc = new CinemaSeat();
                cc.CinemaSeatId = cseat.CinemaSeatId;
                cc.SeatNumber = cseat.SeatNumber;
                cc.Type = cseat.Type;
                cc.CinemaHallId = cseat.CinemaHallId;
                cc.Show_Seats = (ICollection<ShowSeat>)cseat.Show_Seats;
                cs.Add(cc);
            }
            return cs;
        }

        public List<CinemaSeat> GetByCinemaHallId(int id)
        {
            List<DTO.CinemaSeat> cs = new List<CinemaSeat>();
            List<Repository.Entities.CinemaSeat> css = csr.GetByCinemaHallId(id);
            foreach (var cseat in css)
            {
                DTO.CinemaSeat cc = new CinemaSeat();
                cc.CinemaSeatId = cseat.CinemaSeatId;
                cc.SeatNumber = cseat.SeatNumber;
                cc.Type = cseat.Type;
                cc.CinemaHallId = cseat.CinemaHallId;
                cc.Show_Seats = (ICollection<ShowSeat>)cseat.Show_Seats;
                cs.Add(cc);
            }
            return cs;
        }

        public CinemaSeat GetBySeatId(int id)
        {
            DTO.CinemaSeat cc = new CinemaSeat();
            var cseat = csr.GetById(id);
            cc.CinemaSeatId = cseat.CinemaSeatId;
            cc.SeatNumber = cseat.SeatNumber;
            cc.Type = cseat.Type;
            cc.CinemaHallId = cseat.CinemaHallId;
            cc.Show_Seats = (ICollection<ShowSeat>)cseat.Show_Seats;
            return cc;

        }

        public CinemaSeat GetBySeatNumber(string number)
        {
            DTO.CinemaSeat cc = new CinemaSeat();
            var cseat = csr.GetBySeatNumber(number);
            cc.CinemaSeatId = cseat.CinemaSeatId;
            cc.SeatNumber = cseat.SeatNumber;
            cc.Type = cseat.Type;
            cc.CinemaHallId = cseat.CinemaHallId;
            cc.Show_Seats = (ICollection<ShowSeat>)cseat.Show_Seats;
            return cc;
        }
    }
}
