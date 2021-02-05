using System;
using System.IO; //imported for fileExists

//this is the class library

namespace UnitTestDemo
{
    public class FileProcess
    {
        public bool fileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("filename"); //will throw exception if filename is null
            }
            return File.Exists(fileName);
        }
    }
}
