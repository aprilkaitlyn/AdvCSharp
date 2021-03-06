using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw3part1.Model;


namespace hw3part1.Tests
{
    [TestClass]
    public class UnitTest
    {
        #region PaymentDetails tests
        [TestMethod]
        public void IsCardNumNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.CreditCardNumber = "12341234234";
            string num;

            //ACT
            num = pay.CreditCardNumber;

            //ASSERT
            Assert.IsNotNull(num);
        }

        [TestMethod]
        public void IsCardNameNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.CardholderName = "name";
            string name;

            //ACT
            name = pay.CardholderName;

            //ASSERT
            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void IsCardMonthNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.ExpiresMonth = "07";
            string month;

            //ACT
            month = pay.ExpiresMonth;

            //ASSERT
            Assert.IsNotNull(month);
        }

        [TestMethod]
        public void IsCardYearNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.ExpiresYear = "2022";
            string year;

            //ACT
            year = pay.ExpiresYear;

            //ASSERT
            Assert.IsNotNull(year);
        }

        [TestMethod]
        public void IsPayMethodNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();

            //ACT
            PaymentMethod PaymentDetails = pay.PaymentMethod;

            //ASSERT
            Assert.IsNotNull(pay);
        }

        [TestMethod]
        public void IsPayCashNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();

            //ACT
            PaymentMethod PaymentDetails = PaymentMethod.Cash;

            //ASSERT
            Assert.IsNotNull(pay);
        }

        [TestMethod]
        public void IsPayCardNotNullTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();

            //ACT
            PaymentMethod PaymentDetails = PaymentMethod.CreditCard;

            //ASSERT
            Assert.IsNotNull(pay);
        }

        [TestMethod]
        public void IsCardNumStringTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.CreditCardNumber = "12341234234";
            string num;

            //ACT
            num = pay.CreditCardNumber;

            //ASSERT
            Assert.IsInstanceOfType(num, typeof(string));
        }

        [TestMethod]
        public void IsCardNameStringTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.CardholderName = "name";
            string name;

            //ACT
            name = pay.CardholderName;

            //ASSERT
            Assert.IsInstanceOfType(name, typeof(string));
        }

        [TestMethod]
        public void IsCardMonthStringTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.ExpiresMonth = "07";
            string month;

            //ACT
            month = pay.ExpiresMonth;

            //ASSERT
            Assert.IsInstanceOfType(month, typeof(string));
        }

        [TestMethod]
        public void IsCardYearStringTest() //passes
        {
            //ARRANGE
            PaymentDetails pay = new PaymentDetails();
            pay.ExpiresYear = "2022";
            string year;

            //ACT
            year = pay.ExpiresYear;

            //ASSERT
            Assert.IsInstanceOfType(year, typeof(string));
        }
        #endregion

        #region Cart tests
        [TestMethod]
        public void IsCartTotalNotNullTest() //passes
        {
            //ARRANGE

            Cart c = new Cart();
            decimal total;

            //ACT
            total = c.TotalAmount;

            //ASSERT
            Assert.IsNotNull(total);
        }

        [TestMethod]
        public void IsCartTotalDecimalTest() //passes
        {
            //ARRANGE

            Cart c = new Cart();
            decimal total;

            //ACT
            total = c.TotalAmount;

            //ASSERT
            Assert.IsInstanceOfType(total, typeof(decimal));
        }

        [TestMethod]
        public void IsCustEmailNotNullTest() //passes
        {
            //ARRANGE
            Cart c = new Cart();
            c.CustomerEmail = "email@email.com";
            string email;

            //ACT
            email = c.CustomerEmail;

            //ASSERT
            Assert.IsNotNull(email);
        }

        [TestMethod]
        public void IsCustEmailStringTest() //passes
        {
            //ARRANGE
            Cart c = new Cart();
            c.CustomerEmail = "email@email.com";
            string email;

            //ACT
            email = c.CustomerEmail;

            //ASSERT
            Assert.IsInstanceOfType(email, typeof(string));
        }

        [TestMethod]
        public void IsSKUNotNullTest() //passes
        {
            //ARRANGE
            OrderItem o = new OrderItem();
            o.Sku = "1234567890";
            string sku;

            //ACT
            sku = o.Sku;

            //ASSERT
            Assert.IsNotNull(sku);
        }

        [TestMethod]
        public void IsSKUStringTest() //passes
        {
            //ARRANGE
            OrderItem o = new OrderItem();
            o.Sku = "1234567890";
            string sku;

            //ACT
            sku = o.Sku;

            //ASSERT
            Assert.IsInstanceOfType(sku, typeof(string));
        }

        [TestMethod]
        public void IsQtyNotNullTest() //passes
        {
            //ARRANGE
            OrderItem o = new OrderItem();
            int qty;

            //ACT
            qty = o.Quantity;

            //ASSERT
            Assert.IsNotNull(qty);
        }

        [TestMethod]
        public void IsQtyIntTest() //passes
        {
            //ARRANGE
            OrderItem o = new OrderItem();
            int qty;

            //ACT
            qty = o.Quantity;

            //ASSERT
            Assert.IsInstanceOfType(qty, typeof(int));
        }
        #endregion
    }
}
