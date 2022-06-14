using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace EventViewer
{
    class Program
    {
        static public void Main()
        {
            EventLog log = new EventLog();
            log.Log = "System";
            log.Source = "EventLog";
            EventLogEntryCollection entries = log.Entries;
            List<EventLogEntry> eventsIO = new List<EventLogEntry>();

            foreach (EventLogEntry entry in entries)
            {
                if (entry.EventID == 6005 || entry.EventID == 6006)
                {
                    eventsIO.Add(entry);
                }
            }

            for (int i = eventsIO.Count - 10; i < eventsIO.Count; i++)
            {
                EventLogEntry e = eventsIO[i];
                string io = e.EventID == 6005 ? "起動\t:" : "終了\t:";
                Console.WriteLine(io + e.TimeWritten.ToString("yyyy/MM/dd HH:mm:ss"));
            }

            while (true)
            {
                Thread.Sleep(250);
            }
        }
    }
}