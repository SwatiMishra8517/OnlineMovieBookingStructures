using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Feedback
{
    public class FeedbackCommandService : IFeedbackCommandService
    {
        private readonly IFeedbackRepository repository;

        public FeedbackCommandService(IFeedbackRepository repository)
        {
            this.repository = repository;
        }
    }
}
