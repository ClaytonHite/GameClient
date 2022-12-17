using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using RPGLab.RPGLab;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using RPGLab.Networking;
using System.Threading.Tasks;
using RPGLab.Entities.Players;

namespace RPGLab
{
    class AdventuresOnline : RPGLab.RPGLab
    {
        public static AdventuresOnline loginWindow;
        public static Dictionary<int, Player> player = GameManager.players;
        public Vector2 CameraPosition = Vector2.Zero();
        bool left;
        bool right;
        bool up;
        bool down;
        bool upleft;
        bool upright;
        bool downleft;
        bool downright;
        bool ctrlButton;

        public AdventuresOnline() : base("Adventures Online Demo") { }
        public override void OnLoad()
        {
            AdventuresOnline.loginWindow = this;
        }
        public override void OnDraw()
        {
        }
        public override void OnUpdate()
        {
            if (player.ContainsKey(Client.instance.myId))
            {
                Vector2 playerPos = player[Client.instance.myId].position;
                if (up)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X, playerPos.Y - 1f)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X, player[Client.instance.myId].position.Y - 1f));
                    }
                }
                else if (down)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X, playerPos.Y + 1f)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X, player[Client.instance.myId].position.Y + 1f));
                    }
                }
                else if (left)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X - 1f, playerPos.Y)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X -1f , player[Client.instance.myId].position.Y));
                    }
                }
                else if (right)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X + 1f, playerPos.Y)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X + 1f, player[Client.instance.myId].position.Y));
                    }
                }
                else if (upleft)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X - 1f, playerPos.Y - 1f)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X - 1f, player[Client.instance.myId].position.Y - 1f));
                    }
                }
                else if (upright)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X + 1f, playerPos.Y - 1f)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X + 1f, player[Client.instance.myId].position.Y - 1f));
                    }
                }
                else if (downleft)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X - 1f, playerPos.Y + 1f)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X - 1f, player[Client.instance.myId].position.Y + 1f));
                    }
                }
                else if (downright)
                {
                    if (Collider.CheckForCollider(new Vector2(playerPos.X + 1f, playerPos.Y + 1f)))
                    {
                        ClientSend.PlayerMovement(new Vector2(player[Client.instance.myId].position.X + 1f, player[Client.instance.myId].position.Y + 1f));
                    }
                }
            }            
        }
        public override void GetKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlButton = true;
            }
            if (!ctrlButton)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.NumPad8) { up = true; }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.NumPad2) { down = true; }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.NumPad4) { left = true; }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.NumPad6) { right = true; }
                if (e.KeyCode == Keys.NumPad7) { upleft = true; }
                if (e.KeyCode == Keys.NumPad9) { upright = true; }
                if (e.KeyCode == Keys.NumPad1) { downleft = true; }
                if (e.KeyCode == Keys.NumPad3) { downright = true; }
            }
            if (ctrlButton)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.NumPad8) { Combat.Combat.attackUp = true; }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.NumPad2) { Combat.Combat.attackDown = true; }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.NumPad4) { Combat.Combat.attackLeft = true; }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.NumPad6) { Combat.Combat.attackRight = true; }
                if (e.KeyCode == Keys.NumPad7) { Combat.Combat.attackUpLeft = true; }
                if (e.KeyCode == Keys.NumPad9) { Combat.Combat.attackUpRight = true; }
                if (e.KeyCode == Keys.NumPad1) { Combat.Combat.attackDownLeft = true; }
                if (e.KeyCode == Keys.NumPad3) { Combat.Combat.attackDownRight = true; }
            }
        }

        public override void GetKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlButton = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.NumPad8) { up = false; Combat.Combat.attackUp = false; }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.NumPad2) { down = false; Combat.Combat.attackDown = false; }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.NumPad4) { left = false; Combat.Combat.attackLeft = false; }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.NumPad6) { right = false; Combat.Combat.attackRight = false; }
            if (e.KeyCode == Keys.NumPad7) { upleft = false; Combat.Combat.attackUpLeft = false; }
            if (e.KeyCode == Keys.NumPad9) { upright = false; Combat.Combat.attackUpRight = false; }
            if (e.KeyCode == Keys.NumPad1) { downleft = false; Combat.Combat.attackDownLeft = false; }
            if (e.KeyCode == Keys.NumPad3) { downright = false; Combat.Combat.attackDownRight = false; }
        }
    }
}
