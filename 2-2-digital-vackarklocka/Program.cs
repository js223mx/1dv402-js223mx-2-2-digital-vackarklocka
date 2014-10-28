using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {
        static string HorizontalLine = "================================================================";
        public static void Main(string[] args) 
        {
            //test 1
            ViewTestHeader("Test 1.\n Test av standardkonstruktorn");
            AlarmClock myTestClock1 = new AlarmClock();
            Console.WriteLine(myTestClock1.ToString());

            //test 2
            ViewTestHeader("Test 2.\n Test av konstruktorn med två parametrar, <9, 42>");
            AlarmClock myTestClock2 = new AlarmClock(9, 42);
            Console.WriteLine(myTestClock2.ToString());

            //test 3
            ViewTestHeader("Test 3.\n Test av konstruktorn med fyra parametrar, <13, 24, 7, 35>");
            AlarmClock myTestClock3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(myTestClock3.ToString());

            //test 4
            ViewTestHeader("Test 4. \n Ställer befintlig AlarmClock-object till 23:58 och låter den gå 13 minuter.");
            myTestClock3.Hour = 23;
            myTestClock3.Minute = 58;
            Run(myTestClock3, 13);

            //test 5
            ViewTestHeader("Test 5. \n Ställer befintlig AlarmClock-object till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter");
            myTestClock3.Hour = 6;
            myTestClock3.Minute = 12;
            myTestClock3.AlarmHour = 6;
            myTestClock3.AlarmMinute = 15;
            Run(myTestClock3, 6);

            //test 6
            ViewTestHeader("Test 6.\n Testar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");

            try 
            {
                myTestClock3.Hour = 24;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen är inte i intervallet mellan 0-23.");
            }
            try 
            {
                myTestClock3.Minute = 60;
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Minuterna är inte i intervallet mellan 0-59.");
            }
            try
            {
                myTestClock3.AlarmHour = 24;
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallet mellan 0-23.");
            }
            try 
            {
                myTestClock3.AlarmMinute = 60;
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Alarmminuten är inte i intervallet mellan 0-59.");
            }


            //test7
            ViewTestHeader("Test 7.\n Testar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");

            try 
            {
                AlarmClock myTestClock4 = new AlarmClock(24, 0);
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23.");
            }
            try 
            {
                AlarmClock myTestClock5 = new AlarmClock(0, 60);
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Minuten är inte i intervallet 0-59.");
            }
            try 
            {
                AlarmClock myTestClock6 = new AlarmClock(0, 0, 24, 0);
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallen 0-23.");
            }
            try 
            {
                AlarmClock myTestClock7 = new AlarmClock(0, 0, 0, 60);
            }
            catch (ArgumentException) 
            {
                ViewErrorMessage("Alarmminuten är inte i intervallet 0-59.");
            }
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static void ViewTestHeader(string header) 
        {
            Console.WriteLine(header);
        }
    }
}
