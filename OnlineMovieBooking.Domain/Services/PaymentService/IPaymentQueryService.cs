﻿using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.PaymentService
{
    public interface IPaymentQueryService
    {
        Payment Get(int id);
        List<Payment> GetAll();
    }
}