using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgs_Example
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
        
        public event EventHandler<EvtArgsClass> evt;

        public void CheckBalance(int x)
        {
            // To pass EventArgs, we need to create a class that inherits from EventArgs
            if (x > 250)
            {
                EvtArgsClass eac = new EvtArgsClass("Balance exceeds 250...");
                
                evt(this, eac);
            }                
        }
    }


    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EvtArgsClass e)
        {
            Console.WriteLine("ATTENTION! from " + sender + ": " + e.Message);
        }
    }

    
    public class EvtArgsClass:EventArgs
    {
        // Constructor accepts message when an 
        // EvtArgsClass object is instantiated
        public EvtArgsClass(string str)
        {
           msg = str;
        }

        private string msg;
        public string Message
        {
            get { return msg; }
        }
    }
}
