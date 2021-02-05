using System;
using System.Text.RegularExpressions; //added for Regex
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.PersonClasses; //added for PersonManager

namespace UnitTestDemo.Test
{
    [TestClass]
    public class AssertClassTests
    {
        #region AreEqual/AreNotEqual Tests
        [TestMethod]
        public void AreEqualTest()
        {
            string s1 = "Go Bears";
            string s2 = "Go Bears";

            Assert.AreEqual(s1, s2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))] //we are expecting the strings to not have equal cases
        public void AreEqualCaseTest()
        {
            string s1 = "Go Bears";
            string s2 = "go bears";

            Assert.AreEqual(s1, s2, false); //set to true to ignore case sensitivity
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string s1 = "Go Bears";
            string s2 = "Goooo Bears!!";

            Assert.AreNotEqual(s1, s2);
        }
        #endregion

        #region AreSame/AreNotSame Tests
        [TestMethod]
        public void AreSameTest() //are 2 objects the same object?
        {
            FileProcess x = new FileProcess(); //2 references to the same object
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        public void AreNotSameTest() //are 2 objects the same object?
        {
            FileProcess x = new FileProcess(); //2 references to 2 different objects
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }

        #endregion

        #region IsInstanceOfType Tests

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            //ARRANGE
            PersonManager mgr = new PersonManager();
            Person per;

            //ACT
            per = mgr.CreatePerson("Kaitlyn", "Heishman", true);

            //ASSERT
            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }
        #endregion

        #region IsObjectNull Tests

        [TestMethod]
        public void IsNullTest()
        {
            //ARRANGE
            PersonManager mgr = new PersonManager();
            Person per;

            //ACT
            per = mgr.CreatePerson("", "Heishman", true); //first name is null

            //ASSERT
            Assert.IsNull(per);
        }
        #endregion

        #region StringAsserts

        [TestMethod]
        public void ContainsTest()
        {
            string s1 = "go bears";
            string s2 = "bears";

            StringAssert.Contains(s1, s2); //string 1 containts string 2
        }

        [TestMethod]
        public void StartsWithTest()
        {
            string s1 = "All Lower Case";
            string s2 = "All Lower";

            StringAssert.StartsWith(s1, s2);
        }

        [TestMethod]
        public void IsAllLowerCaseTest()
        {
            Regex r = new Regex(@"([^A-Z])+$"); //this is a "regular expression"

            StringAssert.Matches("all lower case", r);
        }

        [TestMethod]
        public void IsNotAllLowerCaseTest()
        {
            Regex r = new Regex(@"([^A-Z])+$"); //this is a "regular expression"

            StringAssert.Matches("All Lower Case", r);
        }
        #endregion
    }
}
