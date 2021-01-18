using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_An_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Machine1
    {
        public void Start()
        {
            // add code to start the machine
        }
    }

    public class Machine2
    {
        public void On()
        {
            // add code to start the machine
        }
    }

    public class Machine3
    {
        public void StartUp()
        {
             // add code to start the machine
        }
    }

    interface IControls
    {
        void Start();
        void Stop();
    }
}
