using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//To demonstrate why we need DI. To create loosely coupled classes
namespace DemoInterfaces
{
    class EventLogWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
            //Write to event log here
        }
    }

    class AppPoolWatcher
    {
        // Handle to EventLog writer to write to the logs
        EventLogWriter writer = null;

        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (writer == null)
            {
                writer = new EventLogWriter();
            }
            writer.Write(message);
        }
    }


    class DIPDemo
    {
        public static void Main(string[] args)
        {
            AppPoolWatcher obj = new AppPoolWatcher();
            obj.Notify("Register Event");
            Console.ReadLine();
        }

    }
}
