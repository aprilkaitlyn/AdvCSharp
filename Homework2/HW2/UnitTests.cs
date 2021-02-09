using System;
using HW2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW2Tests
{
    [TestClass]
    public class UnitTests
    {
        #region AppointmentTests

        #region Appt Start Tests
        [TestMethod]
        public void IsApptStartNotNullTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            DateTime start;

            //ACT
            start = appt.StartDateTime;

            //ASSERT
            Assert.IsNotNull(start);
        }

        [TestMethod]
        public void IsApptStartDateTimeTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            DateTime start;

            //ACT
            start = appt.StartDateTime;

            //ASSERT
            Assert.IsInstanceOfType(start, typeof(DateTime));
        }
        #endregion

        #region Appt End Tests
        [TestMethod]
        public void IsApptEndNotNullTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            DateTime end;

            //ACT
            end = appt.EndDateTime;

            //ASSERT
            Assert.IsNotNull(end);
        }

        [TestMethod]
        public void IsApptEndDateTimeTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            DateTime end;

            //ACT
            end = appt.EndDateTime;

            //ASSERT
            Assert.IsInstanceOfType(end, typeof(DateTime));
        }
        #endregion

        #region Appt Price Tests
        [TestMethod]
        public void IsApptPriceNotNullTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            double price;

            //ACT
            price = appt.Price;

            //ASSERT
            Assert.IsNotNull(price);
        }

        [TestMethod]
        public void IsApptPriceDoubleTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            double price;

            //ACT
            price = appt.Price;

            //ASSERT
            Assert.IsInstanceOfType(price, typeof(double));
        }
        #endregion

        #region Appt Name Tests
        [TestMethod]
        public void IsApptNameNotNullTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            appt.Name = "Kaitlyn";
            string name;

            //ACT
            name = appt.Name;

            //ASSERT
            Assert.IsNotNull(name);
        }

        [TestMethod]
        public void IsApptNameStringTest() //passes
        {
            //ARRANGE
            Appointment appt = new Appointment();
            appt.Name = "Kaitlyn";
            string name;

            //ACT
            name = appt.Name;

            //ASSERT
            Assert.IsInstanceOfType(name, typeof(string));
        }
        #endregion // //FAILS
        #endregion

        #region Book Tests

        #region Book Title Tests
        [TestMethod]
        public void IsTitleNotNullTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            book.Title = "book";
            string title;

            //APPLY
            title = book.Title;

            //ASSERT
            Assert.IsNotNull(title);
        }

        [TestMethod]
        public void IsTitleStringTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            book.Title = "book";
            string title;

            //APPLY
            title = book.Title;

            //ASSERT
            Assert.IsInstanceOfType(title, typeof(string));
        }
        #endregion

        #region Book Price Tests
        [TestMethod]
        public void IsPriceNotNullTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            double price;

            //APPLY
            price = book.Price;

            //ASSERT
            Assert.IsNotNull(price);
        }

        [TestMethod]
        public void IsPriceDoubleTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            double price;

            //APPLY
            price = book.Price;

            //ASSERT
            Assert.IsInstanceOfType(price,typeof(double));
        }
        #endregion

        #region Book Tax Tests
        [TestMethod]
        public void IsTaxNotNullTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            double tax;

            //APPLY
            tax = book.TaxRate;

            //ASSERT
            Assert.IsNotNull(tax);
        }

        [TestMethod]
        public void IsTaxDoubleTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            double tax;

            //APPLY
            tax = book.TaxRate;

            //ASSERT
            Assert.IsInstanceOfType(tax, typeof(double));
        }
        #endregion

        #region Book Ship Tests
        [TestMethod]
        public void IsShippingNotNullTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            double ship;

            //APPLY
            ship = book.ShippingRate;

            //ASSERT
            Assert.IsNotNull(ship);
        }

        [TestMethod]
        public void IsShippingDoubleTest() //passes
        {
            //ARRANGE
            Book book = new Book();
            double ship;

            //APPLY
            ship = book.ShippingRate;

            //ASSERT
            Assert.IsInstanceOfType(ship, typeof(double));
        }
        #endregion
        #endregion

        #region TshirtTests

        #region Tshirt Size Tests
        [TestMethod]
        public void IsTSizeNotNullTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            tee.Size = "small";
            string size;

            //APPLY
            size = tee.Size;

            //ASSERT
            Assert.IsNotNull(size);
        }

        [TestMethod]
        public void IsTSizeStringTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            tee.Size = "small";
            string size;

            //APPLY
            size = tee.Size;

            //ASSERT
            Assert.IsInstanceOfType(size, typeof(string));
        }
        #endregion

        #region Tshirt Price Tests
        [TestMethod]
        public void IsTPriceNotNullTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            double price;

            //APPLY
            price = tee.Price;

            //ASSERT
            Assert.IsNotNull(price);
        }

        [TestMethod]
        public void IsTPriceDoubleTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            double price;

            //APPLY
            price = tee.Price;

            //ASSERT
            Assert.IsInstanceOfType(price, typeof(double));
        }
        #endregion

        #region Tshirt Tax Tests
        [TestMethod]
        public void IsTTaxNotNullTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            double tax;

            //APPLY
            tax = tee.TaxRate;

            //ASSERT
            Assert.IsNotNull(tax);
        }

        [TestMethod]
        public void IsTTaxDoubleTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            double tax;

            //APPLY
            tax = tee.TaxRate;

            //ASSERT
            Assert.IsInstanceOfType(tax, typeof(double));
        }
        #endregion

        #region Tshirt Ship Tests
        [TestMethod]
        public void IsTShippingNotNullTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            double ship;

            //APPLY
            ship = tee.ShippingRate;

            //ASSERT
            Assert.IsNotNull(ship);
        }

        [TestMethod]
        public void IsTShippingDoubleTest() //passes
        {
            //ARRANGE
            TShirt tee = new TShirt();
            double ship;

            //APPLY
            ship = tee.ShippingRate;

            //ASSERT
            Assert.IsInstanceOfType(ship, typeof(double));
        }
        #endregion

        #endregion

        #region SnackTests
        [TestMethod]
        public void IsSnackNotNullTest() //passes
        {
            //ARRANGE
            Snack snack = new Snack();
            double price;

            //ACT
            price = snack.Price;

            //ASSERT
            Assert.IsNotNull(price);
        }

        [TestMethod]
        public void IsSnackPriceDoubleTest() //passes
        {
            //ARRANGE
            Snack snack = new Snack();
            double price;

            //ACT
            price = snack.Price;

            //ASSERT
            Assert.IsInstanceOfType(price, typeof(double));
        }
        #endregion
    }
}
