using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.PersonClasses;

namespace UnitTestDemo.Test
{
    [TestClass]
    public class CollectionAssertClassTests
    {
        [TestMethod]
        public void AreCollectionsEqualFailsBecauseNoComparerTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Kaitlyn", LastName = "Heishman" });
            peopleExpected.Add(new Person() { FirstName = "Christina", LastName = "Deken" });
            peopleExpected.Add(new Person() { FirstName = "Kylee", LastName = "Bee" });

            peopleActual = mgr.GetPeople();

            CollectionAssert.AreNotEqual(peopleExpected, peopleActual);
            //these are not equal since we created the people in our test and in the PersonManager class
            //so yes they are the same people..but they are not the same *objects*
        }

        [TestMethod]
        public void AreCollectionsEqualTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetPeople();
            peopleExpected = peopleActual; //setting expected equal to actual, so yes they refer to the same objects

            CollectionAssert.AreEqual(peopleExpected, peopleActual);

        }

        [TestMethod]
        public void AreCollectionsEqualWithComparerTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Kaitlyn", LastName = "Heishman" });
            peopleExpected.Add(new Person() { FirstName = "Christina", LastName = "Deken" });
            peopleExpected.Add(new Person() { FirstName = "Kylee", LastName = "Bee" });

            peopleActual = mgr.GetPeople();

            //creating our own "comparer" to determine equality
            CollectionAssert.AreEqual(peopleExpected, peopleActual,
                    Comparer<Person>.Create((x,y) => x.FirstName == y.FirstName && x.LastName == y.LastName ? 0 : 1));
        }

        [TestMethod]
        public void AreCollectionsEquivalentTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetPeople();

            //add same person to a new collection, but in a different order
            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            //equivalent checks for same objects in any order
            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);
        }

        [TestMethod]
        public void IsCollectionOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = mgr.GetSupervisors();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));
        }
    }
}
