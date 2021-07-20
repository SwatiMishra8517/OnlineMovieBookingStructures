using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowService
{
    public interface IShowCommandService
    {
        void Add(Show show);
        void Delete(int id);
        void Update(int id, Show show);
    }
}