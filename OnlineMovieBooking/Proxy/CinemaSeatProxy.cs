using OnlineMovieBooking.Domain.Services.CinemaSeatService;
using OnlineMovieBooking.Models;
using OnlineMovieBooking.Domain.Services.UserServices;
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
        private readonly OnlineMovieBooking.Domain.Services.UserServices.CinemaSeatService.CinemaSeatQueryService.CinemaSeatQueryService ucs = new Domain.Services.UserServices.CinemaSeatService.CinemaSeatQueryService.CinemaSeatQueryService();
        public CinemaSeatProxy() { }
        public CinemaSeatProxy(CinemaSeatQueryService cinemaSeatQueryService, CinemaSeatCommandService cinemaSeatCommandService, OnlineMovieBooking.Domain.Services.UserServices.CinemaSeatService.CinemaSeatQueryService.CinemaSeatQueryService uc)
        {
            this.cscs = cinemaSeatCommandService;
            this.csqs = cinemaSeatQueryService;
            this.ucs = uc;
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

        public List<CinemaSeatModel> GetByCinemaHallId(int id)
        {
            List<CinemaSeatModel> cs = new List<CinemaSeatModel>();
            List<OnlineMovieBooking.Domain.DTO.CinemaSeat> css = ucs.GetByCinemaHallId(id);
            foreach (var cseat in css)
            {
                CinemaSeatModel cc = new CinemaSeatModel();
                cc.CinemaSeatId = cseat.CinemaSeatId;
                cc.SeatNumber = cseat.SeatNumber;
                cc.Type = cseat.Type;
                cc.CinemaHallId = cseat.CinemaHallId;
                cs.Add(cc);
            }
            return cs;
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

        public CinemaSeatModel GetBySeatId(int id)
        {
            CinemaSeatModel cc = new CinemaSeatModel();
            OnlineMovieBooking.Domain.DTO.CinemaSeat cseat = ucs.GetBySeatId(id);
            cc.CinemaSeatId = cseat.CinemaSeatId;
            cc.SeatNumber = cseat.SeatNumber;
            cc.Type = cseat.Type;
            cc.CinemaHallId = cseat.CinemaHallId;
            return cc;
        }

        public CinemaSeatModel GetBySeatNumber(string number)
        {
            CinemaSeatModel cc = new CinemaSeatModel();
            OnlineMovieBooking.Domain.DTO.CinemaSeat cseat = ucs.GetBySeatNumber(number);
            cc.CinemaSeatId = cseat.CinemaSeatId;
            cc.SeatNumber = cseat.SeatNumber;
            cc.Type = cseat.Type;
            cc.CinemaHallId = cseat.CinemaHallId;
            return cc;
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