using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public interface IFeedbackRepository
    {
        void Add(Feedback feedback);
        Feedback GetById(int id);
        void Update(int id, Feedback feedback);
        void Delete(int id);
        List<Feedback> GetAll();
    }
}