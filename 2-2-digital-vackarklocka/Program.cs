using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {
        static void Main(string[] args) 
        {
            //test 1
            ViewTestHeader("");

            //test 2
            ViewTestHeader("");

            //test 3
            ViewTestHeader("");

            //test 4
            ViewTestHeader("");

            //test 5
            ViewTestHeader("");

            //test 6
            ViewTestHeader("");

        }
        private static void Run(AlarmClock ac, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------¬");
            Console.WriteLine("                                         ");
            Console.WriteLine("         Väckarklockan URLED <TM>        ");
            Console.WriteLine("        Modellnummer: 1DV402S2L2A       " );
            Console.WriteLine("                                         ");
            Console.WriteLine("----------------------------------------¬");
            Console.ResetColor();

            for (int i = 0; i < minutes; i++) 
            {
                if (ac.TickTock()) 
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("{0} BEEP! BEEP! BEEP! BEEP!", ac);
                    Console.ResetColor();
                }
                else 
                {
                    Console.WriteLine(ac);
                }
            }
        }
        private static void ViewErrorMessage(string message)
        {
            //felmeddelande skrivs ut
        }
        private static void ViewTestHeader(string header) 
        {
            
        }
    }
}
