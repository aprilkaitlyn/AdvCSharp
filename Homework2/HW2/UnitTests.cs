using System;
using System.Collections.Generic;
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
        #endregion 
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

        #region Book Method Return Tests
        [TestMethod]
        public void DoesBookShipReturnShipRateTest() //passes
        {
            //ARRANGE
            Book b = new Book();
            double ship1;
            double ship2;

            //ACT
            ship1 = b.Ship();
            ship2 = b.ShippingRate;

            //ASSERT
            Assert.AreEqual(ship1, ship2); //this tests that the Ship() method returns the ShippingRate      
        }

        [TestMethod]
        public void DoesBookTaxReturnTaxRateTest() //passes
        {
            //ARRANGE
            Book b = new Book();
            double tax1;
            double tax2;

            //ACT
            tax1 = b.Tax();
            tax2 = b.TaxRate;

            //ASSERT
            Assert.AreEqual(tax1, tax2); //this tests that the Tax() method returns the TaxRate
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

        #region Method Return Tests
        [TestMethod]
        public void DoesTeeShipReturnShipRateTest() //passes
        {
            //ARRANGE
            TShirt t = new TShirt();
            double ship1;
            double ship2;

            //ACT
            ship1 = t.Ship();
            ship2 = t.ShippingRate;

            //ASSERT
            Assert.AreEqual(ship1, ship2); //this tests that the Ship() method returns the ShippingRate      
        }

        [TestMethod]
        public void DoesTeeTaxReturnTaxRateTest() //passes
        {
            //ARRANGE
            TShirt t = new TShirt();
            double tax1;
            double tax2;

            //ACT
            tax1 = t.Tax();
            tax2 = t.TaxRate;

            //ASSERT
            Assert.AreEqual(tax1, tax2); //this tests that the Tax() method returns the TaxRate
        }
        #endregion

        #endregion

        #region Snack Tests
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

        #region Interface List Tests
        [TestMethod]
        public void IShippableListTests() //passes
        { 
            //ARRANGE
            List<IShippable> shipList = new List<IShippable>();

            //ACT
            shipList.Add(new TShirt {Price = 10, ShippingRate = 1, Size = "small", TaxRate = 0.06D});
            shipList.Add(new Book { Price = 20, ShippingRate = 2, Title = "book", TaxRate = 0.06D });

            //ASSERT
            CollectionAssert.AllItemsAreInstancesOfType(shipList, typeof(IShippable));
        }

        [TestMethod]
        public void ITaxableListTests() //passes
        {
            //ARRANGE
            List<ITaxable> taxList = new List<ITaxable>();

            //ACT
            taxList.Add(new TShirt { Price = 10, ShippingRate = 1, Size = "small", TaxRate = 0.06D });
            taxList.Add(new Book { Price = 20, ShippingRate = 2, Title = "book", TaxRate = 0.06D });

            //ASSERT
            CollectionAssert.AllItemsAreInstancesOfType(taxList, typeof(ITaxable));
        }

        [TestMethod]
        public void IPurchaseableListTests() //passes
        {
            //ARRANGE
            List<IPurchasable> purchaseList = new List<IPurchasable>();

            //ACT
            purchaseList.Add(new TShirt { Price = 10, ShippingRate = 1, Size = "small", TaxRate = 0.06D });
            purchaseList.Add(new Book { Price = 20, ShippingRate = 2, Title = "book", TaxRate = 0.06D });
            purchaseList.Add(new Appointment { Price = 20, Name = "name", EndDateTime = DateTime.Now, StartDateTime = DateTime.Now });
            purchaseList.Add(new Snack { Price = 1 });

            //ASSERT
            CollectionAssert.AllItemsAreInstancesOfType(purchaseList, typeof(IPurchasable));
        }
        #endregion

        #region Formula Test
        [TestMethod]
        public void GrandTotalCalculationTest() //passes
        {
            //ARRANGE
            double shipAmount = 2;
            double taxAmount = 2.50;
            double total = 30;
            double grandTotal;

            //ACT
            grandTotal = Program.GrandTotal(shipAmount, taxAmount, total);

            //ASSERT
            Assert.AreEqual(34.50, grandTotal);
        }
        #endregion
    }
}
