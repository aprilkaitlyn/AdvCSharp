using System;

namespace ISPLecture //clients should not be forced to depend on methods it does not use
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintTasks cp = new Canon();
            IPrintTasks hp = new HPLaserJet();

            cp.PrintContent("Hello from a Canon printer");
            hp.ScanContent("Scanning from an HP");
        }
    }
}
