using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections;
using RPGLab.Networking;

namespace RPGLab.RPGLab
{    public abstract class RPGLab
    {
        public static Client instance = new Client();
        public Vector2 ScreenSize = Vector2.Zero();
        private string Title = "New Game";
        private Networking.AdventuresOnlineWindow loginWindow = null;
        public UpdateMethod reference = new UpdateMethod();
        public bool isRunning;
        public static bool loggedIn = false;

        public RPGLab(string Title)
        {
            isRunning = true;
            Log.Info("Game is starting...");
            this.Title = Title;
            loginWindow = new AdventuresOnlineWindow();
            loginWindow.Text = this.Title;
            Thread GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();
            Application.Run(loginWindow);
        }
        public static void LoggedInBool(bool _result)
        {
            loggedIn = _result;
        }
        public void Window_KeyUp(object sender, KeyEventArgs e)
        {
            GetKeyUp(e);
        }

        public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            GetKeyDown(e);
        }

        void GameLoop()
        {
            reference.Start();
            Log.Info(DateTime.Now + $" -- Game Loop thread started. Running at {Constants.TICKS_PER_SEC} ticks per second.");
            OnLoad();
            instance.Start();
            DateTime _nextLoop = DateTime.Now;
            while (isRunning)
            {
                while (_nextLoop < DateTime.Now)
                {
                    OnDraw();
                    OnUpdate();
                    reference.Update();
                    _nextLoop.AddMilliseconds(Constants.MS_PER_TICK);
                    if (_nextLoop > DateTime.Now)
                    {
                        Thread.Sleep(_nextLoop - DateTime.Now);
                    }
                }
            }
        }

        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnDraw();
        public abstract void GetKeyDown(KeyEventArgs e);
        public abstract void GetKeyUp(KeyEventArgs e);
    }
}
