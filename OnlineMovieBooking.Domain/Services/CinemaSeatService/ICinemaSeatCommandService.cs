using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaSeatService
{
    public interface ICinemaSeatCommandService
    {
        void Add(CinemaSeat cinemaSeat);
        void Delete(int id);
        void Update(int id, CinemaSeat cinemaSeat);
    }
}