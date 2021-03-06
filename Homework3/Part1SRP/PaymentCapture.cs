using System;
using hw3part1.Services;
namespace hw3part1.Model
{
    public class PaymentCapture
    {
        public static PaymentGateway Capture()
        {
            PaymentGateway pay = new PaymentGateway();

            return pay;
        }
    }
}
