using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDataFile accessDataFile = new AdminDataFileUser();
            accessDataFile.FilePath = @"c:\temp\a.txt";
            accessDataFile.ReadFile();
            accessDataFile.WriteFile();

            AccessDataFile accessDataFileR = new RegularDataFileUser();
            accessDataFileR.FilePath = @"c:\temp\a.txt";
            accessDataFileR.ReadFile();
            accessDataFileR.WriteFile(); //throws exception
        }
    }

    public class AccessDataFile //not following LSP
    {
        public string FilePath { get; set; }

        public virtual void ReadFile() //virtual for child class overriding
        {
            Console.WriteLine($"Base file {FilePath} has been read");
        }
        public virtual void WriteFile()
        {
            Console.WriteLine($"Base file {FilePath} has been written");
        }
    }

    public class AdminDataFileUser : AccessDataFile
    {
        public override void ReadFile()
        {
            Console.WriteLine($"File (admin) {FilePath} has been read");
        }
        public override void WriteFile()
        {
            Console.WriteLine($"File (admin) {FilePath} has been written");
        }
    }

    public class RegularDataFileUser : AccessDataFile
    {
        public override void ReadFile() 
        {
            Console.WriteLine($"File (reg) {FilePath} has been read");
        }
        public override void WriteFile()
        {
            throw new NotImplementedException();
        }
    }

}
