namespace HW4EX2B4.TightCoupling.Model
{  

    public class CheckoutService //all of this moved from Order class
    {
        PaymentDetails _paymentDetails;
        INotifyCustomer _notifyCustomer;
        IReserveInventory _reserveInventory;
        IPaymentProcessor _paymentProcessor;
        Cart _cart;

        public void Order(Cart cart, PaymentDetails paymentDetails, INotifyCustomer notifyCustomer, IReserveInventory reserveInventory, IPaymentProcessor paymentProcessor)
        {
            _cart = cart;
            _paymentDetails = paymentDetails;
            _notifyCustomer = notifyCustomer;
            _reserveInventory = reserveInventory;
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(bool notifyCustomer) 
        {
            if (_paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                _paymentProcessor.ChargeCard(_paymentDetails, _cart.TotalAmount);
            }

            _reserveInventory.ReserveInventory(_cart);

            if (notifyCustomer)
            {
                _notifyCustomer.NotifyCustomer(_cart);
            }
        }
    }
}
