using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            // Instantiate an event subscriber object
            EvtSubscriber es = new EvtSubscriber();

            // Subscribe to the ep.evt event by making the es.HandleTheEvent method
            // a target of the ep.evt delegate
            ep.evt += es.HandleTheEvent;

            // Call the CheckBalance method on the ep object
            // it will invoke the ep.evt delegate if the balance is over 250
            ep.CheckBalance(251);
        }
    }

    public class EvtPublisher
    {
        // Create a delegate that our event will use to
        // point to method that will handle our event
       // public delegate void del(string x);

        // Create an event that uses the del delegate we just created
        // Note that our event can point to any method
        // that returns void and expects a string parameter
        //public event del evt;

        // Let's use the standard .NET event handler
        public EventHandler evt;  

        public void CheckBalance(int x)
        {
            if (x > 250)
                // Let's raise the event by calling the delegate
                // it will execute all methods that have been subscribed to it
                // evt("ATTENION! The curren balance is over 250...");

                // The EVENTHANDLER will expect an EventArgs value
                evt(this, EventArgs.Empty);
        }

    }


    public class EvtSubscriber
    {
        // We'll have to change this to match the new delegate call
        // public void HandleTheEvent(string a)
        public void HandleTheEvent(object sender, EventArgs e)
        {
            Console.WriteLine("ATTENTION! " + sender + " is advising that the balance is over 250...");
        }

    }
}
