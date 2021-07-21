using OnlineMovieBooking.Domain.Services.FeedbackService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class FeedbackProxy : IFeedbackProxy
    {
        private readonly FeedbackCommandService fcs = new FeedbackCommandService();
        private readonly FeedbackQueryService fqs = new FeedbackQueryService();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.FeedbackService.FeedbackQueryService.FeedbackQueryService ufs = new Domain.Services.UserServices.FeedbackService.FeedbackQueryService.FeedbackQueryService();

        public FeedbackProxy() { }
        public FeedbackProxy(FeedbackQueryService feedbackQueryService, FeedbackCommandService feedbackCommandService, OnlineMovieBooking.Domain.Services.UserServices.FeedbackService.FeedbackQueryService.FeedbackQueryService uf)
        {
            this.fcs = feedbackCommandService;
            this.fqs = feedbackQueryService;
            this.ufs = uf;
        }

        public void Add(FeedbackModel feedback)
        {
            var f = new OnlineMovieBooking.Domain.DTO.Feedback
            {
                FeedbackId = feedback.FeedbackId,
                Rating = feedback.Rating,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
            };
            fcs.Add(f);
        }

        public void Delete(int id)
        {
            fcs.Delete(id);
        }

        public List<FeedbackModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.Feedback> feedbacks = fqs.GetAll();
            List<FeedbackModel> fms = new List<FeedbackModel>();
            foreach (var feedback in feedbacks)
            {
                FeedbackModel f = new FeedbackModel
                {
                    FeedbackId = feedback.FeedbackId,
                    Rating = feedback.Rating,
                    Review = feedback.Review,
                    UserId = feedback.UserId,
                    MovieId = feedback.MovieId,
                };
                fms.Add(f);
            }
            return fms;
        }

        public FeedbackModel GetById(int id)
        {
            var feedback = fqs.Get(id);
            FeedbackModel f = new FeedbackModel
            {
                FeedbackId = feedback.FeedbackId,
                Rating = feedback.Rating,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
            };
            return f;
        }

        public List<FeedbackModel> GetByMovieId(int id)
        {
            List<FeedbackModel> fb = new List<FeedbackModel>();
            List<OnlineMovieBooking.Domain.DTO.Feedback> fl = ufs.GetByMovieId(id);
            foreach (var f in fl)
            {
                FeedbackModel df = new FeedbackModel();
                df.FeedbackId = f.FeedbackId;
                df.Rating = f.Rating;
                df.Review = f.Review;
                df.UserId = f.UserId;
                df.MovieId = f.MovieId;
                fb.Add(df);
            }
            return fb;
        }
    

        public void Update(int id, FeedbackModel feedback)
        {
            var f = new OnlineMovieBooking.Domain.DTO.Feedback
            {
                FeedbackId = feedback.FeedbackId,
                Rating = feedback.Rating,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
            };
            fcs.Update(id, f);

        }
    }
}