using OnlineMovieBooking.Domain.Services.ShowSeatService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class ShowSeatProxy : IShowSeatProxy
    {
        private readonly ShowSeatCommandService sscs = new ShowSeatCommandService();
        private readonly ShowSeatQueryService ssqs = new ShowSeatQueryService();
        private OnlineMovieBooking.Domain.Repository.ShowSeatRepository srs = new Domain.Repository.ShowSeatRepository();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService.ShowSeatQueryService uss = new Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService.ShowSeatQueryService();
        public ShowSeatProxy() { }
        public ShowSeatProxy(ShowSeatQueryService userQueryService, ShowSeatCommandService userCommandService, OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService.ShowSeatQueryService us)
        {
            this.sscs = userCommandService;
            this.ssqs = userQueryService;
            this.uss = us;
        }

        public void Add(ShowSeatModel showSeat)
        {
            var ss = new OnlineMovieBooking.Domain.DTO.ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                ShowId = showSeat.ShowId,
            };
            sscs.Add(ss);
        }

        public void Delete(int id)
        {
            sscs.Delete(id);
        }

        public List<ShowSeatModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.ShowSeat> showSeats = ssqs.GetAll();
            List<ShowSeatModel> ums = new List<ShowSeatModel>();
            foreach (var showSeat in showSeats)
            {
                ShowSeatModel ss = new ShowSeatModel
                {
                    ShowSeatId = showSeat.ShowSeatId,
                    Status = showSeat.Status,
                    ShowId = showSeat.ShowId,
                };
                ums.Add(ss);
            }
            return ums;
        }

        public ShowSeatModel GetById(int id)
        {
            var showSeat = ssqs.Get(id);
            ShowSeatModel ss = new ShowSeatModel
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                ShowId = showSeat.ShowId,
            };
            return ss;
        }

        public List<ShowSeatModel> GetByShowId(int id)
        {
            List<ShowSeatModel> ds = new List<ShowSeatModel>();
            List<OnlineMovieBooking.Domain.DTO.ShowSeat> es = uss.GetByShowId(id);
            foreach (var res in es)
            {
                ShowSeatModel dts = new ShowSeatModel
                {
                    ShowSeatId = res.ShowSeatId,
                    Status = res.Status,
                    ShowId = res.ShowId,
                };
                ds.Add(dts);
            }
            return ds;
        }

        public string GetStatus(int id)
        {
            return uss.GetStatus(id);
        }

        public void Update(int id, ShowSeatModel showSeat)
        {
            var ss = new OnlineMovieBooking.Domain.DTO.ShowSeat
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                ShowId = showSeat.ShowId,
            };
            sscs.Update(id, ss);

        }
        public List<ShowSeatModel> GetNonReserved()
        {

            List<OnlineMovieBooking.Domain.Repository.Entities.ShowSeat> es = srs.GetNonReserved();
            List<ShowSeatModel> ds = new List<ShowSeatModel>();
            foreach (var res in es)
            {
                ShowSeatModel dts = new ShowSeatModel
                {
                    ShowSeatId = res.ShowSeatId,
                    Status = res.Status,
                    ShowId = res.ShowId,
                };
                ds.Add(dts);
            }
            return ds;

        }
    }
}