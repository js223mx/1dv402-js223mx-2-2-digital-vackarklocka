﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class Program
    {        
        public static void Main(string[] args) 
        {
            //test 1
            ViewTestHeader("Test 1. \nTest av standardkonstruktorn?\n");
            AlarmClock myTestClock1 = new AlarmClock();
            Console.WriteLine(myTestClock1.ToString());

            //test 2
            ViewTestHeader("Test 2. \nTest av konstruktorn med två parametrar, <9, 42>\n");
            AlarmClock myTestClock2 = new AlarmClock(9, 42);
            Console.WriteLine(myTestClock2.ToString());

            //test 3
            ViewTestHeader("Test 3. \nTest av konstruktorn med fyra parametrar, <13, 24, 7, 35>\n");
            AlarmClock myTestClock3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(myTestClock3.ToString());

            //test 4
            ViewTestHeader("Test 4. \nStäller befintlig AlarmClock-object till 23:58 och låter den gå 13 minuter.\n");
            myTestClock3.Hour = 23;
            myTestClock3.Minute = 58;
            Run(myTestClock3, 13);

            //test 5
            ViewTestHeader("\nTest 5. \nStäller befintlig AlarmClock-object till tiden 6:12 och alarmtiden till 6:15 och låter den gå 6 minuter\n");
            myTestClock3.Hour = 6;
            myTestClock3.Minute = 12;
            myTestClock3.AlarmHour = 6;
            myTestClock3.AlarmMinute = 15;
            Run(myTestClock3, 6);

            //test 6
            ViewTestHeader("\nTest 6. \nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden\n");

            try 
            {
                myTestClock3.Hour = 24;
            }
            catch (Exception ex)
            {
                ViewErrorMessage(ex.Message);
            }
            try 
            {
                myTestClock3.Minute = 60;
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }
            try
            {
                myTestClock3.AlarmHour = 24;
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }
            try 
            {
                myTestClock3.AlarmMinute = 60;
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }


            //test7
            ViewTestHeader("Test 7. \nTestar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden\n");

            try 
            {
                AlarmClock myTestClock4 = new AlarmClock(24, 0);
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }
            try 
            {
                AlarmClock myTestClock5 = new AlarmClock(0, 60);
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }
            try 
            {
                AlarmClock myTestClock6 = new AlarmClock(0, 0, 24, 0);
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }
            try 
            {
                AlarmClock myTestClock7 = new AlarmClock(0, 0, 0, 60);
            }
            catch (Exception ex) 
            {
                ViewErrorMessage(ex.Message);
            }
        }
        private static void Run(AlarmClock ac, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------¬");
            Console.WriteLine("                                         ");
            Console.WriteLine("         Väckarklockan URLED <TM>        ");
            Console.WriteLine("        Modellnummer: 1DV402S2L2A        ");
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
        private static void ViewErrorMessage(string errormessage)
        {
            //felmeddelande skrivs ut
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(errormessage);
            Console.ResetColor();
        }

        //metod som tar en sträng som argument och presenterar den
        private static void ViewTestHeader(string header) 
        {
            Console.WriteLine(header);
        }
    }
}
