﻿using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentQueryService
{
    interface IPaymentQueryService
    {
        List<Payment> GetByUserId(int id);
        Payment GetById(int id);
    }
}
