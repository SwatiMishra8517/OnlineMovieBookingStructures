using OnlineMovieBooking.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.ControllerService
{
    public class PaymentControllerService
    {
        private PaymentProxy paymentProxy = new PaymentProxy();
        public void Add(PaymentModel payment)
        {
            paymentProxy.Add(payment);
        }
        public void Delete(int id)
        {
            paymentProxy.Delete(id);
        }
        public void Update(int id, PaymentModel payment)
        {
            paymentProxy.Update(id, payment);
        }
        public PaymentModel GetById(int id)
        {
            return paymentProxy.GetById(id);
        }
        public List<PaymentModel> GetAll()
        {
            return paymentProxy.GetAll();
        }
        public List<PaymentModel> GetByUserId(int id)
        {
            return paymentProxy.GetByUserId(id);
        }
        public List<PaymentModel> GetByShowId(int id)
        {
            return paymentProxy.GetByShowId(id);
        }

        public PaymentModel GetByTransactionId(string id)
        {
            return paymentProxy.GetByTransactionId(id);
        }
        public List<PaymentModel> GetByPaymentMethod(string method)
        {
            return paymentProxy.GetByPaymentMethod(method);
        }
        public List<PaymentModel> GetByBookingId(int id)
        {
            return paymentProxy.GetByBookingId(id);
        }
    }
}