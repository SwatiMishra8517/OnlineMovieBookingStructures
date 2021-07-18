using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.User
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IUserRepository repository;

        public UserQueryService(IUserRepository repository)
        {
            this.repository = repository;
        }
    }
}
