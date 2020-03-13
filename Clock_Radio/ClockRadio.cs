using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Radio
{
    class ClockRadio
    {
        //member variables
        public string time = "0930";
        public string radioStation = "101.5 FM";
        public string alarmIsOn = " ";
        public int alarmIsSetTo = 0800;

        //constructor
        public ClockRadio()
        {
            time = "0930";
            radioStation = "101.5";
            alarmIsOn = " ";
            alarmIsSetTo = 0800;
        }

        //member methods
        public string CurrentTime()
        {
            string result = time;
            return result;
        }

        public string CurentRadioStation()
        {
            string result = radioStation;
            return result;
        }

        public void IsAlarmOn()
        {
            if (time == "0800")
            {
                alarmIsOn = " ";
                Console.WriteLine("Alarm is ringing");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Alarm is not on");
                Console.ReadLine();
            }
        }

        public int CurrentAlarmTime()
        {
            alarmIsSetTo = 0800;
            return alarmIsSetTo;
        }

        public void ChangeTime()
        {
            Console.WriteLine("Change time to:");
            string newCurrentTime = Console.ReadLine();
            time = newCurrentTime;
        }

        public void ChangeStation()
        {
            Console.WriteLine("Change radio sataion to:");
            string newCurrentRadioStation = Console.ReadLine();
            radioStation = newCurrentRadioStation;
        }

        public void TurnAlarmOnOff()
        {
            Console.WriteLine("Turn alarm on/off: ");
            string newIsAlarmOn = Console.ReadLine();
            alarmIsOn = newIsAlarmOn;

        }

        public void RunClockRadio()
        {
            Console.WriteLine("The time is " + CurrentTime());
            Console.ReadLine();

            Console.WriteLine("The station you're listening to is " + CurentRadioStation());
            Console.ReadLine();

            Console.WriteLine("Current alarm time is " + CurrentAlarmTime());
            Console.ReadLine();

            IsAlarmOn();

            ChangeTime();
            Console.ReadLine();

            Console.WriteLine("New time is " + time);
            Console.ReadLine();

            ChangeStation();
            Console.ReadLine();

            Console.WriteLine("New radio station is " + radioStation);
            Console.ReadLine();

            TurnAlarmOnOff();
            Console.ReadLine();

            Console.WriteLine("Alarm is " + alarmIsOn);
            Console.ReadLine();
        }
    }
}
