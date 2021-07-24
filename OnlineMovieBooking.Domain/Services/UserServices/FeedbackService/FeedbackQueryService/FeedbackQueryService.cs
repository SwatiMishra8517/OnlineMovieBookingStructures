using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.FeedbackService.FeedbackQueryService
{
    public class FeedbackQueryService : IFeedbackQueryService
    {
        Repository.FeedbackRepository fr = new FeedbackRepository();
        public List<Feedback> GetByMovieId(int id)
        {
            List<DTO.Feedback> fb = new List<Feedback>();
            List<Repository.Entities.Feedback> fl = fr.GetByMovieId(id);
            foreach(var f in fl)
            {
                DTO.Feedback df= new Feedback();
                df.FeedbackId = f.FeedbackId;
                df.Review = f.Review;
                df.UserId = f.UserId;
                df.MovieId = f.MovieId;
                fb.Add(df);
            }
            return fb;
        }
    }
}
