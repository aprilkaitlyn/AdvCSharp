using System;

namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Log to console: {msg}");
        }
    }
}
