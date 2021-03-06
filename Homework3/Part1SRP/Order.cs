namespace hw3part1.Model //refactor to comply with SRP
{
    public class Order
    {
        public void Checkout(Cart cart, PaymentDetails paymentDetails, bool notifyCustomer)
        {
            CheckoutCharge.CardPay(cart, paymentDetails);

            InvReserve.Reserve(cart);

            CustNotify.IfNotify(cart, notifyCustomer);
        }
    }
}
