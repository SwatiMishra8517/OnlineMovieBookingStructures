using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Show
{
    public class ShowCommandService : IShowCommandService
    {
        private readonly IShowRepository repository; 
        
        public ShowCommandService(IShowRepository repository)
        {
            this.repository = repository;
        }
    }
}
