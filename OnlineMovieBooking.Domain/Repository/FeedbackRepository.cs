using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private MovieContext db;
        public FeedbackRepository()
        {
            db = new MovieContext();
        }
        public FeedbackRepository(MovieContext context)
        {
            this.db = context;
        }
        public void Add(Feedback feedback)
        {
            db.Feedbacks.Add(feedback);
            db.SaveChanges();
        }
        public Feedback GetById(int id)
        {
            return db.Feedbacks.Find(id);
        }
        public void Update(Feedback feedback)
        {
            var s = GetById(feedback.FeedbackId);
            s = feedback;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var feedback = GetById(id);
            db.Feedbacks.Remove(feedback);
            db.SaveChanges();
        }
        public List<Feedback> GetAll()
        {
            return db.Feedbacks.ToList();
        }
    }
}
