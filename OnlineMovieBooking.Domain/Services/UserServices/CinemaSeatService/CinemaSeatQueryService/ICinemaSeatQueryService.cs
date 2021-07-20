using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.CinemaSeatService.CinemaSeatQueryService
{
    interface ICinemaSeatQueryService
    {
        List<CinemaSeat> GetAll();
        List<CinemaSeat> GetByCinemaHallId(int id);
        CinemaSeat GetBySeatId(int id);
        CinemaSeat GetBySeatNumber(string number);

    }
}
