using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Entities.Players
{
    public class PlayerInfo
    {
        public string playerAvatar;
        public string playerRace;
        public string playerClass;
        public bool playerBusy;
        public bool isMoving = false;
        public bool isStealth;
        public PlayerInfo(string playerAvatar, string playerRace, string playerClass, bool playerBusy, bool isStealth)
        {
            this.playerAvatar = playerAvatar;
            this.playerRace = playerRace;
            this.playerClass = playerClass;
            this.playerBusy = playerBusy;
            this.isStealth = isStealth;
        }
    }
}
