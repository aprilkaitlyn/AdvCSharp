using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRP;

namespace SRPUnitTests
{
    [TestClass]
    public class UnitTests
    {
        #region Person class tests
        [TestMethod]
        public void IsFirstNameNotNullTest() //passes
        {
            //ARRANGE
            Person name = new Person();
            name.FirstName = "kaitlyn";
            string first;

            //ACT
            first = name.FirstName;

            //ASSERT
            Assert.IsNotNull(first);
        }
        [TestMethod]
        public void IsLastNameNotNullTest() //passes
        {
            //ARRANGE
            Person name = new Person();
            name.LastName = "heishman";
            string last;

            //ACT
            last = name.LastName;

            //ASSERT
            Assert.IsNotNull(last);
        }
        [TestMethod]
        public void IsFirstNameStringTest() //passes
        {
            //ARRANGE
            Person name = new Person();
            name.FirstName = "kaitlyn";
            string first;

            //ACT
            first = name.FirstName;

            //ASSERT
            Assert.IsInstanceOfType(first, typeof(string));
        }
        [TestMethod]
        public void IsLastNameStringTest() //passes
        {
            //ARRANGE
            Person name = new Person();
            name.LastName = "heishman";
            string last;

            //ACT
            last = name.LastName;

            //ASSERT
            Assert.IsInstanceOfType(last, typeof(string));
        }
        #endregion
    }
}
