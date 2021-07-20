using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaSeatService
{
    public class CinemaSeatQueryService : ICinemaSeatQueryService
    {
        private readonly ICinemaSeatRepository repository;
        private CinemaSeatRepository csr;
        public CinemaSeatQueryService() { }
        public CinemaSeatQueryService(ICinemaSeatRepository repository)
        {
            this.repository = repository;
        }
        public CinemaSeat Get(int id)
        {
            Repository.Entities.CinemaSeat cinemaSeat = csr.GetById(id);
            CinemaSeat cs = new CinemaSeat
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId
            };
            return cs;
        }

        public List<CinemaSeat> GetAll()
        {
            var retList = csr.GetAll()
            .Select(cinemaSeat => new CinemaSeat()
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId
        })
            .ToList();
            return retList;
        }
    }
}
