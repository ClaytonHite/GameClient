using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.RPGLab
{
    public class WaitTime
    {
        private static Timer aTimer;
        public static bool timerDone;
        static int bTimer;

        public static void InSeconds(int time)
        {
            timerDone = false;
            SetTimer(time);
            aTimer.Stop();
            aTimer.Dispose();
        }

        private static void SetTimer(int time)
        {
            aTimer = new System.Timers.Timer(time * 1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            bTimer = time;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timerDone = true;
            Log.Info($"{bTimer} second(s) is timer is done!");
        }
    }
}