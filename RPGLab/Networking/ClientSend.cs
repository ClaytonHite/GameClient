using RPGLab.RPGLab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGLab.Networking
{
    public class ClientSend
    {
        private static void SendTCPData(Packet _packet)
        {
            _packet.WriteLength();
            Client.instance.tcp.SendData(_packet);
        }

        private static void SendUDPData(Packet _packet)
        {
            _packet.WriteLength();
            Client.instance.udp.SendData(_packet);
        }

        #region Packets
        public static void WelcomeReceived()
        {
            using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
            {
                _packet.Write(Client.instance.myId);
                _packet.Write(Client.instance.ClientVersion);

                SendTCPData(_packet);
            }
        }
        public static void Login(string Username, string Password)
        {
            using (Packet _packet = new Packet((int)ClientPackets.Login))
            {
                _packet.Write(Client.instance.myId);
                _packet.Write(Username);
                _packet.Write(Password);

                SendTCPData(_packet);
            }
        }

        public static void CreateAccount(string _username, string _password)
        {
            using (Packet _packet = new Packet((int)ClientPackets.createAccount))
            {
                _packet.Write(Client.instance.myId);
                _packet.Write(_username);
                _packet.Write(_password);

                SendTCPData(_packet);
            }
        }

        public static void CreateCharacter(string username, string password, string characterName, string Race, string Class, int Avatar)
        {
            using (Packet _packet = new Packet((int)ClientPackets.createCharacter))
            {
                if (username != null && password != null && characterName != null)
                {
                    _packet.Write(Client.instance.myId);
                    _packet.Write(username);
                    _packet.Write(password);
                    _packet.Write(characterName);
                    _packet.Write(Race);
                    _packet.Write(Class);
                    _packet.Write(Avatar);

                    SendTCPData(_packet);
                }
            }
        }

        public static void CharacterSelect(string _username, string _password, string _playerame)
        {
            using (Packet _packet = new Packet((int)ClientPackets.CharacterSelect))
            {
                _packet.Write(Client.instance.myId);
                _packet.Write(_username);
                _packet.Write(_password);
                _packet.Write(_playerame);

                SendTCPData(_packet);
            }
        }

        public static void PlayerMovement(Vector2 location)
        {
            using (Packet _packet = new Packet((int)ClientPackets.playerMovement))
            {
                _packet.Write(location);

                SendUDPData(_packet);
            }
        }
        public static void ChatBox(string msg)
        {
            using (Packet _packet = new Packet((int)ClientPackets.ChatBox))
            {
                _packet.Write(Client.instance.myId);
                _packet.Write(msg);

                SendTCPData(_packet);
            }
        }
        public static void PlayerCombat(int monsterKey, Vector2 location)
        {
            using (Packet _packet = new Packet((int)ClientPackets.playerCombat))
            {
                _packet.Write(monsterKey);
                _packet.Write(location);

                SendUDPData(_packet);
            }
        }
        public static void AddSkill(int skill)
        {
            using (Packet _packet = new Packet((int)ClientPackets.addSkill))
            {
                _packet.Write(skill);

                SendUDPData(_packet);
            }
        }
        public static void CharacterToDelete(string loginUsername, string loginPassword, string characterToDelete)
        {
            using (Packet _packet = new Packet((int)ClientPackets.CharacterToDelete))
            {
                _packet.Write(loginUsername);
                _packet.Write(loginPassword);
                _packet.Write(characterToDelete);

                SendTCPData(_packet);
            }
        }
        public static void AccountToDelete(string loginUsername, string loginPassword)
        {
            using (Packet _packet = new Packet((int)ClientPackets.AccountToDelete))
            {
                _packet.Write(loginUsername);
                _packet.Write(loginPassword);

                SendTCPData(_packet);
            }
        }
        #endregion
        public static void ClientItemToPickUp(Vector2 position, int inventorySlot, int itemID)
        {
            using (Packet _packet = new Packet((int)ClientPackets.ClientItemToPickUp))
            {
                _packet.Write(position);
                _packet.Write(inventorySlot);
                _packet.Write(itemID);

                SendTCPData(_packet);
            }
        }
    }
}
