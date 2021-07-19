using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Entities;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IBookingRepository
    {
        List<Booking> GetAll();
        bool Add(Booking booking);
        Booking GetById(int id);
        void Edit(int id,Booking booking);
        void Delete(int id);
    }
}