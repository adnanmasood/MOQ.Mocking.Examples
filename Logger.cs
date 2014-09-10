using System;

namespace Avantgarde.Moq.Examples
{
    //internal class Logger
    //{
    //}

    //concrete logging class:
    //public class Log
    //{
    //    public void WriteToLog(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //}

    //We have another classes that uses this Log class to do its logging:
    //public class LogGenerator
    //{
    //    public void Foo()
    //    {
    //        var log = new Log();
    //        log.WriteToLog("my log message");
    //    }
    //}

    //The problem with unit testing the Foo method is that you have no control over the creation of the Log class. 
    //The first step is to apply inversion of control, where the caller gets to decide what instances are used:

    #region refactor

    //public class LogGenerator
    //{
    //    private readonly Log log;

    //    public LogGenerator(Log log)
    //    {
    //        this.log = log;
    //    }

    //    public void Foo()
    //    {
    //        log.WriteToLog("my log message");
    //    }
    //}

    #endregion refactor

    // Now we are one step closer to successfully unit testing as our unit test can choose which Log instance to do the logging with. 
    // The last step now is to make the Log class mockable, which we could do by adding an interface ILog that is implemented by Log 
    // and have LogGenerator depend on that interface:

    #region Refactor2Mock

    public interface ILog
    {
        void WriteToLog(string message);
    }

    public class Log : ILog
    {
        public void WriteToLog(string message)
        {
            Console.WriteLine("Write to Console");
        }
    }

    public class LogToDatabase : ILog
    {
        public void WriteToLog(string message)
        {
            //Write to the database.
        }
    }

    public class LogGenerator
    {
        private readonly ILog log;

        public LogGenerator(ILog log)
        {
            this.log = log;
        }

        public void Foo()
        {
            log.WriteToLog("my log message");
        }
    }

    #endregion
}