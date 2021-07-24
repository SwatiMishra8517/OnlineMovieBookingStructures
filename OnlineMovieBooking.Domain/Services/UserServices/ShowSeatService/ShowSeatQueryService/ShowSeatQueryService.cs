using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.ShowSeatService.ShowSeatQueryService
{
    public class ShowSeatQueryService : IShowSeatQueryService
    {
        ShowSeatRepository sr = new ShowSeatRepository();
        public List<ShowSeat> GetAll()
        {
            List<DTO.ShowSeat> ds = new List<ShowSeat>();
            List<Repository.Entities.ShowSeat> es = sr.GetAll();
            foreach(var res in es)
            {
                DTO.ShowSeat dts = new ShowSeat();
                dts.ShowSeatId = res.ShowSeatId;
                dts.Status = res.Status;
                dts.ShowId = res.ShowId;
                ds.Add(dts);
            }
            return ds;
        }



        public ShowSeat GetById(int id)
        {
            Repository.Entities.ShowSeat res = sr.GetById(id);
            DTO.ShowSeat dts = new ShowSeat();
            dts.ShowSeatId = res.ShowSeatId;
            dts.Status = res.Status;
            dts.ShowId = res.ShowId;
            return dts;
        }

        public List<ShowSeat> GetByShowId(int id)
        {
            List<DTO.ShowSeat> ds = new List<ShowSeat>();
            List<Repository.Entities.ShowSeat> es = sr.GetByShowId(id);
            foreach (var res in es)
            {
                DTO.ShowSeat dts = new ShowSeat();
                dts.ShowSeatId = res.ShowSeatId;
                dts.Status = res.Status;
                dts.ShowId = res.ShowId;
                ds.Add(dts);
            }
            return ds;
        }



        public string GetStatus(int id)
        {
            return sr.GetStatus(id);
        }
    }
}
