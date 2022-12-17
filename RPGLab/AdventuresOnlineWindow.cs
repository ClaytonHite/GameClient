using RPGLab.Entities.Items;
using RPGLab.Entities.Items.ItemTypes;
using RPGLab.Entities.Players;
using RPGLab.RPGLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGLab.Networking
{
    public partial class AdventuresOnlineWindow : Form
    {
        public static AdventuresOnlineWindow loginWindow;
        public static Dictionary<int, Player> players = GameManager.players;
        public static bool loggedIn = false;
        public static string[] characterList;
        private static int avatarIndexList;
        private static int raceIndexList;
        private static int classIndexList;
        public Color BackgroundColor = Color.Black;
        public static Vector2 CameraPosition = Vector2.Zero();
        static Image[] ImageNumber = new Image[3000];
        static List<Image> ItemImageNumbers = new List<Image>();
        static int counter;
        static string periodCount;
        Button button = null;
        Panel panel = null;
        bool ResizePanel = false;
        bool MovePanel = false;
        int firstXPos;
        int firstYPos;
        Item _itemToPickUp;
        Vector2 ItemToPickUpLocation;
        PictureBox focusedInventorySlot;
        public AdventuresOnlineWindow()
        {
            InitializeComponent();
            InitializeStartMenu();
            LoginPanel.Show();
            GameRenderer.Paint += Renderer;
            TileMap.LoadMapSprites(MainMapImageList);
            loginWindow = this;
            for (int i = 0; i < 3000; i++)
            {
                if ((Image)Properties.Resources.ResourceManager.GetObject("_" + i) != null)
                {
                    ImageNumber[i] = (Image)Properties.Resources.ResourceManager.GetObject("_" + i);
                }
            }
            //DOUBLE BUFFERING ON PANELS.... SWEEETTTT
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, LoginPanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CreateCharacterPanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CharacterSelectPanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, CreateAccountPanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, GamePanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, SkillsPanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, InventoryPanel, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, InventoryPanel2, new object[] { true });
        }
        public void UpdateForm()
        {
            //MEMORY LEAK if not done right
            try
            {
                MethodInvoker refresh = delegate { GamePanel.Refresh(); };
                Invoke(refresh);
            }
            catch
            {
                Application.Exit();
            }
        }
        private void CONNECT_Click(object sender, EventArgs e)
        {
            string loginUsername = Username.Text;
            string loginPassword = Password.Text;
            ClientSend.Login(loginUsername, loginPassword);
        }
        public static void CreateCharacterBool(bool _accinput)
        {
            string accmsg;
            if (!_accinput)
            {
                accmsg = $"Invalid Character Name.";
            }
            else
            {
                accmsg = "You have succesfully created a character!";
            }
            MethodInvoker acc = delegate { loginWindow.CreateCharacterRejectionLabel.Text = accmsg; };
            loginWindow.Invoke(acc);
        }
        public static void WrongAccountorPassword(bool _accinput)
        {
            string accmsg;
            if (!_accinput)
            {
                accmsg = $"Invalid Username or Password! ({4 - Client.instance.ConnectionAttempts}) Attempts Left.";
            }
            else
            {
                accmsg = "";
            }
            MethodInvoker acc = delegate { loginWindow.LoginLabelAccountInfoBoolean.Text = accmsg; };
            loginWindow.Invoke(acc);
        }
        public void InitializeStartMenu()
        {
            CreateAccountButton.Visible = false;
            ConnectButton.Visible = false;
            Password.Visible = false;
            Username.Visible = false;
            PasswordLabel.Visible = false;
            UsernameLabel.Visible = false;
            DeleteAccountButton.Visible = false;
        }
        public static void LoadingBar(int value, int maxValue, bool visible)
        {
            MethodInvoker loadingBar = delegate 
            { 
                loginWindow.LoadingStartBar.Value = value;
                loginWindow.LoadingStartBar.Maximum = maxValue;
                loginWindow.LoadingStartBar.Visible = visible;
                loginWindow.LoadingBarLabel.Visible = visible;
                counter++;
                periodCount = new string('.', counter / 400);
                loginWindow.LoadingBarLabel.Text = ("Loading" + periodCount);
                if(counter > 2000)
                {
                    counter = 0;
                }
                if (!visible)
                {
                    loginWindow.CreateAccountButton.Visible = true;
                    loginWindow.ConnectButton.Visible = true;
                    loginWindow.Password.Visible = true;
                    loginWindow.Username.Visible = true;
                    loginWindow.PasswordLabel.Visible = true;
                    loginWindow.UsernameLabel.Visible = true;
                    loginWindow.DeleteAccountButton.Visible=true;
                }
            };
            loginWindow.Invoke(loadingBar) ;
        }
        private void AccountInfo()
        {
            MethodInvoker ClearCharacterSelectBox = delegate
            {
                CharacterSelectDropdownBox.Items.Clear();
            };
            Invoke(ClearCharacterSelectBox);
            for (int i = 0; i < characterList.Length; i++)
            {
                if ((i + 1) % 14 == 0)
                {
                    MethodInvoker Char = delegate
                    {
                        CharacterSelectDropdownBox.Items.Add(characterList[i - 13]);
                        CharacterSelectDropdownBox.Text = characterList[0];
                        ImageList[] RaceImage = { DragonbornImageList, DwarfImageList, ElfImageList, GnomeImageList, GoblinImageList, HalfElfImageList, HalflingImageList, HumanImageList };
                        for (int j = 0; j < RaceImage.Length; j++)
                        {
                            if ((string)RaceImage[j].Tag == (characterList[3]))
                            {
                                CharacterSelectAvatarImage.Image = RaceImage[j].Images[Convert.ToInt32(characterList[2])];
                            }
                        }
                        LoginPanel.Hide();
                        CharacterSelectPanel.Show();
                    };
                    Invoke(Char);
                }
            }
            MethodInvoker NoAccount = delegate
            {
                LoginPanel.Hide();
                CharacterSelectPanel.Show();
            };
            Invoke(NoAccount);
        }
        private void showSelectedDropdown_Click(object sender, System.EventArgs e)
        {
            int selectedIndex = CharacterSelectDropdownBox.SelectedIndex;
            Object selectedItem = CharacterSelectDropdownBox.SelectedItem;
            if (selectedItem != null)
            {
                for (int i = 0; i < characterList.Length; i++)
                {
                    if (selectedItem.ToString() == characterList[i])
                    {
                        CharacterSelectCharacterInfo.Text = ($"Level {characterList[i + 1]} {characterList[i + 3]} {characterList[i + 4]}");
                        MethodInvoker Char3 = delegate
                        {
                            ImageList[] RaceImage = { DragonbornImageList, DwarfImageList, ElfImageList, GnomeImageList, GoblinImageList, HalfElfImageList, HalflingImageList, HumanImageList };
                            for (int y = 0; y < RaceImage.Length; y++)
                            {
                                if ((string)RaceImage[y].Tag == (characterList[i + 3]))
                                {
                                    CharacterSelectAvatarImage.Image = RaceImage[y].Images[Convert.ToInt32(characterList[i + 2])];
                                }
                            }
                        };
                        Invoke(Char3);
                    }
                }
            }
        }
        public static void UpdateNameLevelRaceLabel(int _myId)
        {
            MethodInvoker UpdateLabel = delegate
            {
                try
                {
                    loginWindow.GamePanelPlayerLevelRaceClassLabel.Text = $"Level {players[_myId].stats.level} { players[_myId].playerInfo.playerRace} { players[_myId].playerInfo.playerClass}";
                    loginWindow.enterStrengthData.Text = Convert.ToString(players[Client.instance.myId].stats.strength);
                    loginWindow.enterDexterityData.Text = Convert.ToString(players[Client.instance.myId].stats.dexterity);
                    loginWindow.enterConstitutionData.Text = Convert.ToString(players[Client.instance.myId].stats.constitution);
                    loginWindow.enterIntellectData.Text = Convert.ToString(players[Client.instance.myId].stats.intellect);
                    loginWindow.enterWisdomData.Text = Convert.ToString(players[Client.instance.myId].stats.wisdom);
                    loginWindow.enterCharismaData.Text = Convert.ToString(players[Client.instance.myId].stats.charisma);
                    loginWindow.enterExperienceData.Text = Convert.ToString(players[Client.instance.myId].stats.playerExperience);
                    loginWindow.enterSkillPointsData.Text = $" Stat Points Available : {Convert.ToString(players[Client.instance.myId].stats.playerSkillPoints)}";
                    loginWindow.EnterCarryingWeightData.Text = Convert.ToString(players[Client.instance.myId].stats.playerCarryingWeight);
                    loginWindow.GamePanelPlayerHealthAmountLabel.Text = $"{players[Client.instance.myId].stats.currentHitPoints}/{players[Client.instance.myId].stats.maxHitPoints}";
                    loginWindow.HealthProgressBar.Maximum = players[Client.instance.myId].stats.maxHitPoints;
                    loginWindow.HealthProgressBar.Value = players[Client.instance.myId].stats.currentHitPoints;
                    loginWindow.GamePanelPlayerManaAmountLabel.Text = $"{players[Client.instance.myId].stats.currentManaPoints}/{players[Client.instance.myId].stats.maxManaPoints}";
                    loginWindow.ManaProgressBar.Maximum = players[Client.instance.myId].stats.maxManaPoints;
                    loginWindow.ManaProgressBar.Value = players[Client.instance.myId].stats.currentManaPoints;
                    long prevExperience = players[Client.instance.myId].GetExperienceNeededForLevel(players[Client.instance.myId].stats.level - 1);
                    int expPercentage = (int)(((players[Client.instance.myId].stats.playerExperience - prevExperience) * 100) / ((players[Client.instance.myId].stats.ExperienceRequired - prevExperience) + 1));
                    loginWindow.GamePanelPlayerExperienceAmountPercentLabel.Text = $"{expPercentage}%";
                    loginWindow.enterExperienceData.Text = $"{players[Client.instance.myId].stats.playerExperience} / {players[Client.instance.myId].stats.ExperienceRequired}";
                    if (expPercentage <= 100 && expPercentage >= 0)
                    {
                        loginWindow.ExperienceProgressBar.Value = expPercentage;
                    }
                }
                catch
                {
                    Console.WriteLine("DEBUG HERE");
                }
            };
            loginWindow.Invoke(UpdateLabel);
        }
        public static void SendtoCharacterSelectScreen(string[] character)
        {
                characterList = character;
                loginWindow.AccountInfo();
        }
        public static void CreateAccountBool(bool _input)
        {
            string msg;
            if (_input)
            {
                msg = "Success!";
            }
            else
            {
                msg = "Invalid Username or Password!";
            }
            MethodInvoker inv = delegate { 
                loginWindow.CreateAccountRejectionLabel.Text = msg;
            };
            loginWindow.Invoke(inv);
        }
        public static void SendtoCharacterCreateScreen()
        {
            MethodInvoker CharacterCreate = delegate
            {
                loginWindow.CharacterSelectPanel.Hide();
                loginWindow.CreateAccountPanel.Hide();
                loginWindow.LoginPanel.Hide();
                loginWindow.CharacterSelectPanel.Hide();
                loginWindow.CreateCharacterPanel.Show();
            };
            loginWindow.Invoke(CharacterCreate);
        }
        public static void SendtoLoginScreen()
        {
            MethodInvoker LoginScreen = delegate
            {
                if(Client.instance.udp.socket == null)
                {
                    loginWindow.LoginLabelAccountInfoBoolean.Text = "Error connecting to server. Check Client Version to see if you are up to date with latest client.";
                }
                loginWindow.CharacterSelectPanel.Hide();
                loginWindow.CreateAccountPanel.Hide();
                loginWindow.LoginPanel.Show();
                loginWindow.CharacterSelectPanel.Hide();
                loginWindow.CreateCharacterPanel.Hide();
                loginWindow.GamePanel.Hide();
            };
            loginWindow.Invoke(LoginScreen);
        }
        public void GotoCreateCharacterPanelButton_Click(object sender, System.EventArgs e)
        {
            CharacterSelectPanel.Hide();
            CreateCharacterPanel.Show();
            CreateCharacterAvatarImage(sender, e);
        }
        #region //RightandLeftButtons for creating a character\\
        public void CreateCharacterAvatarLeftButton_Click(object sender, System.EventArgs e)
        {
            avatarIndexList--;
            CreateCharacterAvatarImage(sender, e);
        }
        public void CreateCharacterAvatarRightButton_Click(object sender, System.EventArgs e)
        {
            avatarIndexList++;
            CreateCharacterAvatarImage(sender, e);
        }
        public void CreateCharacterRaceLeftButton_Click(object sender, System.EventArgs e)
        {
            avatarIndexList = 0;
            raceIndexList--;
            CreateCharacterRaceText(sender, e);
            CreateCharacterAvatarImage(sender, e);
        }
        public void CreateCharacterRaceRightButton_Click(object sender, System.EventArgs e)
        {
            avatarIndexList = 0;
            raceIndexList++;
            CreateCharacterRaceText(sender, e);
            CreateCharacterAvatarImage(sender, e);
        }
        public void CreateCharacterClassLeftButton_Click(object sender, System.EventArgs e)
        {
            classIndexList--;
            CreateCharacterClassText(sender, e);
        }
        public void CreateCharacterClassRightButton_Click(object sender, System.EventArgs e)
        {
            classIndexList++;
            CreateCharacterClassText(sender, e);
        }
        public void CreateCharacterClassText(object sender, System.EventArgs e)
        {
            int maxClasses = 11;
            if (classIndexList > maxClasses)
            {
                classIndexList = 0;
            }
            if (classIndexList < 0)
            {
                classIndexList = maxClasses;
            }
            CreateCharacterClass.Text = Constants.Classes[classIndexList];
        }
        public void CreateCharacterRaceText(object sender, System.EventArgs e)
        {
            int maxRaces = 7;
            if (raceIndexList > maxRaces)
            {
                raceIndexList = 0;
            }
            if (raceIndexList < 0)
            {
                raceIndexList = maxRaces;
            }
            CreateCharacterRace.Text = Constants.Races[raceIndexList];
        }
        public void CreateCharacterAvatarImage(object sender, System.EventArgs e)
        {
            int maxDragonbornRaceImages = 12;
            int maxDwarfRaceImages = 5;
            int maxElfRaceImages = 4;
            int maxGnomeRaceImages = 2;
            int maxGoblinRaceImages = 3;
            int maxHalfElfRaceImages = 4;
            int maxHalflingRaceImages = 3;
            int maxHumanRaceImages = 5;
            string AvatarType = CreateCharacterRace.Text;
            if (AvatarType == "Dragonborn")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxDragonbornRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = DragonbornImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxDragonbornRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = DragonbornImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxDragonbornRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = DragonbornImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Dwarf")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxDwarfRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = DwarfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxDwarfRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = DwarfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxDwarfRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = DwarfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Elf")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxElfRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = ElfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxElfRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = ElfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxElfRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = ElfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Gnome")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxGnomeRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = GnomeImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxGnomeRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = GnomeImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxGnomeRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = GnomeImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Goblin")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxGoblinRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = GoblinImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxGoblinRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = GoblinImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxGoblinRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = GoblinImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Half-Elf")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxHalfElfRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HalfElfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxHalfElfRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HalfElfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxHalfElfRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HalfElfImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Halfling")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxHalflingRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HalflingImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxHalflingRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HalflingImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxHalflingRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HalflingImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
            if (AvatarType == "Human")
            {
                if (avatarIndexList < 0)
                {
                    avatarIndexList = maxHumanRaceImages;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HumanImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList >= 0 && avatarIndexList <= maxHumanRaceImages)
                {
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HumanImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
                if (avatarIndexList > maxHumanRaceImages)
                {
                    avatarIndexList = 0;
                    MethodInvoker inv = delegate { CreateCharacterAvatarPictureBox.Image = HumanImageList.Images[avatarIndexList]; };
                    Invoke(inv);
                }
            }
        }
        #endregion
        public void CreateCharacterPanelButtonSendToServer_Click(object sender, System.EventArgs e)
        {
            int playerNameCount = 0;
            string _username = Username.Text;
            string _password = Password.Text;
            string _playername = CreateCharacterName.Text;
            string _race = CreateCharacterRace.Text;
            string _class = CreateCharacterClass.Text;
            int _avatar = avatarIndexList;
            string[] restrictedNames = { "GM", "Gamemaster", "GameMaster", "CM", "CommunityManager", "Guide" };
            bool restrictedNamesBool = false;
            for (int i = 0; i < CreateCharacterName.Text.Length; i++)
            {
                if (_playername[i] != ' ')
                    playerNameCount++;
            }
            if (playerNameCount > 2)
            {
                for (int i = 0; i < restrictedNames.Length; i++)
                {
                    if (_playername.Contains(restrictedNames[i]))
                    {
                        CreateCharacterRejectionLabel.Text = "Contains words that are not allowed!";
                        restrictedNamesBool = true;
                    }
                }
                if (!restrictedNamesBool)
                {
                    ClientSend.CreateCharacter(_username, _password, _playername, _race, _class, _avatar);
                }
            }
            else
            {
                CreateCharacterRejectionLabel.Text = "Player Name must be more than 2 characters!";
            }

        }
        public void GotoCreateAccountPanelButton_Click(object sender, System.EventArgs e)
        {
            loginWindow.CreateAccountPanel.Show();
            loginWindow.LoginPanel.Hide();
        }
        public void CreateAccountButton_Click(object sender, System.EventArgs e)
        {
            string _username = CreateAccountUsername.Text;
            string _password = CreateAccountPassword.Text;
            int count = 0;
            for (int i = 0; i < _username.Length; i++)
            {
                if (_username[i] != ' ')
                    count++;
            }
            if (count > 4)
            {
                if (CreateAccountUsername.Text != null && CreateAccountPassword.Text != null)
                {
                    ClientSend.CreateAccount(_username, _password);
                    CreateCharacterPanel.Hide();
                    LoginPanel.Show();
                }
            }
            else
            {
                CreateAccountRejectionLabel.Text = "Username must be more than 4 characters!";
            }
        }
        public void CreateAccountCancelButton_Click(object sender, System.EventArgs e)
        {
            loginWindow.CreateAccountPanel.Hide();
            loginWindow.LoginPanel.Show();
        }
        public void CreateCharacterPanelButtonCancel_Click(object sender, System.EventArgs e)
        {
            loginWindow.CreateCharacterPanel.Hide();
            loginWindow.LoginPanel.Show();
        }
        private void CharacterSelectLogOffButton_Click(object sender, EventArgs e)
        {
            characterList = null;
            loginWindow.CharacterSelectPanel.Hide();
            loginWindow.LoginPanel.Show();
        }
        public static void ChaseCamera(Vector2 Position)
        {
            CameraPosition = new Vector2((Position.X * 96), (Position.Y * 64));
        }
        public void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackgroundColor);
            g.TranslateTransform((-1 * CameraPosition.X) + 672, (-1 * CameraPosition.Y) + 384);
            foreach (Shape2D shape in Shape2D.GetShapes())
            {
                g.FillRectangle(new SolidBrush(Color.Red), shape.Position.X * 96, shape.Position.Y * 64, shape.Scale.X, shape.Scale.Y);
            }
            foreach (MapTileSprites2D MapTileSprite in MapTileSprites2D.GetSprites())
            {
                g.DrawImage(ImageNumber[MapTileSprite.ImageNumber], MapTileSprite.Position.X * 96, MapTileSprite.Position.Y * 64, MapTileSprite.Scale.X, MapTileSprite.Scale.Y);
            }
            foreach (Item2D _item in Item2D.GetSprites())
            {
                g.DrawImage(ImageNumber[_item.ImageNumber], (_item.Position.X * 96) + 24, (_item.Position.Y * 64) + 8, _item.Scale.X, _item.Scale.Y);
            }
            foreach (Sprite2D sprite in Sprite2D.GetSprites())
            {
                g.DrawImage(sprite.Sprite, sprite.Position.X * 96, sprite.Position.Y * 64, sprite.Scale.X, sprite.Scale.Y);
            }
            foreach (NameTag2D nameTag in NameTag2D.GetNameTags())
            {
                g.DrawString(nameTag.PlayerName, nameTag.Font, Brushes.White, ((nameTag.Position.X) * 96), ((nameTag.Position.Y - .2f) * 64));
            }
        }
        private void LoginWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(GameChatTextBox.Focused)
            {

            }
            if (!GameChatTextBox.Focused)
            {
                AdventuresOnline.loginWindow.Window_KeyDown(sender, e);
            }
        }
        private void LoginWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (!GameChatTextBox.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    GameChatTextBox.Focus();
                }
                AdventuresOnline.loginWindow.Window_KeyUp(sender, e);
            }
            else if (GameChatTextBox.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string chatInput = $"{GamePanelPlayerNameLabel.Text}: {GameChatTextBox.Text}";
                    if(GameChatTextBox.Text != "")
                    {
                        ClientSend.ChatBox(chatInput);
                    }
                    GameChatTextBox.Text = "";
                    GamePanel.Focus();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    GameChatTextBox.Text = "";
                    GamePanel.Focus();
                }
            }
        }
        public static void UpdateGameChatBox(string chatMsg)
        {
            MethodInvoker ChatBox = delegate
            {
                loginWindow.GameChatBox.Items.Add(chatMsg);
                int visibleItems = loginWindow.GameChatBox.ClientSize.Height / loginWindow.GameChatBox.ItemHeight;
                loginWindow.GameChatBox.TopIndex = Math.Max(loginWindow.GameChatBox.Items.Count - visibleItems + 1, 0);
            };
            loginWindow.Invoke(ChatBox);
        }

        private void CharacterSelectConnectButton_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                RPGLab.RPGLab.LoggedInBool(true);
                loggedIn = true;
                string loginUsername = Username.Text;
                string loginPassword = Password.Text;
                string loginPlayerName = CharacterSelectDropdownBox.Text;
                ClientSend.CharacterSelect(loginUsername, loginPassword, loginPlayerName);
            }
        }
        public static Image GetAvatarImage(string playerRace, string PlayerAvatarInt)
        {
            Image avatarImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + PlayerAvatarInt);
            ImageList[] RaceImage = { loginWindow.DragonbornImageList, loginWindow.DwarfImageList, loginWindow.ElfImageList, loginWindow.GnomeImageList, loginWindow.GoblinImageList, loginWindow.HalfElfImageList, loginWindow.HalflingImageList, loginWindow.HumanImageList };
            for (int i = 0; i < RaceImage.Length; i++)
            {
                if ((string)RaceImage[i].Tag == (playerRace))
                {
                    avatarImage = RaceImage[i].Images[Convert.ToInt32(PlayerAvatarInt)];
                }
            }
            return avatarImage;
        }
        public void SpawnPlayer(Player _player)
        {
            loginWindow.BackgroundImage = null;
            loginWindow.BackColor = Color.MidnightBlue;
            if (Client.instance.myId == _player.id)
            {
                loginWindow.PlayerInfoGamePanel(_player);
            }
        }
        public void PlayerInfoGamePanel(Player _player)
            {
            MethodInvoker Char3 = delegate
            {
                GameRenderer.BackColor = BackgroundColor;
                CharacterSelectPanel.Hide();
                GamePanel.Show();
                GamePanelPlayerHealthAmountLabel.Text = ($"{_player.stats.currentHitPoints}/{_player.stats.maxHitPoints}");
                GamePanelPlayerManaAmountLabel.Text = ($"{_player.stats.currentManaPoints}/{_player.stats.maxManaPoints}");
                HealthProgressBar.Maximum = _player.stats.maxHitPoints;
                HealthProgressBar.Value = _player.stats.currentHitPoints;
                ManaProgressBar.Maximum = _player.stats.maxManaPoints;
                ManaProgressBar.Value = _player.stats.currentManaPoints;
                long prevExperience = _player.GetExperienceNeededForLevel(_player.stats.level - 1);
                int expPercentage = (int)(
                ((_player.stats.playerExperience - prevExperience * 100)
                / ((_player.stats.ExperienceRequired - prevExperience))
                ));
                loginWindow.GamePanelPlayerExperienceAmountPercentLabel.Text = $"{expPercentage}%";
                loginWindow.enterExperienceData.Text = $"{_player.stats.playerExperience} / {_player.stats.ExperienceRequired}";
                if (expPercentage <= 100 && expPercentage >= 0)
                {
                    loginWindow.ExperienceProgressBar.Value = expPercentage;
                }
                GamePanelPlayerAvatar.BackgroundImage = CharacterSelectAvatarImage.Image;
                GamePanelPlayerLevelRaceClassLabel.Text = CharacterSelectCharacterInfo.Text;
                GamePanelPlayerNameLabel.Text = CharacterSelectDropdownBox.Text;
            };
            Invoke(Char3);
        }

        private void GamePanelPlayerSkillsButton_Click(object sender, EventArgs e)
        {
            if (SkillsPanel.Visible == false)
            {
                //int damage = (playerLevel / 5) + (((int)((3.25f * playerWeapon)) * (playerStrength)) / 28);
                enterStrengthData.Text = Convert.ToString(players[Client.instance.myId].stats.strength);
                enterDexterityData.Text = Convert.ToString(players[Client.instance.myId].stats.dexterity);
                enterConstitutionData.Text = Convert.ToString(players[Client.instance.myId].stats.constitution);
                enterIntellectData.Text = Convert.ToString(players[Client.instance.myId].stats.intellect);
                enterWisdomData.Text = Convert.ToString(players[Client.instance.myId].stats.wisdom);
                enterCharismaData.Text = Convert.ToString(players[Client.instance.myId].stats.charisma);
                enterExperienceData.Text = Convert.ToString($"{players[Client.instance.myId].stats.playerExperience} / {players[Client.instance.myId].stats.ExperienceRequired}");
                enterSkillPointsData.Text = $" Skill Points Available : {Convert.ToString(players[Client.instance.myId].stats.playerSkillPoints)}";
                EnterCarryingWeightData.Text = Convert.ToString(players[Client.instance.myId].stats.playerCarryingWeight);
                SkillsPanel.Visible = true;
                SkillsPanel.Show();
                SkillsPanel.BringToFront();
                GamePanel.Focus();
            }
            else if (SkillsPanel.Visible == true)
            {
                SkillsPanel.Visible = false;
                SkillsPanel.Hide();
                GamePanel.Focus();
            }
        }

        private void AddSkillButton1_Click(object sender, EventArgs e) { if (players[Client.instance.myId].stats.playerSkillPoints > 0) { ClientSend.AddSkill(0); } GamePanel.Focus(); }
        private void AddSkillButton2_Click(object sender, EventArgs e) { if (players[Client.instance.myId].stats.playerSkillPoints > 0) { ClientSend.AddSkill(1); } GamePanel.Focus(); }
        private void AddSkillButton3_Click(object sender, EventArgs e) { if (players[Client.instance.myId].stats.playerSkillPoints > 0) { ClientSend.AddSkill(2); } GamePanel.Focus(); }
        private void AddSkillButton4_Click(object sender, EventArgs e) { if (players[Client.instance.myId].stats.playerSkillPoints > 0) { ClientSend.AddSkill(3); } GamePanel.Focus(); }
        private void AddSkillButton5_Click(object sender, EventArgs e) { if (players[Client.instance.myId].stats.playerSkillPoints > 0) { ClientSend.AddSkill(4); } GamePanel.Focus(); }
        private void AddSkillButton6_Click(object sender, EventArgs e) { if (players[Client.instance.myId].stats.playerSkillPoints > 0) { ClientSend.AddSkill(5); } GamePanel.Focus(); }

        private void DeleteCharacterButton_Click(object sender, EventArgs e)
        {
            string loginUsername = Username.Text;
            string loginPassword = Password.Text;
            string characterToDelete = CharacterSelectDropdownBox.Text;
            ClientSend.CharacterToDelete(loginUsername, loginPassword, characterToDelete);
            CharacterSelectPanel.Hide();
            CreateAccountPanel.Hide();
            CreateCharacterPanel.Hide();
            LoginPanel.Show();
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            string loginUsername = Username.Text;
            string loginPassword = Password.Text;
            ClientSend.AccountToDelete(loginUsername, loginPassword);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Client.instance.OnRejection();
            Application.Exit();
            Environment.Exit(0);
        }
        #region InventoryPanels
        private void MainInventoryButton_Click(object sender, EventArgs e)
        {
            if (InventoryPanel.Visible == false)
            {
                InventoryPanel.Visible = true;
                InventoryPanel.Show();
                InventoryPanel.BringToFront();
                GamePanel.Focus();
            }
            else if (InventoryPanel.Visible == true)
            {
                InventoryPanel.Visible = false;
                InventoryPanel.Hide();
                GamePanel.Focus();
            }

        }
        private void InventoryMovePanelButton_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel = true;
            button = sender as Button;
            if (button == null)
                return; //Some error/exception

            panel = button.Parent as Panel;
            if (panel == null)
            {
                //Parent container is not panel
            }
        }

        private void InventoryMovePanelButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MovePanel) { return; }
            if (panel != null)
            {
                if (AdventuresOnlineWindow.MousePosition.X < 1454 && AdventuresOnlineWindow.MousePosition.Y < 740)
                {
                    panel.Location = new Point(AdventuresOnlineWindow.MousePosition.X - 10, AdventuresOnlineWindow.MousePosition.Y - 35);
                }
                if (AdventuresOnlineWindow.MousePosition.X > 1454  && AdventuresOnlineWindow.MousePosition.Y > 529)
                {
                    return;
                }
                if (AdventuresOnlineWindow.MousePosition.X > 1454)
                {
                    panel.Location = new Point(1444, AdventuresOnlineWindow.MousePosition.Y - 35);
                }
                if (AdventuresOnlineWindow.MousePosition.Y > 529)
                {
                    panel.Location = new Point(AdventuresOnlineWindow.MousePosition.X - 10, 519);
                }
            }
            RelocateOpenInventoryPanels();
        }

        private void InventoryMovePanelButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!MovePanel) { return; }
            MovePanel = false;
            if (AdventuresOnlineWindow.MousePosition.X < 1454)
            {
                panel.Location = new Point(AdventuresOnlineWindow.MousePosition.X - 10, InventoryPanel.Location.Y);
                panel.BringToFront();
            }
            if (AdventuresOnlineWindow.MousePosition.Y < 529)
            {
                panel.Location = new Point(InventoryPanel.Location.X, AdventuresOnlineWindow.MousePosition.Y - 35);
                panel.BringToFront();
            }
            RelocateOpenInventoryPanels();
            panel = null;
        }
        void RelocateOpenInventoryPanels()
        {
            InventoryPanel2.Show();
            InventoryPanel2.Location = new Point(InventoryPanel.Location.X, InventoryPanel.Location.Y + InventoryPanel.Height);
        }
        private void InventorySizePanelButton_MouseDown(object sender, MouseEventArgs e)
        {
            ResizePanel = true;
            button = sender as Button;
            if (button == null)
                return; //Some error/exception

            panel = button.Parent as Panel;
            if (panel == null)
            {
                //Parent container is not panel
            }
        }
        private void InventorySizePanelButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ResizePanel) { return; }
            if (panel == null) { return; }
            Console.WriteLine($"Mouse Y is {e.Y}");
            panel.Height = e.Y + 313;
            RelocateOpenInventoryPanels();
        }
        private void InventorySizePanelButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!ResizePanel) { return; }
            if (panel == null) { return; }
            panel.Height = e.Y + 313;
            ResizePanel = false;
            panel = null;
            RelocateOpenInventoryPanels();
        }

        #endregion

        private void EquipmentButton_Click(object sender, EventArgs e)
        {
            if (EquipmentPanel.Visible == false)
            {
                EquipmentPanel.Visible = true;
                EquipmentPanel.Show();
                EquipmentPanel.BringToFront();
                GamePanel.Focus();
            }
            else if (EquipmentPanel.Visible == true)
            {
                EquipmentPanel.Visible = false;
                EquipmentPanel.Hide();
                GamePanel.Focus();
            }
        }
        
        private void GameRenderer_MouseDown(object sender, MouseEventArgs e)
        {
            ItemToPickUpLocation = new Vector2((CameraPosition.X + e.X - 672) / 96, (CameraPosition.Y + e.Y - 384) / 64);
            _itemToPickUp = TileMap.itemsAtPositions[(int)ItemToPickUpLocation.X, (int)ItemToPickUpLocation.Y].itemsAtPosition.LastOrDefault();
            if (_itemToPickUp != null)
            {
                Log.Info($"{_itemToPickUp.ID} {_itemToPickUp.Name} to be picked up.");
            }
        }

        private void GameRenderer_MouseUp(object sender, MouseEventArgs e)
        {
            if (_itemToPickUp != null)
            {
                focusedInventorySlot = FindControlAtCursor(this) as PictureBox;
                if (focusedInventorySlot != null)
                {
                    Log.Info($"{_itemToPickUp.ID} {_itemToPickUp.Name} to be placed at {focusedInventorySlot.Name}");
                    string inventorySlotPosition = new String(focusedInventorySlot.Name.Where(Char.IsDigit).ToArray());
                    ClientSend.ClientItemToPickUp(ItemToPickUpLocation, Convert.ToInt32(inventorySlotPosition), _itemToPickUp);
                    ItemToPickUpLocation = null;
                    focusedInventorySlot = null;
                    _itemToPickUp = null;
                }
            }
        }
        public static Control FindControlAtPoint(Control container, Point pos)
        {
            Control child;
            foreach (Control c in container.Controls)
            {
                if (c.Visible && c.Bounds.Contains(pos))
                {
                    child = FindControlAtPoint(c, new Point(pos.X - c.Left, pos.Y - c.Top));
                    if (child == null) return c;
                    else return child;
                }
            }
            return null;
        }

        public static Control FindControlAtCursor(Form form)
        {
            Point pos = Cursor.Position;
            if (form.Bounds.Contains(pos))
                return FindControlAtPoint(form, form.PointToClient(pos));
            return null;
        }
    }
}
