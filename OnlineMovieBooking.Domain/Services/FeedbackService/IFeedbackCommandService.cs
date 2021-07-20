using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.FeedbackService
{
    public interface IFeedbackCommandService
    {
        void Add(Feedback feedback);
        void Delete(int id);
        void Update(int id, Feedback feedback);
    }
}