using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface ICityRepository
    {
        void Add(City city);
        City GetById(int id);
        void Update(int id, City city);
        void Delete(int id);
        List<City> GetAll();
    }
}