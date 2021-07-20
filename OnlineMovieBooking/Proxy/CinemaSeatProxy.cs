using OnlineMovieBooking.Domain.Services.CinemaSeatService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class CinemaSeatProxy : ICinemaSeatProxy
    {
        private readonly CinemaSeatCommandService cscs = new CinemaSeatCommandService();
        private readonly CinemaSeatQueryService csqs = new CinemaSeatQueryService();
        public CinemaSeatProxy() { }
        public CinemaSeatProxy(CinemaSeatQueryService cinemaSeatQueryService, CinemaSeatCommandService cinemaSeatCommandService)
        {
            this.cscs = cinemaSeatCommandService;
            this.csqs = cinemaSeatQueryService;
        }

        public void Add(CinemaSeatModel cinemaSeat)
        {
            var u = new OnlineMovieBooking.Domain.DTO.CinemaSeat
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId,
            };
            cscs.Add(u);
        }

        public void Delete(int id)
        {
            cscs.Delete(id);
        }

        public List<CinemaSeatModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.CinemaSeat> cinemaSeats = csqs.GetAll();
            List<CinemaSeatModel> csms = new List<CinemaSeatModel>();
            foreach (var cinemaSeat in cinemaSeats)
            {
                CinemaSeatModel cs = new CinemaSeatModel
                {
                    CinemaSeatId = cinemaSeat.CinemaSeatId,
                    SeatNumber = cinemaSeat.SeatNumber,
                    Type = cinemaSeat.Type,
                    CinemaHallId = cinemaSeat.CinemaHallId,
                };
                csms.Add(cs);
            }
            return csms;
        }

        public CinemaSeatModel GetById(int id)
        {
            var cinemaSeat = csqs.Get(id);
            CinemaSeatModel cs = new CinemaSeatModel
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId,
            };
            return cs;
        }

        public void Update(int id, CinemaSeatModel cinemaSeat)
        {
            var cs = new OnlineMovieBooking.Domain.DTO.CinemaSeat
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId,
            };
            cscs.Update(id, cs);

        }
    }
}