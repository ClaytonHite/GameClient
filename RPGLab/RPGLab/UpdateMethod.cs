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
        }
        public virtual void Update()
        {
            TileMap.UpdateVisibleSprites();
            ThreadManager.UpdateMain();
            AdventuresOnlineWindow.loginWindow.UpdateForm();
            Combat.Combat.Update();
        }        
    }
}
