using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.FeedbackService
{
    public interface IFeedbackQueryService
    {
        Feedback Get(int id);
        List<Feedback> GetAll();
    }
}