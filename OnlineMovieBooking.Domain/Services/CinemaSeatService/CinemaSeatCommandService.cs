using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaSeatService
{
    public class CinemaSeatCommandService : ICinemaSeatCommandService
    {
        private readonly ICinemaSeatRepository repository;
        private CinemaSeatRepository csr;
        public CinemaSeatCommandService(ICinemaSeatRepository repository)
        {
            this.repository = repository;
        }
        public void Add(CinemaSeat cinemaSeat)
        {
            Repository.Entities.CinemaSeat cs = new Repository.Entities.CinemaSeat
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId
            };
            csr.Add(cs);
        }

        public void Delete(int id)
        {
            Repository.Entities.CinemaSeat u = new Repository.Entities.CinemaSeat();
            csr.Delete(id);
        }

        public void Update(int id, CinemaSeat cinemaSeat)
        {
            Repository.Entities.CinemaSeat cs = csr.GetById(id);
            cs.CinemaSeatId = cinemaSeat.CinemaSeatId;
            cs.SeatNumber = cinemaSeat.SeatNumber;
            cs.Type = cinemaSeat.Type;
            cs.CinemaHallId = cinemaSeat.CinemaHallId;
            csr.Update(id, cs);
        }
    }
}
