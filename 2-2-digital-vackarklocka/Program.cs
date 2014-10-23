using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {
        private static void Run(AlarmClock ac, int minutes)
        {
            int i = 0;
            while (i < minutes) 
            {
                ac.TickTock();
                i++;
                Console.Writeline(ac.ToString());
            }
            
        }
        private static void ViewErrorMessage(string message)
        {

        }
        private static void ViewTestHeader(string header) 
        {
            
        }
    }
}
