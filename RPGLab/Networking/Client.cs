using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System;
using RPGLab.RPGLab;
using RPGLab;
using RPGLab.Networking;

public class Client
{
    public static Client instance;
    public int ConnectionAttempts;
    public static int dataBufferSize = 4096;
    public string ip = "24.166.1.201";
    //public string ip = "192.168.1.239";
    public int port = 7373;
    public float ClientVersion = 1.0f;

    // clients ID and reference to its protocol class
    public int myId = 0;
    public TCP tcp;
    public UDP udp;

    private bool isConnected = false;
    private delegate void PacketHandler(Packet _packet);
    private static Dictionary<int, PacketHandler> packetHandlers;

    private void Awake()
    {
        //SINGLETON INITIALIZER
        //check if theres already an ID for client and makes sure theres only one instance of the client class existing
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Console.WriteLine("Instance already exists, destroying object!");
            Console.WriteLine(this);
        }
        ConnectToServer();
    }

    private void OnApplicationQuit()
    {
        Disconnect();
        //UIManager.instance.BackToMainMenu();
    }

    public void OnRejection()
    {
        instance.Disconnect();
        //UIManager.instance.BackToMainMenu();
    }

    public void MainMenu()
    {
        instance.Disconnect();
    }

    public void ConnectToServer()
    {
        tcp = new TCP();
        udp = new UDP();
        InitializeClientData();

        isConnected = true;
        tcp.Connect();
    }

    public void CharacterSelect()
    {
        Client.instance.udp.Connect(((IPEndPoint)Client.instance.tcp.socket.Client.LocalEndPoint).Port);
    }

    public class TCP
    {
        public TcpClient socket;

        private NetworkStream stream;
        //BELOW MOST COMPLICATED PART RECEIVING DATA
        private Packet receivedData;
        //ABOVE MOST COMPLICATED PART RECEIVING DATA
        private byte[] receiveBuffer;
        public void Connect()
        {
            //declare buffer sizes for new tcp client
            socket = new TcpClient
            {
                ReceiveBufferSize = dataBufferSize,
                SendBufferSize = dataBufferSize
            };

            receiveBuffer = new byte[dataBufferSize];
            socket.BeginConnect(instance.ip, instance.port, ConnectCallback, socket);
        }

        private void ConnectCallback(IAsyncResult _result)
        {
            socket.EndConnect(_result);

            if (!socket.Connected)
            {
                return;
            }

            stream = socket.GetStream();

            receivedData = new Packet();

            stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);
        }

        public void SendData(Packet _packet)
        {
            try
            {
                if (socket != null)
                {
                    stream.BeginWrite(_packet.ToArray(), 0, _packet.Length(), null, null);
                }
            }
            catch (Exception _ex)
            {
                Log.Error($"Error sending data to server via TCP: {_ex}");
            }
        }

        private void ReceiveCallback(IAsyncResult _result)
        {
            try
            {
                int _byteLength = stream.EndRead(_result);
                if (_byteLength <= 0)
                {
                    //  disconnect
                    //UIManager.instance.BackToMainMenu();
                    instance.Disconnect();
                    return;
                }

                byte[] _data = new byte[_byteLength];
                Array.Copy(receiveBuffer, _data, _byteLength);

                //HANDLE DATA
                receivedData.Reset(HandleData(_data));
                //Wether or not the data gets reset is determined by the value returned by Handle Data
                //The proctol TCP is communicating between server and client, it will ensure that all data gets sent
                //however it can be broken up into pieces because it sends bigger chunks of data through the stream.
                //where it lands on the data delievery segment, could make it to be sent in two different deliveries.
                //Before we call this we want to call the above RESET!!!
                stream.BeginRead(receiveBuffer, 0, dataBufferSize, ReceiveCallback, null);
            }
            catch
            {
                //  disconnect
                //UIManager.instance.BackToMainMenu();
                Disconnect();

            }
        }

        private bool HandleData(byte[] _data)
        {
            int _packetLength = 0;

            //set the received data bytes to the bytes that were jsut read from the stream
            receivedData.SetBytes(_data);

            //this checks to see if receivedData contains more than 4 unread bytes. if it does that means we have the start of one of our packets,
            //because an int takes 4 bytes and the first data of any packet we send is an Integer value representing the length of the packet
            if (receivedData.UnreadLength() >= 4)
            {
                //we get the length of the data here
                _packetLength = receivedData.ReadInt();
                if (_packetLength <= 0)
                {
                    //if its less than or equal 0 all data has been read and we reset it.
                    return true;
                }
            }

            while (_packetLength > 0 && _packetLength <= receivedData.UnreadLength())
            {
                //read the new size of the data received into a byte array
                byte[] _packetBytes = receivedData.ReadBytes(_packetLength);
                ThreadManager.ExecuteOnMainThread(() =>
                {
                    using (Packet _packet = new Packet(_packetBytes))
                    {
                        int _packetId = _packet.ReadInt();
                        packetHandlers[_packetId](_packet);
                    }
                });

                _packetLength = 0;
                if (receivedData.UnreadLength() >= 4)
                {
                    //we get the length of the data here
                    _packetLength = receivedData.ReadInt();
                    if (_packetLength <= 0)
                    {
                        //if its less than or equal 0 all data has been read and we reset it.
                        return true;
                    }
                }
            }

            if (_packetLength <= 1)
            {
                return true;
            }

            return false;
        }

        private void Disconnect()
        {
            //UIManager.instance.BackToMainMenu();
            instance.Disconnect();
            stream = null;
            receivedData = null;
            receiveBuffer = null;
            socket = null;
        }
    }

    public class UDP
    {
        public UdpClient socket;
        public IPEndPoint endPoint;

        public UDP()
        {
            endPoint = new IPEndPoint(IPAddress.Parse(instance.ip), instance.port);
        }

        public void Connect(int _localPort)
        {
            socket = new UdpClient(_localPort);

            socket.Connect(endPoint);
            socket.BeginReceive(ReceiveCallback, null);

            using (Packet _packet = new Packet())
            {
                SendData(_packet);
            }
        }

        public void SendData(Packet _packet)
        {
            try
            {
                _packet.InsertInt(instance.myId);
                if (socket != null)
                {
                    socket.BeginSend(_packet.ToArray(), _packet.Length(), null, null);
                }
            }
            catch (Exception _ex)
            {
                Log.Error($"Error sending data to server via UDP: {_ex}");
            }
        }

        private void ReceiveCallback(IAsyncResult _result)
        {
            try
            {
                byte[] _data = socket.EndReceive(_result, ref endPoint);
                socket.BeginReceive(ReceiveCallback, null);

                if (_data.Length < 4)
                {
                    //disconnect
                    //UIManager.instance.BackToMainMenu();
                    instance.Disconnect();
                    return;
                }

                HandleData(_data);
            }
            catch
            {
                //disconnect
                Disconnect();
                //UIManager.instance.BackToMainMenu();
            }
        }

        private void HandleData(byte[] _data)
        {
            using (Packet _packet = new Packet(_data))
            {
                int _packetLength = _packet.ReadInt();
                _data = _packet.ReadBytes(_packetLength);
            }

            ThreadManager.ExecuteOnMainThread(() =>
            {
                using (Packet _packet = new Packet(_data))
                {
                    int _packetId = _packet.ReadInt();
                    packetHandlers[_packetId](_packet);
                }
            });
        }

        private void Disconnect()
        {
            //UIManager.instance.BackToMainMenu();
            instance.Disconnect();

            endPoint = null;
            socket = null;
        }
    }

    private void InitializeClientData()
    {
        packetHandlers = new Dictionary<int, PacketHandler>()
        {
            { (int)ServerPackets.welcome, ClientHandle.Welcome },
            { (int)ServerPackets.CreateAccount, ClientHandle.CreateAccount },
            { (int)ServerPackets.characterSelect, ClientHandle.CharacterSelect },
            { (int)ServerPackets.spawnPlayer, ClientHandle.SpawnPlayer },
            { (int)ServerPackets.playerPosition, ClientHandle.PlayerPosition },
            { (int)ServerPackets.CreateCharacter, ClientHandle.CreateCharacter },
            { (int)ServerPackets.PopulateMonsters, ClientHandle.PopulateMonsters },
            { (int)ServerPackets.MonsterUpdate, ClientHandle.MonsterUpdate },
            { (int)ServerPackets.UpdateMonsterPosition, ClientHandle.UpdateMonsterPosition },
            { (int)ServerPackets.PlayerDamageDone, ClientHandle.PlayerDamageDone },
            { (int)ServerPackets.MonsterDamageDone, ClientHandle.MonsterDamageDone },
            { (int)ServerPackets.updatePlayer, ClientHandle.UpdatePlayer },
            { (int)ServerPackets.wrongAccountorPassword, ClientHandle.WrongAccountorPassword },
            { (int)ServerPackets.ChatBox, ClientHandle.ChatBox }
        };
        Log.Info("Initialized packets.");
    }

    private void Disconnect()
    {
        if (isConnected)
        {
            isConnected = false;
            tcp.socket.Close();
            udp.socket.Close();
            Log.Error("Disconnected from server.");
        }
        AdventuresOnlineWindow.SendtoLoginScreen();
    }

    public void Start()
    {
        Awake();
    }
}
