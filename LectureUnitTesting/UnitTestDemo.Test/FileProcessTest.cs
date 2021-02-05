using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//this is for testing. Solution >> UnitTestDemo.Test >> Dependencies >> Add >> connect to the class library
//run test command T

namespace UnitTestDemo.Test
{
    [TestClass]

    public class FileProcessTest //make the name meaningful. We are testing FileProcess.cs
    {
        [TestMethod]

        public void FileNameDoesExist() //explain what our unit test is doing!
        {
            //ARRANGE - set up variables & classes
            FileProcess fp = new FileProcess(); //reference to FileProcess class
            bool fromCall;

            //ACT - make things happen
            fromCall = fp.fileExists(@"/Users/bentliver/Downloads/btsdisco.psd");

            //ASSERT
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))] //we know an exception is going to be thrown plz don't crash!

        public void FileNameDoesNotExist() //when we assert something is true, we may also want to assert it is false
        {
            //ARRANGE 
            FileProcess fp = new FileProcess(); //reference to FileProcess class
            bool fromCall;

            //ACT 
            fromCall = fp.fileExists(@""); //null file names will throw an exception

            //ASSERT
            Assert.IsFalse(fromCall);
        }
    }
}
