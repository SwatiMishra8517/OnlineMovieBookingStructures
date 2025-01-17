﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.PaymentService.PaymentCommandService
{
    interface IPaymentCommandService
    {
        void Add(Payment payment);
    }
}
