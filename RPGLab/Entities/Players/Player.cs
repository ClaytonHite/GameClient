using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace RPGLab.Entities.Players
{
    public class Player
    {
        public int id;
        public string username;
        public PlayerInfo playerInfo;
        public Stats stats;
        public Vector2 position;
        public Sprite2D sprite = null;
        public NameTag2D nameTag = null;
        public string Tag = "";

        public Player(int _id, string _username, Vector2 _position, Stats _stats, PlayerInfo _playerInfo)
        {
            id = _id;
            username = _username;
            stats = _stats;
            playerInfo = _playerInfo;
            position = _position;
            RegisterNameTag();
            RegisterSprite();
        }

        void RegisterNameTag()
        {
            nameTag = new NameTag2D(this.position, new Vector2(96, 64), this.username, "Player");
        }
        void RegisterSprite()
        {
            Image _image = Image.FromFile("_100.png");
            sprite = new Sprite2D(this.position, new Vector2(96, 64), _image, "Player");
        }

        public long GetExperienceNeededForLevel(int _level)
        {
            if (_level <= 5)
            {
                return 100 * (_level - 1);
            }
            if (_level > 5 && _level <= 19)
            {
                return (long)(100 * Math.Pow(_level - 1, 2f));
            }
            if (_level > 19 && _level <= 39)
            {
                return (long)(100 * Math.Pow(_level - 1, 2f * 1.1f));
            }
            if (_level > 39 && _level < 60)
            {
                return (long)(100 * Math.Pow(_level - 1, 2f * 1.2f));
            }
            else
            {
                return (long)(100 * Math.Pow(_level - 1, 2f * 1.2f));
            }
        }
    }
}
