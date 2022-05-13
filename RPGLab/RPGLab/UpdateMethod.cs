using RPGLab.Networking;
using System;
using System.Collections;
using System.Threading;
using RPGLab.Combat;
namespace RPGLab.RPGLab
{
    public class UpdateMethod
    {
        public void Start()
        {
            Sprite2D.onLoad();
            Shape2D.onLoad();
            NameTag2D.onLoad();
        }
        public virtual void Update()
        {
            ThreadManager.UpdateMain();
            AdventuresOnlineWindow.loginWindow.UpdateForm();
            Combat.Combat.Update();
        }        
    }
}
