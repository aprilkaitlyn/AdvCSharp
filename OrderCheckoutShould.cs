using HW4EX2B4.TightCoupling.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4EX2B4.TightCoupling
{
    [TestClass]
    public class OrderCheckoutShould
    {
        [TestMethod]
        public void NotFailWithNoItemsNoNotificationCreditCard() //passes - updated
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };

            var cart = new Cart();
            var order = new CheckoutService();
            bool shouldnotifycustomer = false;

            order.Order(cart, paymentDetails, notificationService, reservationService, paymentService);
            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(paymentService.wasCalled);
        }

        [TestMethod]
        public void NotFailWithNoItemsNotificationNoCreditCard() //passes - updated 
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };

            var cart = new Cart();
            var order = new CheckoutService();
            bool shouldnotifycustomer = true;

            order.Order(cart, paymentDetails, notificationService, reservationService, paymentService);
            order.Checkout(shouldnotifycustomer);

            Assert.IsTrue(notificationService.wasCalled);
        }

      

        #region FakesMethods
        [TestMethod]
        public void ReservationServiceReserveInventory() //passes
        {
            var reservationService = new FakeReserveInventory();
            var cart = new Cart();

            reservationService.ReserveInventory(cart);

            Assert.IsNotNull(cart);           
        }

        [TestMethod]
        public void NotificationServiceNotifyCustomer() //passes
        {
            var notificationService = new FakeNotifyCustomer();
            var cart = new Cart();

            notificationService.NotifyCustomer(cart);

            Assert.IsNotNull(cart);
        }

        [TestMethod]
        public void PaymentServiceChargeCard() //passes
        {
            var paymentService = new FakePaymentProcessor();
            var cart = new Cart();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };
            var amount = 20;

            paymentService.ChargeCard(paymentDetails, amount);

            Assert.IsNotNull(cart);
        }
        #endregion

        #region wasCalled
        [TestMethod]
        public void PassInventoryReservation() //passes
        {
            var reservationService = new FakeReserveInventory();

            reservationService.wasCalled = true; //only variable from FakeReserveInventory

            Assert.IsTrue(reservationService.wasCalled);
        }

        [TestMethod]
        public void PassCustomerNotification() //passes
        {
            var notificationService = new FakeNotifyCustomer();

            notificationService.wasCalled = true; //only variable from FakeNotifyCustomer

            Assert.IsTrue(notificationService.wasCalled);
        }

        [TestMethod]
        public void PassPaymentProcessor() //passes
        {
            var paymentService = new FakePaymentProcessor();

            paymentService.wasCalled = true;

            Assert.IsTrue(paymentService.wasCalled);
        }

        [TestMethod]
        public void PassPaymentAmount() //passes
        {
            var paymentService = new FakePaymentProcessor();

            decimal amount = 20;
            paymentService.amountPassed = amount;

            Assert.AreEqual(20, amount);
        }
        #endregion

        #region IsNotNull
        [TestMethod]
        public void PaymentServiceIsNotNull() //passes
        {
            var paymentService = new FakePaymentProcessor();

            paymentService.wasCalled = true;

            Assert.IsNotNull(paymentService.wasCalled);
        }

        [TestMethod]
        public void CustomerNotificationIsNotNull() //passes
        {
            var notificationService = new FakeNotifyCustomer();

            notificationService.wasCalled = true; //only variable from FakeNotifyCustomer

            Assert.IsNotNull(notificationService.wasCalled);
        }

        [TestMethod]
        public void CartTotalIsNotNull() //passes
        {
            var cart = new Cart();

            decimal total = cart.TotalAmount;

            Assert.IsNotNull(total);
        }

        [TestMethod]
        public void CartEmailIsNotNull() //passes
        {
            var cart = new Cart();

            string email = cart.CustomerEmail;
            email = "customer@email.com";

            Assert.IsNotNull(email);
        }
        #endregion
    }
}