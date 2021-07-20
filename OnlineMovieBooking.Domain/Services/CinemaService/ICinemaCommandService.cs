using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.CinemaService
{
    public interface ICinemaCommandService
    {
        void Add(Cinema cinema);
        void Delete(int id);
        void Update(int id, Cinema cinema);
    }
}