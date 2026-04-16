using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    class MobilePhone
    {
        public delegate void RingEventHandler();
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            Console.WriteLine("The phone is ringing...");

            if (OnRing != null)
            {
                OnRing();
            }
        }   
    }

    class RingtonePlayer
    {
        public void PlayRingtone()
        {
            Console.WriteLine();
            Console.WriteLine("Playing ringtone...");
        }
    }

    class ScreenDisplay
    {
        public void ShowCallerInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Displaying caller information...");
        }
    }

    class VibrationMotor
    {
        public void Vibrate()
        {
            Console.WriteLine();
            Console.WriteLine("Phone is Vibrating...");
        }
    }

    internal class Q3
    {
        static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone();

            RingtonePlayer ringtonePlayer = new RingtonePlayer();
            ScreenDisplay screenDisplay = new ScreenDisplay();
            VibrationMotor vibrationMotor = new VibrationMotor();

            phone.OnRing += ringtonePlayer.PlayRingtone;
            phone.OnRing += screenDisplay.ShowCallerInfo;
            phone.OnRing += vibrationMotor.Vibrate;

            phone.ReceiveCall();
        }
    }
}
