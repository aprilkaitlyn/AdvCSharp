using System;

namespace ISPLecture //clients should not be forced to depend on methods it does not use
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintScanContent cp = new Canon();
            IPrintScanContent hp = new HP();

            cp.PrintContent("Hello from a Canon printer");
            hp.ScanContent("Scanning from an HP");
        }
    }

    public interface IPrintScanContent //new basic interface, what can most printers do?
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    public interface IFaxContent //not all printers can fax
    {
        bool FaxContent(string content);
    }

    public interface IDuplexContent //not all printers can print double sided
    {
        bool PrintDuplexContent(string content);
    }

    public class Canon : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Canon photocopy done"); return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("Canon print done\n"); return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("Canon scan done"); return true;
        }
    }

    public class HP : IPrintScanContent, IFaxContent, IDuplexContent
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("HP fax done"); return true;
        }

        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("HP photocopy done"); return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("HP print done"); return true;
        }

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("HP print duplex done"); return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine(content);
            Console.WriteLine("HP scan done\n"); return true;
        }
    }
}
