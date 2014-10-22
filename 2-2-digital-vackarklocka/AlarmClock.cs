using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{
    class AlarmClock
    {
        int _alarmHour;
        int _alarmMinute;
        int _hour;
        int _minute;

        //egenskap
        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if(value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _alarmHour = value;
            }
        }

        //egenskap
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value < 0 || value > 59) 
                {
                    throw new ArgumentException();
                }
                _alarmMinute = value;
            }
        }

        //egenskap
        public int Hour
        {
            get { return _hour; }
            set 
            {
                if (value < 0 || value > 23) 
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }

        //egenskap
        public int Minute 
        {
            get { return _minute; }
            set 
            {
                if (value < 0 || value > 59) 
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        //konstruktor
        public AlarmClock()
        {

        }

        //konstruktor
        public AlarmClock(int hour, int minute)
            :this (hour, minute, 0,0)
        {
            
        }

        //konstruktor
        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute) 
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {
            for (int i = 0; i < 59; i++) 
            {

            }
        }
    }
}
