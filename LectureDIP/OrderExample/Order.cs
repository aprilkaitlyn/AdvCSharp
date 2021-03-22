using System;
using System.Net.Mail;
namespace DIPLecture2
{
    public class Order
    {
        public interface INotifyCustomer
        {
            void NotifyCustomer(Cart cart);
        }

        class NotifyCustomerService : INotifyCustomer
        {
            public void NotifyCustomer(Cart cart)
            {
                throw new NotImplementedException(); //I DO NOT KNOW WHAT IS SUPPOSED TO GO HERE!!!!!!!
            }
        }

        public interface IReserveInventory
        {
            void ReserveInventory(Cart cart);
        }

        class ReserveInventoryService : IReserveInventory
        {
            public void ReserveInventory(Cart cart)
            {
                foreach (OrderItem item in cart.Items)
                {
                    try
                    {
                        var inventorySystem = new InventorySystem();
                        inventorySystem.Reserve(item.Sku, item.Quantity);
                    }
                    catch (InsufficientInventoryException ex)
                    {
                        throw new OrderException("Insufficient inventory for item " + item.Sku, ex);
                    }
                    catch (Exception ex)
                    {
                        throw new OrderException("Problem reserving inventory", ex);                      
                    }
                }
            }
        }       

        public interface IPaymentProcessor
        {
            void ChargeCard(PaymentDetails paymentDetails, decimal amount);
        }

        class PaymentProcessorService : IPaymentProcessor
        {
            public void ChargeCard(PaymentDetails paymentDetails, decimal amount)
            {
                using (var paymentGateway = new PaymentGateway())
                {
                    try
                    {
                        paymentGateway.Credentials = "accounts credentials";
                        paymentGateway.CardNumber = paymentDetails.CreditCardNumber;
                        paymentGateway.ExpiresMonth = paymentDetails.ExpiresMonth;
                        paymentGateway.ExpiresYear = paymentDetails.ExpiresYear;
                        paymentGateway.NameOnCard = paymentDetails.CardholderName;
                        paymentGateway.AmountToCharge = amount;

                        paymentGateway.Charge();
                    }
                    catch (AvsMismatchException ex)
                    {
                        throw new OrderException("The card gateway rejected the card based on the address", ex);
                    }
                    catch (Exception ex)
                    {
                        throw new OrderException("There was a problem with your card", ex);
                    }
                }
            }
        }

        public class FakePaymentProcessor : IPaymentProcessor
        {
            public decimal amountPassed = 0;
            public bool wasCalled = false;

            public void ChargeCard(PaymentDetails paymentDetails, decimal amount)
            {
                wasCalled = true;
                amountPassed = amount;
            }
        }

        public class FakeNotifyCustomer : INotifyCustomer
        {
            bool wasCalled = false;

            public void NotifyCustomer(Cart cart)
            {
                wasCalled = true;
            }
        }

        public class FakeReserveInventory : IReserveInventory
        {
            public bool wasCalled = false;

            public void ReserveInventory(Cart cart)
            {
                wasCalled = true;
            }
        }

        private readonly Cart _cart; //can do _cart or this.cart
        private readonly PaymentDetails _paymentDetails;
        private readonly INotifyCustomer _notifyCustomer;
        private readonly IReserveInventory _reserveInventory;
        private readonly IPaymentProcessor _paymentProcessor;

        public Order(Cart cart, PaymentDetails paymentDetails, INotifyCustomer notifyCustomer ,IReserveInventory reserveInventory, IPaymentProcessor paymentProcessor)
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
                ChargeCard(_paymentDetails, _cart);
            }

            _reserveInventory.ReserveInventory(_cart);

            if (notifyCustomer)
            {
                _notifyCustomer.NotifyCustomer(_cart);
            }
        }

        public void NotifyCustomer(Cart cart)
        {
            string customerEmail = cart.CustomerEmail;
            if (!String.IsNullOrEmpty(customerEmail))
            {
                using (var message = new MailMessage("orders@somewhere.com", customerEmail))
                using (var client = new SmtpClient("localhost"))
                {
                    message.Subject = "Your order placed on " + DateTime.Now.ToString();
                    message.Body = "Your order details: \n " + cart.ToString();

                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Problem sending notification email", ex);
                    }
                }
            }
        }

        public void ReserveInventory(Cart cart)
        {
            foreach (var item in cart.Items)
            {
                try
                {
                    var inventorySystem = new InventorySystem();
                    inventorySystem.Reserve(item.Sku, item.Quantity);

                }
                catch (InsufficientInventoryException ex)
                {
                    throw new OrderException("Insufficient inventory for item " + item.Sku, ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("Problem reserving inventory", ex);
                }
            }
        }

        public void ChargeCard(PaymentDetails paymentDetails, Cart cart)
        {
            using (var paymentGateway = new PaymentGateway())
            {
                try
                {
                    paymentGateway.Credentials = "account credentials";
                    paymentGateway.CardNumber = paymentDetails.CreditCardNumber;
                    paymentGateway.ExpiresMonth = paymentDetails.ExpiresMonth;
                    paymentGateway.ExpiresYear = paymentDetails.ExpiresYear;
                    paymentGateway.NameOnCard = paymentDetails.CardholderName;
                    paymentGateway.AmountToCharge = cart.TotalAmount;

                    paymentGateway.Charge();
                }
                catch (AvsMismatchException ex)
                {
                    throw new OrderException("The card gateway rejected the card based on the address provided.", ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("There was a problem with your card.", ex);
                }
            }
        }
    }
}

public class OrderException : Exception
{
    public OrderException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
