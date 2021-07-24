using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.FeedbackService
{
    public class FeedbackCommandService : IFeedbackCommandService
    {
        private readonly IFeedbackRepository repository;
        private FeedbackRepository fr;
        public FeedbackCommandService() { }
        public FeedbackCommandService(IFeedbackRepository repository)
        {
            this.repository = repository;
        }
        public void Add(Feedback feedback)
        {
            Repository.Entities.Feedback f = new Repository.Entities.Feedback
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId
            };
            fr.Add(f);
        }

        public void Delete(int id)
        {
            Repository.Entities.Feedback u = new Repository.Entities.Feedback();
            fr.Delete(id);
        }

        public void Update(int id, Feedback feedback)
        {
            Repository.Entities.Feedback f = fr.GetById(id);
            f.FeedbackId = feedback.FeedbackId;
            f.Review = feedback.Review;
            f.UserId = feedback.UserId;
            f.MovieId = feedback.MovieId;
            fr.Update(id, f);
        }
    }
}
