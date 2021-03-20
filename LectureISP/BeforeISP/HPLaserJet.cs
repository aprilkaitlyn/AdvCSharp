namespace ISPLecture
{
    internal class HPLaserJet : IPrintTasks
    {
        public bool FaxContent(string content)
        {
            System.Console.WriteLine(content);
            System.Console.WriteLine("HP fax done"); return true;
        }

        public bool PhotoCopyContent(string content)
        {
            System.Console.WriteLine(content);
            System.Console.WriteLine("HP photocopy done"); return true;
        }

        public bool PrintContent(string content)
        {
            System.Console.WriteLine(content);
            System.Console.WriteLine("HP print done"); return true;
        }

        public bool PrintDuplexContent(string content)
        {
            System.Console.WriteLine(content);
            System.Console.WriteLine("HP print duplex done"); return true;
        }

        public bool ScanContent(string content)
        {
            System.Console.WriteLine(content);
            System.Console.WriteLine("HP scan done\n"); return true;
        }
    }
}
