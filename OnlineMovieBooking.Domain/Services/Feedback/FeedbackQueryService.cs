using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Feedback
{
    public class FeedbackQueryService : IFeedbackQueryService
    {
        private readonly IFeedbackRepository repository;
        
        public FeedbackQueryService(IFeedbackRepository repository)
        {
            this.repository = repository;
        }
    }
}
