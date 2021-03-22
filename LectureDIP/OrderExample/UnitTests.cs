using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DIPLecture2.Order;

namespace DIPLecture2.UnitTests
{
    [TestClass]
    public class OrderCheckoutShould
    {
        [TestMethod]
        public void NotFailWithNoItemsNoNotificationNoCreditCard() //THIS DOES NOT PASS LOL
        {
            var reservationService = new FakeReserveInventory();
            var paymentService = new FakePaymentProcessor();
            var notificationService = new FakeNotifyCustomer();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard};

            var cart = new Cart();
            var order = new Order(cart, paymentDetails, notificationService, reservationService, paymentService);

            bool shouldNotifyCustomer = false;

            order.Checkout(shouldNotifyCustomer);

            Assert.IsTrue(paymentService.wasCalled);
        }

    }
}
