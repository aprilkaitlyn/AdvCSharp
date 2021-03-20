namespace ISPLecture
{
    internal class Canon : IPrintTasks
    {
        public bool PhotoCopyContent(string content)
        {
            System.Console.WriteLine("Canon photocopy done"); return true;
        }

        public bool PrintContent(string content)
        {
            System.Console.WriteLine(content); 
            System.Console.WriteLine("Canon print done\n"); return true;
        }

        public bool ScanContent(string content)
        {
            System.Console.WriteLine(content); 
            System.Console.WriteLine("Canon scan done"); return true;
        }

        public bool PrintDuplexContent(string content)
        {
            return false;
        }

        public bool FaxContent(string content)
        {
            return false;
        }
    }
}
