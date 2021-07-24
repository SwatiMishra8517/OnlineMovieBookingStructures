using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.FeedbackService
{
    public class FeedbackQueryService : IFeedbackQueryService
    {
        private readonly IFeedbackRepository repository;
        private FeedbackRepository fr;
        public FeedbackQueryService() { }
        public FeedbackQueryService(IFeedbackRepository repository)
        {
            this.repository = repository;
        }
        public Feedback Get(int id)
        {
            Repository.Entities.Feedback feedback = fr.GetById(id);
            Feedback f = new Feedback
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId
            };
            return f;
        }

        public List<Feedback> GetAll()
        {
            var retList = fr.GetAll()
            .Select(feedback => new Feedback()
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId
            })
            .ToList();
            return retList;
        }
    }
}
