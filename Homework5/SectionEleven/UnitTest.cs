using AsyncBreakfast;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AsyncUnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public async Task FryEggsAsync() //doesnt run without assert
        {
            await FryEggsAsync();
        }

        [TestMethod]
        public async Task FryBaconAsync() //
        {
            await FryBaconAsync();

        }

        [TestMethod]
        public async Task ToastBreadAsync() //
        {
            await ToastBreadAsync();
        }

        [TestMethod]
        public async Task MakeToastWithButterAndJamAsync() //
        {
            await MakeToastWithButterAndJamAsync();
        }

        //attempting to compare what is written to the console to what should be written
        [TestMethod]
        public void AreOJWriteLinesCorrectAttempt()
        {
            string expected = "Pouring orange juice";

            Program.PourOJ();

            var actual = Console.ReadLine();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreJamWriteLinesCorrectAttempt()
        {
            string expected = "Putting jam on the toast";

            Toast t = new Toast();

            Program.ApplyJam(t);

            var actual = Console.ReadLine();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreButterWriteLinesCorrectAttempt()
        {
            string expected = "Putting butter on the toast";

            Toast t = new Toast();

            Program.ApplyButter(t);

            var actual = Console.ReadLine();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreCoffeeWriteLinesCorrectAttempt()
        {
            string expected = "Pouring coffee";

            Program.PourCoffee();

            var actual = Console.ReadLine();

            Assert.AreEqual(expected, actual);
        }
    }
}
