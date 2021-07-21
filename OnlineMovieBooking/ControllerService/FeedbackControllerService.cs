using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class FeedbackControllerService
    {
        private FeedbackProxy feedbackProxy = new FeedbackProxy();
        public void Add(FeedbackModel feedback)
        {
            feedbackProxy.Add(feedback);
        }
        public void Delete(int id)
        {
            feedbackProxy.Delete(id);
        }
        public void Update(int id, FeedbackModel feedback)
        {
            feedbackProxy.Update(id, feedback);
        }
        public FeedbackModel GetById(int id)
        {
            return feedbackProxy.GetById(id);
        }
        public List<FeedbackModel> GetAll()
        {
            return feedbackProxy.GetAll();
        }
        public List<FeedbackModel> GetByMovieId(int id)
        {
            return feedbackProxy.GetByMovieId(id);
        }

    }
}