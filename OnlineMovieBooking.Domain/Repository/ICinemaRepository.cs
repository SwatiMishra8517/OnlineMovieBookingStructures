using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface ICinemaRepository
    {
        List<Cinema> GetAll();
        bool Add(Cinema cinema);
        Cinema GetById(int id);
        void Edit(int id, Cinema cinema);
        void Delete(int id);

    }
}