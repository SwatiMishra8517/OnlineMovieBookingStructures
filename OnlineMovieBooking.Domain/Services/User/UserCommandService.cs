using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.User
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IUserRepository repository;
        
        public UserCommandService(IUserRepository repository)
        {
            this.repository = repository;
        }
    }
}
