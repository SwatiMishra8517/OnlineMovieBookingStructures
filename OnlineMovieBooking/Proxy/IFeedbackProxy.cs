using OnlineMovieBooking.Domain.Services.FeedbackService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IFeedbackProxy
    {
        void Add(FeedbackModel feedback);
        void Delete(int id);
        void Update(int id, FeedbackModel feedback);
        FeedbackModel GetById(int id);
        List<FeedbackModel> GetAll();
    }
}