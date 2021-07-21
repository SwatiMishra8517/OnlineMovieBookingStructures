using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineMovieBooking.Domain.DTO;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.UserServices.FeedbackService.FeedbackQueryService
{
    interface IFeedbackQueryService
    {
        List<Feedback> GetByMovieId(int id);
    }
}
