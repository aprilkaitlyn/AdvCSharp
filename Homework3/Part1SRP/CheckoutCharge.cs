using System;
namespace hw3part1.Model
{
    public class CheckoutCharge
    {
        public static void CardPay(Cart cart, PaymentDetails paymentDetails) {

            if (paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                CardCharge.Pay(paymentDetails, cart);
            }
        }
    }
}
