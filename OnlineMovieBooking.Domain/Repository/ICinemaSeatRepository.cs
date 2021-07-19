using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface ICinemaSeatRepository
    {
        List<CinemaSeat> GetAll();
        CinemaSeat GetById(int id);
        bool Add(CinemaSeat cinemaSeat);
        void Edit(int id, CinemaSeat cinemaSeat);
        void Delete(int id);
    }
}