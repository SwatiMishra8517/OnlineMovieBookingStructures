using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.Show
{
    public class ShowQueryService : IShowQueryService
    {
        private readonly IShowRepository repository;
        
        public ShowQueryService(IShowRepository repository)
        {
            this.repository = repository;
        }
    }
}
