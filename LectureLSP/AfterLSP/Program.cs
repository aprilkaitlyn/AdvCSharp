using System;
namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileReader fileReader = new AdminDataFileUserFixed();
            fileReader.ReadFile("newfile.txt");

            IFileWriter fileWriter = new AdminDataFileUserFixed();
            fileWriter.WriteFile("newfile.txt");

            IFileReader fileReader2 = new RegularDataFileUserFixed();
            fileReader2.ReadFile("newfile.txt");
        }
    }

    public interface IFileReader
    {
        void ReadFile(string filePath);
    }

    public interface IFileWriter
    {
        void WriteFile(string filePath);
    }

    public class AdminDataFileUserFixed : IFileReader, IFileWriter //classes can inherit from only one class, but from multiple interfaces
    {
        public void ReadFile(string filePath)
        {
            Console.WriteLine($"File {filePath} has been read");
        }

        public void WriteFile(string filePath)
        {
            Console.WriteLine($"File {filePath} has been written");
        }
    }

    public class RegularDataFileUserFixed : IFileReader //only inherit the interface we needed
    {
        public void ReadFile(string filePath)
        {
            Console.WriteLine($"File {filePath} has been read");
        }
    }
}
