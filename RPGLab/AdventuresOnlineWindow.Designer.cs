
using RPGLab.RPGLab;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPGLab.Networking
{
    partial class AdventuresOnlineWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventuresOnlineWindow));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoadingStartBar = new System.Windows.Forms.ProgressBar();
            this.LoadingBarLabel = new System.Windows.Forms.Label();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.LoginLabelAccountInfoBoolean = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.CreateCharacterPanel = new System.Windows.Forms.Panel();
            this.CreateCharacterRejectionLabel = new System.Windows.Forms.Label();
            this.CreateCharacterRaceRightButton = new System.Windows.Forms.Button();
            this.CreateCharacterClassRightButton = new System.Windows.Forms.Button();
            this.CreateCharacterClassLeftButton = new System.Windows.Forms.Button();
            this.CreateCharacterRaceLeftButton = new System.Windows.Forms.Button();
            this.CreateCharacterAvatarLabel = new System.Windows.Forms.Label();
            this.CreateCharacterAvatarRightButton = new System.Windows.Forms.Button();
            this.CreateCharacterAvatarLeftButton = new System.Windows.Forms.Button();
            this.CreateCharacterAvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.CreateCharacterClass = new System.Windows.Forms.TextBox();
            this.CreateCharacterRace = new System.Windows.Forms.TextBox();
            this.CreateCharacterClassLabel = new System.Windows.Forms.Label();
            this.CreateCharacterCancelButton = new System.Windows.Forms.Button();
            this.CreateCharacterButton = new System.Windows.Forms.Button();
            this.CreateCharacterPlayerNameLabel = new System.Windows.Forms.Label();
            this.CreateCharacterRaceLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CreateCharacterName = new System.Windows.Forms.TextBox();
            this.CharacterSelectPanel = new System.Windows.Forms.Panel();
            this.DeleteCharacterButton = new System.Windows.Forms.Button();
            this.CharacterSelectLogOffButton = new System.Windows.Forms.Button();
            this.CharacterSelectDropdownBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CharacterSelectAvatarImage = new System.Windows.Forms.PictureBox();
            this.CharacterSelectCreateCharacterButton = new System.Windows.Forms.Button();
            this.CharacterSelectConnectButton = new System.Windows.Forms.Button();
            this.CharacterSelectCharacterInfo = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CreateAccountPanel = new System.Windows.Forms.Panel();
            this.CreateAccountRejectionLabel = new System.Windows.Forms.Label();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.CreateAccountCancelButton = new System.Windows.Forms.Button();
            this.CreateAccountButtonSendtoServer = new System.Windows.Forms.Button();
            this.CreateAccountUsernameLabel = new System.Windows.Forms.Label();
            this.CreateAccountPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateAccountPassword = new System.Windows.Forms.TextBox();
            this.CreateAccountUsername = new System.Windows.Forms.TextBox();
            this.HumanImageList = new System.Windows.Forms.ImageList(this.components);
            this.HalflingImageList = new System.Windows.Forms.ImageList(this.components);
            this.GnomeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ElfImageList = new System.Windows.Forms.ImageList(this.components);
            this.DwarfImageList = new System.Windows.Forms.ImageList(this.components);
            this.DragonbornImageList = new System.Windows.Forms.ImageList(this.components);
            this.GoblinImageList = new System.Windows.Forms.ImageList(this.components);
            this.HalfElfImageList = new System.Windows.Forms.ImageList(this.components);
            this.GamePanelPlayerAvatar = new System.Windows.Forms.PictureBox();
            this.GamePanelPlayerNameLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerLevelRaceClassLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerHealthLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerManaLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerExperienceLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerHealthAmountLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerManaAmountLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerExperienceAmountPercentLabel = new System.Windows.Forms.Label();
            this.GamePanelPlayerSkillsButton = new System.Windows.Forms.Button();
            this.MainInventoryButton = new System.Windows.Forms.Button();
            this.EquipmentButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.GameChatBox = new System.Windows.Forms.ListBox();
            this.GameChatTextBox = new System.Windows.Forms.TextBox();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.ExperienceProgressBar = new System.Windows.Forms.ProgressBar();
            this.ManaProgressBar = new System.Windows.Forms.ProgressBar();
            this.HealthProgressBar = new System.Windows.Forms.ProgressBar();
            this.GameRenderer = new System.Windows.Forms.PictureBox();
            this.SkillsPanel = new System.Windows.Forms.Panel();
            this.AddSkillButton6 = new System.Windows.Forms.Button();
            this.AddSkillButton5 = new System.Windows.Forms.Button();
            this.AddSkillButton4 = new System.Windows.Forms.Button();
            this.AddSkillButton3 = new System.Windows.Forms.Button();
            this.AddSkillButton2 = new System.Windows.Forms.Button();
            this.AddSkillButton1 = new System.Windows.Forms.Button();
            this.enterSkillPointsData = new System.Windows.Forms.Label();
            this.enterCharismaData = new System.Windows.Forms.Label();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.enterWisdomData = new System.Windows.Forms.Label();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.enterIntellectData = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.enterConstitutionData = new System.Windows.Forms.Label();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.enterDexterityData = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.enterStrengthData = new System.Windows.Forms.Label();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.EnterCarryingWeightData = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.enterExperienceData = new System.Windows.Forms.Label();
            this.xpToLevelLabel = new System.Windows.Forms.Label();
            this.InventoryPanel = new System.Windows.Forms.Panel();
            this.InventoryPictureBox20 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox19 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox18 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox17 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox16 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox15 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox14 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox13 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox12 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox11 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox10 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox5 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox9 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox8 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox4 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox7 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox3 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox6 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox2 = new System.Windows.Forms.PictureBox();
            this.InventoryPictureBox1 = new System.Windows.Forms.PictureBox();
            this.EquipmentPanel = new System.Windows.Forms.Panel();
            this.FeetSlot = new System.Windows.Forms.PictureBox();
            this.AmmoSlot = new System.Windows.Forms.PictureBox();
            this.LegsSlot = new System.Windows.Forms.PictureBox();
            this.RingSlot = new System.Windows.Forms.PictureBox();
            this.OffHandSlot = new System.Windows.Forms.PictureBox();
            this.ChestSlot = new System.Windows.Forms.PictureBox();
            this.BackpackSlot = new System.Windows.Forms.PictureBox();
            this.MainWeaponSlot = new System.Windows.Forms.PictureBox();
            this.HeadSlot = new System.Windows.Forms.PictureBox();
            this.AmuletSlot = new System.Windows.Forms.PictureBox();
            this.MainMapImageList = new System.Windows.Forms.ImageList(this.components);
            this.monsterImageList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CreateCharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateCharacterAvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.CharacterSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterSelectAvatarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.CreateAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanelPlayerAvatar)).BeginInit();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameRenderer)).BeginInit();
            this.SkillsPanel.SuspendLayout();
            this.InventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox1)).BeginInit();
            this.EquipmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeetSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegsSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RingSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffHandSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpackSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWeaponSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmuletSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.LoadingStartBar);
            this.LoginPanel.Controls.Add(this.LoadingBarLabel);
            this.LoginPanel.Controls.Add(this.DeleteAccountButton);
            this.LoginPanel.Controls.Add(this.LoginLabelAccountInfoBoolean);
            this.LoginPanel.Controls.Add(this.CreateAccountButton);
            this.LoginPanel.Controls.Add(this.ConnectButton);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.Password);
            this.LoginPanel.Controls.Add(this.Username);
            this.LoginPanel.Location = new System.Drawing.Point(12, 10);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1900, 1019);
            this.LoginPanel.TabIndex = 0;
            // 
            // LoadingStartBar
            // 
            this.LoadingStartBar.Location = new System.Drawing.Point(777, 900);
            this.LoadingStartBar.Name = "LoadingStartBar";
            this.LoadingStartBar.Size = new System.Drawing.Size(336, 33);
            this.LoadingStartBar.TabIndex = 10;
            // 
            // LoadingBarLabel
            // 
            this.LoadingBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingBarLabel.Location = new System.Drawing.Point(895, 790);
            this.LoadingBarLabel.Name = "LoadingBarLabel";
            this.LoadingBarLabel.Size = new System.Drawing.Size(283, 101);
            this.LoadingBarLabel.TabIndex = 11;
            this.LoadingBarLabel.Text = "Loading....";
            this.LoadingBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteAccountButton.BackgroundImage")));
            this.DeleteAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteAccountButton.FlatAppearance.BorderSize = 0;
            this.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccountButton.Location = new System.Drawing.Point(3, 976);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(200, 41);
            this.DeleteAccountButton.TabIndex = 11;
            this.DeleteAccountButton.Tag = "LoginAccessoriesVisible";
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // LoginLabelAccountInfoBoolean
            // 
            this.LoginLabelAccountInfoBoolean.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabelAccountInfoBoolean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabelAccountInfoBoolean.ForeColor = System.Drawing.Color.Red;
            this.LoginLabelAccountInfoBoolean.Location = new System.Drawing.Point(465, 673);
            this.LoginLabelAccountInfoBoolean.MinimumSize = new System.Drawing.Size(200, 30);
            this.LoginLabelAccountInfoBoolean.Name = "LoginLabelAccountInfoBoolean";
            this.LoginLabelAccountInfoBoolean.Size = new System.Drawing.Size(1000, 100);
            this.LoginLabelAccountInfoBoolean.TabIndex = 9;
            this.LoginLabelAccountInfoBoolean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateAccountButton.BackgroundImage")));
            this.CreateAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateAccountButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.Location = new System.Drawing.Point(1677, 973);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(200, 41);
            this.CreateAccountButton.TabIndex = 6;
            this.CreateAccountButton.Tag = "LoginAccessoriesVisible";
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.GotoCreateAccountPanelButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConnectButton.BackgroundImage")));
            this.ConnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(844, 601);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(200, 59);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Tag = "LoginAccessoriesVisible";
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.UsernameLabel.Location = new System.Drawing.Point(699, 469);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(119, 26);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Tag = "LoginAccessoriesVisible";
            this.UsernameLabel.Text = "Username :";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(699, 525);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(120, 26);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Tag = "LoginAccessoriesVisible";
            this.PasswordLabel.Text = "Password : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1873, 362);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(844, 525);
            this.Password.MinimumSize = new System.Drawing.Size(200, 30);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(200, 30);
            this.Password.TabIndex = 1;
            this.Password.Tag = "LoginAccessoriesVisible";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(844, 466);
            this.Username.MinimumSize = new System.Drawing.Size(200, 30);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(200, 30);
            this.Username.TabIndex = 0;
            this.Username.Tag = "LoginAccessoriesVisible";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateCharacterPanel
            // 
            this.CreateCharacterPanel.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterRejectionLabel);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterRaceRightButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterClassRightButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterClassLeftButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterRaceLeftButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterAvatarLabel);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterAvatarRightButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterAvatarLeftButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterAvatarPictureBox);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterClass);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterRace);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterClassLabel);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterCancelButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterButton);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterPlayerNameLabel);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterRaceLabel);
            this.CreateCharacterPanel.Controls.Add(this.pictureBox3);
            this.CreateCharacterPanel.Controls.Add(this.CreateCharacterName);
            this.CreateCharacterPanel.Location = new System.Drawing.Point(12, 12);
            this.CreateCharacterPanel.Name = "CreateCharacterPanel";
            this.CreateCharacterPanel.Size = new System.Drawing.Size(1880, 1017);
            this.CreateCharacterPanel.TabIndex = 7;
            this.CreateCharacterPanel.Visible = false;
            // 
            // CreateCharacterRejectionLabel
            // 
            this.CreateCharacterRejectionLabel.AutoSize = true;
            this.CreateCharacterRejectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacterRejectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterRejectionLabel.ForeColor = System.Drawing.Color.Red;
            this.CreateCharacterRejectionLabel.Location = new System.Drawing.Point(744, 838);
            this.CreateCharacterRejectionLabel.MinimumSize = new System.Drawing.Size(400, 30);
            this.CreateCharacterRejectionLabel.Name = "CreateCharacterRejectionLabel";
            this.CreateCharacterRejectionLabel.Size = new System.Drawing.Size(400, 30);
            this.CreateCharacterRejectionLabel.TabIndex = 18;
            this.CreateCharacterRejectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateCharacterRaceRightButton
            // 
            this.CreateCharacterRaceRightButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCharacterRaceRightButton.Location = new System.Drawing.Point(1054, 513);
            this.CreateCharacterRaceRightButton.Name = "CreateCharacterRaceRightButton";
            this.CreateCharacterRaceRightButton.Size = new System.Drawing.Size(35, 28);
            this.CreateCharacterRaceRightButton.TabIndex = 17;
            this.CreateCharacterRaceRightButton.Text = ">>";
            this.CreateCharacterRaceRightButton.UseVisualStyleBackColor = true;
            this.CreateCharacterRaceRightButton.Click += new System.EventHandler(this.CreateCharacterRaceRightButton_Click);
            // 
            // CreateCharacterClassRightButton
            // 
            this.CreateCharacterClassRightButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCharacterClassRightButton.Location = new System.Drawing.Point(1054, 569);
            this.CreateCharacterClassRightButton.Name = "CreateCharacterClassRightButton";
            this.CreateCharacterClassRightButton.Size = new System.Drawing.Size(35, 28);
            this.CreateCharacterClassRightButton.TabIndex = 16;
            this.CreateCharacterClassRightButton.Text = ">>";
            this.CreateCharacterClassRightButton.UseVisualStyleBackColor = true;
            this.CreateCharacterClassRightButton.Click += new System.EventHandler(this.CreateCharacterClassRightButton_Click);
            // 
            // CreateCharacterClassLeftButton
            // 
            this.CreateCharacterClassLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCharacterClassLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterClassLeftButton.Location = new System.Drawing.Point(807, 569);
            this.CreateCharacterClassLeftButton.Name = "CreateCharacterClassLeftButton";
            this.CreateCharacterClassLeftButton.Size = new System.Drawing.Size(35, 28);
            this.CreateCharacterClassLeftButton.TabIndex = 15;
            this.CreateCharacterClassLeftButton.Text = "<<";
            this.CreateCharacterClassLeftButton.UseVisualStyleBackColor = true;
            this.CreateCharacterClassLeftButton.Click += new System.EventHandler(this.CreateCharacterClassLeftButton_Click);
            // 
            // CreateCharacterRaceLeftButton
            // 
            this.CreateCharacterRaceLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCharacterRaceLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterRaceLeftButton.Location = new System.Drawing.Point(807, 514);
            this.CreateCharacterRaceLeftButton.Name = "CreateCharacterRaceLeftButton";
            this.CreateCharacterRaceLeftButton.Size = new System.Drawing.Size(35, 28);
            this.CreateCharacterRaceLeftButton.TabIndex = 14;
            this.CreateCharacterRaceLeftButton.Text = "<<";
            this.CreateCharacterRaceLeftButton.UseVisualStyleBackColor = true;
            this.CreateCharacterRaceLeftButton.Click += new System.EventHandler(this.CreateCharacterRaceLeftButton_Click);
            // 
            // CreateCharacterAvatarLabel
            // 
            this.CreateCharacterAvatarLabel.AutoSize = true;
            this.CreateCharacterAvatarLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacterAvatarLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateCharacterAvatarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterAvatarLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateCharacterAvatarLabel.Location = new System.Drawing.Point(654, 640);
            this.CreateCharacterAvatarLabel.Name = "CreateCharacterAvatarLabel";
            this.CreateCharacterAvatarLabel.Size = new System.Drawing.Size(148, 26);
            this.CreateCharacterAvatarLabel.TabIndex = 13;
            this.CreateCharacterAvatarLabel.Text = "Avatar :           ";
            // 
            // CreateCharacterAvatarRightButton
            // 
            this.CreateCharacterAvatarRightButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCharacterAvatarRightButton.Location = new System.Drawing.Point(986, 640);
            this.CreateCharacterAvatarRightButton.Name = "CreateCharacterAvatarRightButton";
            this.CreateCharacterAvatarRightButton.Size = new System.Drawing.Size(35, 28);
            this.CreateCharacterAvatarRightButton.TabIndex = 12;
            this.CreateCharacterAvatarRightButton.Text = ">>";
            this.CreateCharacterAvatarRightButton.UseVisualStyleBackColor = true;
            this.CreateCharacterAvatarRightButton.Click += new System.EventHandler(this.CreateCharacterAvatarRightButton_Click);
            // 
            // CreateCharacterAvatarLeftButton
            // 
            this.CreateCharacterAvatarLeftButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateCharacterAvatarLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterAvatarLeftButton.Location = new System.Drawing.Point(875, 640);
            this.CreateCharacterAvatarLeftButton.Name = "CreateCharacterAvatarLeftButton";
            this.CreateCharacterAvatarLeftButton.Size = new System.Drawing.Size(35, 28);
            this.CreateCharacterAvatarLeftButton.TabIndex = 11;
            this.CreateCharacterAvatarLeftButton.Text = "<<";
            this.CreateCharacterAvatarLeftButton.UseVisualStyleBackColor = true;
            this.CreateCharacterAvatarLeftButton.Click += new System.EventHandler(this.CreateCharacterAvatarLeftButton_Click);
            // 
            // CreateCharacterAvatarPictureBox
            // 
            this.CreateCharacterAvatarPictureBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.CreateCharacterAvatarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CreateCharacterAvatarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateCharacterAvatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CreateCharacterAvatarPictureBox.Image")));
            this.CreateCharacterAvatarPictureBox.Location = new System.Drawing.Point(916, 623);
            this.CreateCharacterAvatarPictureBox.Name = "CreateCharacterAvatarPictureBox";
            this.CreateCharacterAvatarPictureBox.Size = new System.Drawing.Size(64, 64);
            this.CreateCharacterAvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CreateCharacterAvatarPictureBox.TabIndex = 10;
            this.CreateCharacterAvatarPictureBox.TabStop = false;
            // 
            // CreateCharacterClass
            // 
            this.CreateCharacterClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterClass.Location = new System.Drawing.Point(848, 568);
            this.CreateCharacterClass.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateCharacterClass.Name = "CreateCharacterClass";
            this.CreateCharacterClass.ReadOnly = true;
            this.CreateCharacterClass.Size = new System.Drawing.Size(200, 30);
            this.CreateCharacterClass.TabIndex = 9;
            this.CreateCharacterClass.Text = "Fighter";
            this.CreateCharacterClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateCharacterRace
            // 
            this.CreateCharacterRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterRace.Location = new System.Drawing.Point(848, 512);
            this.CreateCharacterRace.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateCharacterRace.Name = "CreateCharacterRace";
            this.CreateCharacterRace.ReadOnly = true;
            this.CreateCharacterRace.Size = new System.Drawing.Size(200, 30);
            this.CreateCharacterRace.TabIndex = 8;
            this.CreateCharacterRace.Text = "Human";
            this.CreateCharacterRace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateCharacterClassLabel
            // 
            this.CreateCharacterClassLabel.AutoSize = true;
            this.CreateCharacterClassLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacterClassLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateCharacterClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterClassLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateCharacterClassLabel.Location = new System.Drawing.Point(654, 571);
            this.CreateCharacterClassLabel.Name = "CreateCharacterClassLabel";
            this.CreateCharacterClassLabel.Size = new System.Drawing.Size(146, 26);
            this.CreateCharacterClassLabel.TabIndex = 7;
            this.CreateCharacterClassLabel.Text = "Class :            ";
            // 
            // CreateCharacterCancelButton
            // 
            this.CreateCharacterCancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateCharacterCancelButton.BackgroundImage")));
            this.CreateCharacterCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateCharacterCancelButton.FlatAppearance.BorderSize = 0;
            this.CreateCharacterCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCharacterCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterCancelButton.Location = new System.Drawing.Point(1677, 973);
            this.CreateCharacterCancelButton.Name = "CreateCharacterCancelButton";
            this.CreateCharacterCancelButton.Size = new System.Drawing.Size(200, 41);
            this.CreateCharacterCancelButton.TabIndex = 6;
            this.CreateCharacterCancelButton.Text = "Cancel";
            this.CreateCharacterCancelButton.UseVisualStyleBackColor = true;
            this.CreateCharacterCancelButton.Click += new System.EventHandler(this.CreateCharacterPanelButtonCancel_Click);
            // 
            // CreateCharacterButton
            // 
            this.CreateCharacterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateCharacterButton.BackgroundImage")));
            this.CreateCharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateCharacterButton.FlatAppearance.BorderSize = 0;
            this.CreateCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterButton.Location = new System.Drawing.Point(848, 716);
            this.CreateCharacterButton.Name = "CreateCharacterButton";
            this.CreateCharacterButton.Size = new System.Drawing.Size(200, 59);
            this.CreateCharacterButton.TabIndex = 5;
            this.CreateCharacterButton.Text = "Create Character";
            this.CreateCharacterButton.UseVisualStyleBackColor = true;
            this.CreateCharacterButton.Click += new System.EventHandler(this.CreateCharacterPanelButtonSendToServer_Click);
            // 
            // CreateCharacterPlayerNameLabel
            // 
            this.CreateCharacterPlayerNameLabel.AutoSize = true;
            this.CreateCharacterPlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacterPlayerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateCharacterPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterPlayerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateCharacterPlayerNameLabel.Location = new System.Drawing.Point(654, 459);
            this.CreateCharacterPlayerNameLabel.Name = "CreateCharacterPlayerNameLabel";
            this.CreateCharacterPlayerNameLabel.Size = new System.Drawing.Size(143, 26);
            this.CreateCharacterPlayerNameLabel.TabIndex = 4;
            this.CreateCharacterPlayerNameLabel.Text = "Player Name :";
            // 
            // CreateCharacterRaceLabel
            // 
            this.CreateCharacterRaceLabel.AutoSize = true;
            this.CreateCharacterRaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateCharacterRaceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateCharacterRaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterRaceLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateCharacterRaceLabel.Location = new System.Drawing.Point(653, 515);
            this.CreateCharacterRaceLabel.Name = "CreateCharacterRaceLabel";
            this.CreateCharacterRaceLabel.Size = new System.Drawing.Size(144, 26);
            this.CreateCharacterRaceLabel.TabIndex = 3;
            this.CreateCharacterRaceLabel.Text = "Race :            ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1873, 362);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // CreateCharacterName
            // 
            this.CreateCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCharacterName.Location = new System.Drawing.Point(848, 456);
            this.CreateCharacterName.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateCharacterName.Name = "CreateCharacterName";
            this.CreateCharacterName.Size = new System.Drawing.Size(200, 30);
            this.CreateCharacterName.TabIndex = 0;
            this.CreateCharacterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharacterSelectPanel
            // 
            this.CharacterSelectPanel.BackColor = System.Drawing.Color.Transparent;
            this.CharacterSelectPanel.Controls.Add(this.DeleteCharacterButton);
            this.CharacterSelectPanel.Controls.Add(this.CharacterSelectLogOffButton);
            this.CharacterSelectPanel.Controls.Add(this.CharacterSelectDropdownBox);
            this.CharacterSelectPanel.Controls.Add(this.button1);
            this.CharacterSelectPanel.Controls.Add(this.button2);
            this.CharacterSelectPanel.Controls.Add(this.CharacterSelectAvatarImage);
            this.CharacterSelectPanel.Controls.Add(this.CharacterSelectCreateCharacterButton);
            this.CharacterSelectPanel.Controls.Add(this.CharacterSelectConnectButton);
            this.CharacterSelectPanel.Controls.Add(this.CharacterSelectCharacterInfo);
            this.CharacterSelectPanel.Controls.Add(this.pictureBox5);
            this.CharacterSelectPanel.Location = new System.Drawing.Point(12, 12);
            this.CharacterSelectPanel.Name = "CharacterSelectPanel";
            this.CharacterSelectPanel.Size = new System.Drawing.Size(1880, 1017);
            this.CharacterSelectPanel.TabIndex = 14;
            this.CharacterSelectPanel.Visible = false;
            // 
            // DeleteCharacterButton
            // 
            this.DeleteCharacterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteCharacterButton.BackgroundImage")));
            this.DeleteCharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteCharacterButton.FlatAppearance.BorderSize = 0;
            this.DeleteCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCharacterButton.Location = new System.Drawing.Point(844, 973);
            this.DeleteCharacterButton.Name = "DeleteCharacterButton";
            this.DeleteCharacterButton.Size = new System.Drawing.Size(200, 41);
            this.DeleteCharacterButton.TabIndex = 16;
            this.DeleteCharacterButton.Text = "Delete Character";
            this.DeleteCharacterButton.UseVisualStyleBackColor = true;
            this.DeleteCharacterButton.Click += new System.EventHandler(this.DeleteCharacterButton_Click);
            // 
            // CharacterSelectLogOffButton
            // 
            this.CharacterSelectLogOffButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterSelectLogOffButton.BackgroundImage")));
            this.CharacterSelectLogOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterSelectLogOffButton.FlatAppearance.BorderSize = 0;
            this.CharacterSelectLogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterSelectLogOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSelectLogOffButton.Location = new System.Drawing.Point(4, 973);
            this.CharacterSelectLogOffButton.Name = "CharacterSelectLogOffButton";
            this.CharacterSelectLogOffButton.Size = new System.Drawing.Size(200, 41);
            this.CharacterSelectLogOffButton.TabIndex = 15;
            this.CharacterSelectLogOffButton.Text = "Log Off";
            this.CharacterSelectLogOffButton.UseVisualStyleBackColor = true;
            this.CharacterSelectLogOffButton.Click += new System.EventHandler(this.CharacterSelectLogOffButton_Click);
            // 
            // CharacterSelectDropdownBox
            // 
            this.CharacterSelectDropdownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSelectDropdownBox.FormattingEnabled = true;
            this.CharacterSelectDropdownBox.Location = new System.Drawing.Point(848, 567);
            this.CharacterSelectDropdownBox.Name = "CharacterSelectDropdownBox";
            this.CharacterSelectDropdownBox.Size = new System.Drawing.Size(200, 32);
            this.CharacterSelectDropdownBox.TabIndex = 14;
            this.CharacterSelectDropdownBox.SelectedValueChanged += new System.EventHandler(this.showSelectedDropdown_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(986, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(875, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CharacterSelectAvatarImage
            // 
            this.CharacterSelectAvatarImage.BackColor = System.Drawing.Color.MidnightBlue;
            this.CharacterSelectAvatarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CharacterSelectAvatarImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CharacterSelectAvatarImage.Image = ((System.Drawing.Image)(resources.GetObject("CharacterSelectAvatarImage.Image")));
            this.CharacterSelectAvatarImage.Location = new System.Drawing.Point(916, 431);
            this.CharacterSelectAvatarImage.Name = "CharacterSelectAvatarImage";
            this.CharacterSelectAvatarImage.Size = new System.Drawing.Size(64, 64);
            this.CharacterSelectAvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CharacterSelectAvatarImage.TabIndex = 10;
            this.CharacterSelectAvatarImage.TabStop = false;
            // 
            // CharacterSelectCreateCharacterButton
            // 
            this.CharacterSelectCreateCharacterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterSelectCreateCharacterButton.BackgroundImage")));
            this.CharacterSelectCreateCharacterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterSelectCreateCharacterButton.FlatAppearance.BorderSize = 0;
            this.CharacterSelectCreateCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterSelectCreateCharacterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSelectCreateCharacterButton.Location = new System.Drawing.Point(1677, 973);
            this.CharacterSelectCreateCharacterButton.Name = "CharacterSelectCreateCharacterButton";
            this.CharacterSelectCreateCharacterButton.Size = new System.Drawing.Size(200, 41);
            this.CharacterSelectCreateCharacterButton.TabIndex = 6;
            this.CharacterSelectCreateCharacterButton.Text = "Create Character";
            this.CharacterSelectCreateCharacterButton.UseVisualStyleBackColor = true;
            this.CharacterSelectCreateCharacterButton.Click += new System.EventHandler(this.GotoCreateCharacterPanelButton_Click);
            // 
            // CharacterSelectConnectButton
            // 
            this.CharacterSelectConnectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterSelectConnectButton.BackgroundImage")));
            this.CharacterSelectConnectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CharacterSelectConnectButton.FlatAppearance.BorderSize = 0;
            this.CharacterSelectConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterSelectConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSelectConnectButton.Location = new System.Drawing.Point(848, 647);
            this.CharacterSelectConnectButton.Name = "CharacterSelectConnectButton";
            this.CharacterSelectConnectButton.Size = new System.Drawing.Size(200, 59);
            this.CharacterSelectConnectButton.TabIndex = 5;
            this.CharacterSelectConnectButton.Text = "CONNECT";
            this.CharacterSelectConnectButton.UseVisualStyleBackColor = true;
            this.CharacterSelectConnectButton.Click += new System.EventHandler(this.CharacterSelectConnectButton_Click);
            // 
            // CharacterSelectCharacterInfo
            // 
            this.CharacterSelectCharacterInfo.AutoSize = true;
            this.CharacterSelectCharacterInfo.BackColor = System.Drawing.Color.Transparent;
            this.CharacterSelectCharacterInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CharacterSelectCharacterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterSelectCharacterInfo.ForeColor = System.Drawing.Color.Black;
            this.CharacterSelectCharacterInfo.Location = new System.Drawing.Point(832, 518);
            this.CharacterSelectCharacterInfo.MinimumSize = new System.Drawing.Size(230, 26);
            this.CharacterSelectCharacterInfo.Name = "CharacterSelectCharacterInfo";
            this.CharacterSelectCharacterInfo.Size = new System.Drawing.Size(230, 26);
            this.CharacterSelectCharacterInfo.TabIndex = 4;
            this.CharacterSelectCharacterInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1873, 362);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // CreateAccountPanel
            // 
            this.CreateAccountPanel.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountPanel.Controls.Add(this.CreateAccountRejectionLabel);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountLabel);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountCancelButton);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountButtonSendtoServer);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountUsernameLabel);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountPasswordLabel);
            this.CreateAccountPanel.Controls.Add(this.pictureBox1);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountPassword);
            this.CreateAccountPanel.Controls.Add(this.CreateAccountUsername);
            this.CreateAccountPanel.Location = new System.Drawing.Point(12, 12);
            this.CreateAccountPanel.Name = "CreateAccountPanel";
            this.CreateAccountPanel.Size = new System.Drawing.Size(1880, 1017);
            this.CreateAccountPanel.TabIndex = 7;
            this.CreateAccountPanel.Visible = false;
            // 
            // CreateAccountRejectionLabel
            // 
            this.CreateAccountRejectionLabel.AutoSize = true;
            this.CreateAccountRejectionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountRejectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountRejectionLabel.ForeColor = System.Drawing.Color.Red;
            this.CreateAccountRejectionLabel.Location = new System.Drawing.Point(844, 700);
            this.CreateAccountRejectionLabel.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateAccountRejectionLabel.Name = "CreateAccountRejectionLabel";
            this.CreateAccountRejectionLabel.Size = new System.Drawing.Size(200, 30);
            this.CreateAccountRejectionLabel.TabIndex = 8;
            this.CreateAccountRejectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateAccountLabel.Location = new System.Drawing.Point(844, 419);
            this.CreateAccountLabel.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(200, 30);
            this.CreateAccountLabel.TabIndex = 7;
            this.CreateAccountLabel.Text = "Create Account";
            this.CreateAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateAccountCancelButton
            // 
            this.CreateAccountCancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateAccountCancelButton.BackgroundImage")));
            this.CreateAccountCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateAccountCancelButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountCancelButton.Location = new System.Drawing.Point(1677, 973);
            this.CreateAccountCancelButton.Name = "CreateAccountCancelButton";
            this.CreateAccountCancelButton.Size = new System.Drawing.Size(200, 41);
            this.CreateAccountCancelButton.TabIndex = 6;
            this.CreateAccountCancelButton.Text = "Cancel";
            this.CreateAccountCancelButton.UseVisualStyleBackColor = true;
            this.CreateAccountCancelButton.Click += new System.EventHandler(this.CreateAccountCancelButton_Click);
            // 
            // CreateAccountButtonSendtoServer
            // 
            this.CreateAccountButtonSendtoServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateAccountButtonSendtoServer.BackgroundImage")));
            this.CreateAccountButtonSendtoServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateAccountButtonSendtoServer.FlatAppearance.BorderSize = 0;
            this.CreateAccountButtonSendtoServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButtonSendtoServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButtonSendtoServer.Location = new System.Drawing.Point(844, 601);
            this.CreateAccountButtonSendtoServer.Name = "CreateAccountButtonSendtoServer";
            this.CreateAccountButtonSendtoServer.Size = new System.Drawing.Size(200, 59);
            this.CreateAccountButtonSendtoServer.TabIndex = 5;
            this.CreateAccountButtonSendtoServer.Text = "CREATE ACCOUNT";
            this.CreateAccountButtonSendtoServer.UseVisualStyleBackColor = true;
            this.CreateAccountButtonSendtoServer.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // CreateAccountUsernameLabel
            // 
            this.CreateAccountUsernameLabel.AutoSize = true;
            this.CreateAccountUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountUsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateAccountUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountUsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateAccountUsernameLabel.Location = new System.Drawing.Point(699, 469);
            this.CreateAccountUsernameLabel.Name = "CreateAccountUsernameLabel";
            this.CreateAccountUsernameLabel.Size = new System.Drawing.Size(119, 26);
            this.CreateAccountUsernameLabel.TabIndex = 4;
            this.CreateAccountUsernameLabel.Text = "Username :";
            // 
            // CreateAccountPasswordLabel
            // 
            this.CreateAccountPasswordLabel.AutoSize = true;
            this.CreateAccountPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccountPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreateAccountPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateAccountPasswordLabel.Location = new System.Drawing.Point(699, 525);
            this.CreateAccountPasswordLabel.Name = "CreateAccountPasswordLabel";
            this.CreateAccountPasswordLabel.Size = new System.Drawing.Size(120, 26);
            this.CreateAccountPasswordLabel.TabIndex = 3;
            this.CreateAccountPasswordLabel.Text = "Password : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1873, 362);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CreateAccountPassword
            // 
            this.CreateAccountPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountPassword.Location = new System.Drawing.Point(844, 525);
            this.CreateAccountPassword.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateAccountPassword.Name = "CreateAccountPassword";
            this.CreateAccountPassword.PasswordChar = '*';
            this.CreateAccountPassword.Size = new System.Drawing.Size(200, 30);
            this.CreateAccountPassword.TabIndex = 1;
            this.CreateAccountPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateAccountUsername
            // 
            this.CreateAccountUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountUsername.Location = new System.Drawing.Point(844, 466);
            this.CreateAccountUsername.MinimumSize = new System.Drawing.Size(200, 30);
            this.CreateAccountUsername.Name = "CreateAccountUsername";
            this.CreateAccountUsername.Size = new System.Drawing.Size(200, 30);
            this.CreateAccountUsername.TabIndex = 0;
            this.CreateAccountUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HumanImageList
            // 
            this.HumanImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("HumanImageList.ImageStream")));
            this.HumanImageList.Tag = "Human";
            this.HumanImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.HumanImageList.Images.SetKeyName(0, "0.png");
            this.HumanImageList.Images.SetKeyName(1, "1.png");
            this.HumanImageList.Images.SetKeyName(2, "2.png");
            this.HumanImageList.Images.SetKeyName(3, "3.png");
            this.HumanImageList.Images.SetKeyName(4, "4.png");
            this.HumanImageList.Images.SetKeyName(5, "5.png");
            // 
            // HalflingImageList
            // 
            this.HalflingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("HalflingImageList.ImageStream")));
            this.HalflingImageList.Tag = "Halfling";
            this.HalflingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.HalflingImageList.Images.SetKeyName(0, "0.png");
            this.HalflingImageList.Images.SetKeyName(1, "0.png");
            this.HalflingImageList.Images.SetKeyName(2, "1.png");
            this.HalflingImageList.Images.SetKeyName(3, "2.png");
            this.HalflingImageList.Images.SetKeyName(4, "3.png");
            // 
            // GnomeImageList
            // 
            this.GnomeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("GnomeImageList.ImageStream")));
            this.GnomeImageList.Tag = "Gnome";
            this.GnomeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.GnomeImageList.Images.SetKeyName(0, "0.png");
            this.GnomeImageList.Images.SetKeyName(1, "1.png");
            this.GnomeImageList.Images.SetKeyName(2, "2.png");
            // 
            // ElfImageList
            // 
            this.ElfImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ElfImageList.ImageStream")));
            this.ElfImageList.Tag = "Elf";
            this.ElfImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ElfImageList.Images.SetKeyName(0, "0.png");
            this.ElfImageList.Images.SetKeyName(1, "1.png");
            this.ElfImageList.Images.SetKeyName(2, "2.png");
            this.ElfImageList.Images.SetKeyName(3, "3.png");
            this.ElfImageList.Images.SetKeyName(4, "4.png");
            // 
            // DwarfImageList
            // 
            this.DwarfImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DwarfImageList.ImageStream")));
            this.DwarfImageList.Tag = "Dwarf";
            this.DwarfImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DwarfImageList.Images.SetKeyName(0, "0.png");
            this.DwarfImageList.Images.SetKeyName(1, "1.png");
            this.DwarfImageList.Images.SetKeyName(2, "2.png");
            this.DwarfImageList.Images.SetKeyName(3, "3.png");
            this.DwarfImageList.Images.SetKeyName(4, "4.png");
            this.DwarfImageList.Images.SetKeyName(5, "5.png");
            // 
            // DragonbornImageList
            // 
            this.DragonbornImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("DragonbornImageList.ImageStream")));
            this.DragonbornImageList.Tag = "Dragonborn";
            this.DragonbornImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.DragonbornImageList.Images.SetKeyName(0, "0.png");
            this.DragonbornImageList.Images.SetKeyName(1, "1.png");
            this.DragonbornImageList.Images.SetKeyName(2, "2.png");
            this.DragonbornImageList.Images.SetKeyName(3, "3.png");
            this.DragonbornImageList.Images.SetKeyName(4, "4.png");
            this.DragonbornImageList.Images.SetKeyName(5, "5.png");
            this.DragonbornImageList.Images.SetKeyName(6, "6.png");
            this.DragonbornImageList.Images.SetKeyName(7, "7.png");
            this.DragonbornImageList.Images.SetKeyName(8, "8.png");
            this.DragonbornImageList.Images.SetKeyName(9, "9.png");
            this.DragonbornImageList.Images.SetKeyName(10, "10.png");
            this.DragonbornImageList.Images.SetKeyName(11, "11.png");
            this.DragonbornImageList.Images.SetKeyName(12, "12.png");
            this.DragonbornImageList.Images.SetKeyName(13, "13.png");
            // 
            // GoblinImageList
            // 
            this.GoblinImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("GoblinImageList.ImageStream")));
            this.GoblinImageList.Tag = "Goblin";
            this.GoblinImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.GoblinImageList.Images.SetKeyName(0, "0.png");
            this.GoblinImageList.Images.SetKeyName(1, "1.png");
            this.GoblinImageList.Images.SetKeyName(2, "2.png");
            this.GoblinImageList.Images.SetKeyName(3, "3.png");
            this.GoblinImageList.Images.SetKeyName(4, "4.png");
            // 
            // HalfElfImageList
            // 
            this.HalfElfImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("HalfElfImageList.ImageStream")));
            this.HalfElfImageList.Tag = "HalfElf";
            this.HalfElfImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.HalfElfImageList.Images.SetKeyName(0, "0.png");
            this.HalfElfImageList.Images.SetKeyName(1, "1.png");
            this.HalfElfImageList.Images.SetKeyName(2, "2.png");
            this.HalfElfImageList.Images.SetKeyName(3, "3.png");
            this.HalfElfImageList.Images.SetKeyName(4, "4.png");
            this.HalfElfImageList.Images.SetKeyName(5, "5.png");
            // 
            // GamePanelPlayerAvatar
            // 
            this.GamePanelPlayerAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePanelPlayerAvatar.BackgroundImage")));
            this.GamePanelPlayerAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamePanelPlayerAvatar.Location = new System.Drawing.Point(1448, -2);
            this.GamePanelPlayerAvatar.Name = "GamePanelPlayerAvatar";
            this.GamePanelPlayerAvatar.Size = new System.Drawing.Size(64, 64);
            this.GamePanelPlayerAvatar.TabIndex = 0;
            this.GamePanelPlayerAvatar.TabStop = false;
            // 
            // GamePanelPlayerNameLabel
            // 
            this.GamePanelPlayerNameLabel.AutoSize = true;
            this.GamePanelPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerNameLabel.Location = new System.Drawing.Point(1518, -2);
            this.GamePanelPlayerNameLabel.Name = "GamePanelPlayerNameLabel";
            this.GamePanelPlayerNameLabel.Size = new System.Drawing.Size(148, 31);
            this.GamePanelPlayerNameLabel.TabIndex = 0;
            this.GamePanelPlayerNameLabel.Text = "Caelaenor";
            // 
            // GamePanelPlayerLevelRaceClassLabel
            // 
            this.GamePanelPlayerLevelRaceClassLabel.AutoSize = true;
            this.GamePanelPlayerLevelRaceClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerLevelRaceClassLabel.Location = new System.Drawing.Point(1518, 39);
            this.GamePanelPlayerLevelRaceClassLabel.Name = "GamePanelPlayerLevelRaceClassLabel";
            this.GamePanelPlayerLevelRaceClassLabel.Size = new System.Drawing.Size(354, 25);
            this.GamePanelPlayerLevelRaceClassLabel.TabIndex = 0;
            this.GamePanelPlayerLevelRaceClassLabel.Text = "Level 999 Dragonborn Barbarian";
            // 
            // GamePanelPlayerHealthLabel
            // 
            this.GamePanelPlayerHealthLabel.AutoSize = true;
            this.GamePanelPlayerHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerHealthLabel.Location = new System.Drawing.Point(1444, 86);
            this.GamePanelPlayerHealthLabel.Name = "GamePanelPlayerHealthLabel";
            this.GamePanelPlayerHealthLabel.Size = new System.Drawing.Size(94, 25);
            this.GamePanelPlayerHealthLabel.TabIndex = 0;
            this.GamePanelPlayerHealthLabel.Text = "Health :";
            // 
            // GamePanelPlayerManaLabel
            // 
            this.GamePanelPlayerManaLabel.AutoSize = true;
            this.GamePanelPlayerManaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerManaLabel.Location = new System.Drawing.Point(1444, 128);
            this.GamePanelPlayerManaLabel.Name = "GamePanelPlayerManaLabel";
            this.GamePanelPlayerManaLabel.Size = new System.Drawing.Size(84, 25);
            this.GamePanelPlayerManaLabel.TabIndex = 0;
            this.GamePanelPlayerManaLabel.Text = "Mana :";
            // 
            // GamePanelPlayerExperienceLabel
            // 
            this.GamePanelPlayerExperienceLabel.AutoSize = true;
            this.GamePanelPlayerExperienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerExperienceLabel.Location = new System.Drawing.Point(1444, 168);
            this.GamePanelPlayerExperienceLabel.Name = "GamePanelPlayerExperienceLabel";
            this.GamePanelPlayerExperienceLabel.Size = new System.Drawing.Size(144, 25);
            this.GamePanelPlayerExperienceLabel.TabIndex = 0;
            this.GamePanelPlayerExperienceLabel.Text = "Experience :";
            // 
            // GamePanelPlayerHealthAmountLabel
            // 
            this.GamePanelPlayerHealthAmountLabel.AutoSize = true;
            this.GamePanelPlayerHealthAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerHealthAmountLabel.Location = new System.Drawing.Point(1783, 86);
            this.GamePanelPlayerHealthAmountLabel.Name = "GamePanelPlayerHealthAmountLabel";
            this.GamePanelPlayerHealthAmountLabel.Size = new System.Drawing.Size(64, 20);
            this.GamePanelPlayerHealthAmountLabel.TabIndex = 0;
            this.GamePanelPlayerHealthAmountLabel.Text = "50/100";
            // 
            // GamePanelPlayerManaAmountLabel
            // 
            this.GamePanelPlayerManaAmountLabel.AutoSize = true;
            this.GamePanelPlayerManaAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerManaAmountLabel.Location = new System.Drawing.Point(1783, 128);
            this.GamePanelPlayerManaAmountLabel.Name = "GamePanelPlayerManaAmountLabel";
            this.GamePanelPlayerManaAmountLabel.Size = new System.Drawing.Size(64, 20);
            this.GamePanelPlayerManaAmountLabel.TabIndex = 0;
            this.GamePanelPlayerManaAmountLabel.Text = "50/100";
            // 
            // GamePanelPlayerExperienceAmountPercentLabel
            // 
            this.GamePanelPlayerExperienceAmountPercentLabel.AutoSize = true;
            this.GamePanelPlayerExperienceAmountPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerExperienceAmountPercentLabel.Location = new System.Drawing.Point(1783, 168);
            this.GamePanelPlayerExperienceAmountPercentLabel.Name = "GamePanelPlayerExperienceAmountPercentLabel";
            this.GamePanelPlayerExperienceAmountPercentLabel.Size = new System.Drawing.Size(34, 20);
            this.GamePanelPlayerExperienceAmountPercentLabel.TabIndex = 0;
            this.GamePanelPlayerExperienceAmountPercentLabel.Text = "0%";
            // 
            // GamePanelPlayerSkillsButton
            // 
            this.GamePanelPlayerSkillsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePanelPlayerSkillsButton.BackgroundImage")));
            this.GamePanelPlayerSkillsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamePanelPlayerSkillsButton.CausesValidation = false;
            this.GamePanelPlayerSkillsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.GamePanelPlayerSkillsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GamePanelPlayerSkillsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GamePanelPlayerSkillsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePanelPlayerSkillsButton.Location = new System.Drawing.Point(1448, 247);
            this.GamePanelPlayerSkillsButton.Name = "GamePanelPlayerSkillsButton";
            this.GamePanelPlayerSkillsButton.Size = new System.Drawing.Size(88, 32);
            this.GamePanelPlayerSkillsButton.TabIndex = 0;
            this.GamePanelPlayerSkillsButton.TabStop = false;
            this.GamePanelPlayerSkillsButton.Text = "Stats";
            this.GamePanelPlayerSkillsButton.UseVisualStyleBackColor = true;
            this.GamePanelPlayerSkillsButton.Click += new System.EventHandler(this.GamePanelPlayerSkillsButton_Click);
            // 
            // MainInventoryButton
            // 
            this.MainInventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainInventoryButton.BackgroundImage")));
            this.MainInventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainInventoryButton.CausesValidation = false;
            this.MainInventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.MainInventoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MainInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainInventoryButton.Location = new System.Drawing.Point(1542, 247);
            this.MainInventoryButton.Name = "MainInventoryButton";
            this.MainInventoryButton.Size = new System.Drawing.Size(99, 32);
            this.MainInventoryButton.TabIndex = 0;
            this.MainInventoryButton.TabStop = false;
            this.MainInventoryButton.Text = "Inventory";
            this.MainInventoryButton.UseVisualStyleBackColor = true;
            this.MainInventoryButton.Click += new System.EventHandler(this.MainInventoryButton_Click);
            // 
            // EquipmentButton
            // 
            this.EquipmentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EquipmentButton.BackgroundImage")));
            this.EquipmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EquipmentButton.CausesValidation = false;
            this.EquipmentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.EquipmentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EquipmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipmentButton.Location = new System.Drawing.Point(1647, 247);
            this.EquipmentButton.Name = "EquipmentButton";
            this.EquipmentButton.Size = new System.Drawing.Size(104, 32);
            this.EquipmentButton.TabIndex = 0;
            this.EquipmentButton.TabStop = false;
            this.EquipmentButton.Text = "Equipment";
            this.EquipmentButton.UseVisualStyleBackColor = true;
            this.EquipmentButton.Click += new System.EventHandler(this.EquipmentButton_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.CausesValidation = false;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(1802, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 32);
            this.button5.TabIndex = 0;
            this.button5.TabStop = false;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GameChatBox
            // 
            this.GameChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GameChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameChatBox.FormattingEnabled = true;
            this.GameChatBox.ItemHeight = 24;
            this.GameChatBox.Location = new System.Drawing.Point(0, 843);
            this.GameChatBox.Name = "GameChatBox";
            this.GameChatBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.GameChatBox.Size = new System.Drawing.Size(1440, 124);
            this.GameChatBox.TabIndex = 0;
            this.GameChatBox.TabStop = false;
            this.GameChatBox.UseTabStops = false;
            // 
            // GameChatTextBox
            // 
            this.GameChatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameChatTextBox.Location = new System.Drawing.Point(0, 971);
            this.GameChatTextBox.Name = "GameChatTextBox";
            this.GameChatTextBox.Size = new System.Drawing.Size(1440, 26);
            this.GameChatTextBox.TabIndex = 0;
            this.GameChatTextBox.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Transparent;
            this.GamePanel.Controls.Add(this.pictureBox14);
            this.GamePanel.Controls.Add(this.GameChatTextBox);
            this.GamePanel.Controls.Add(this.GameChatBox);
            this.GamePanel.Controls.Add(this.button5);
            this.GamePanel.Controls.Add(this.EquipmentButton);
            this.GamePanel.Controls.Add(this.MainInventoryButton);
            this.GamePanel.Controls.Add(this.GamePanelPlayerSkillsButton);
            this.GamePanel.Controls.Add(this.GamePanelPlayerExperienceAmountPercentLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerManaAmountLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerHealthAmountLabel);
            this.GamePanel.Controls.Add(this.ExperienceProgressBar);
            this.GamePanel.Controls.Add(this.ManaProgressBar);
            this.GamePanel.Controls.Add(this.HealthProgressBar);
            this.GamePanel.Controls.Add(this.GamePanelPlayerExperienceLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerManaLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerHealthLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerLevelRaceClassLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerNameLabel);
            this.GamePanel.Controls.Add(this.GamePanelPlayerAvatar);
            this.GamePanel.Controls.Add(this.GameRenderer);
            this.GamePanel.Controls.Add(this.SkillsPanel);
            this.GamePanel.Controls.Add(this.InventoryPanel);
            this.GamePanel.Controls.Add(this.EquipmentPanel);
            this.GamePanel.Location = new System.Drawing.Point(9, 12);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1893, 1017);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.Visible = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(785, -467);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(128, 96);
            this.pictureBox14.TabIndex = 56;
            this.pictureBox14.TabStop = false;
            // 
            // ExperienceProgressBar
            // 
            this.ExperienceProgressBar.BackColor = System.Drawing.Color.Black;
            this.ExperienceProgressBar.ForeColor = System.Drawing.Color.Gold;
            this.ExperienceProgressBar.Location = new System.Drawing.Point(1592, 168);
            this.ExperienceProgressBar.Name = "ExperienceProgressBar";
            this.ExperienceProgressBar.Size = new System.Drawing.Size(185, 23);
            this.ExperienceProgressBar.Step = 1;
            this.ExperienceProgressBar.TabIndex = 0;
            // 
            // ManaProgressBar
            // 
            this.ManaProgressBar.BackColor = System.Drawing.Color.Black;
            this.ManaProgressBar.ForeColor = System.Drawing.Color.Cyan;
            this.ManaProgressBar.Location = new System.Drawing.Point(1592, 128);
            this.ManaProgressBar.Name = "ManaProgressBar";
            this.ManaProgressBar.Size = new System.Drawing.Size(185, 23);
            this.ManaProgressBar.Step = 1;
            this.ManaProgressBar.TabIndex = 0;
            this.ManaProgressBar.Value = 50;
            // 
            // HealthProgressBar
            // 
            this.HealthProgressBar.BackColor = System.Drawing.Color.Black;
            this.HealthProgressBar.ForeColor = System.Drawing.Color.Red;
            this.HealthProgressBar.Location = new System.Drawing.Point(1592, 86);
            this.HealthProgressBar.Name = "HealthProgressBar";
            this.HealthProgressBar.Size = new System.Drawing.Size(185, 23);
            this.HealthProgressBar.Step = 1;
            this.HealthProgressBar.TabIndex = 0;
            this.HealthProgressBar.Value = 50;
            // 
            // GameRenderer
            // 
            this.GameRenderer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameRenderer.Location = new System.Drawing.Point(0, 0);
            this.GameRenderer.Margin = new System.Windows.Forms.Padding(0);
            this.GameRenderer.Name = "GameRenderer";
            this.GameRenderer.Size = new System.Drawing.Size(1440, 832);
            this.GameRenderer.TabIndex = 155;
            this.GameRenderer.TabStop = false;
            // 
            // SkillsPanel
            // 
            this.SkillsPanel.BackColor = System.Drawing.Color.Black;
            this.SkillsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkillsPanel.BackgroundImage")));
            this.SkillsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SkillsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SkillsPanel.Controls.Add(this.AddSkillButton6);
            this.SkillsPanel.Controls.Add(this.AddSkillButton5);
            this.SkillsPanel.Controls.Add(this.AddSkillButton4);
            this.SkillsPanel.Controls.Add(this.AddSkillButton3);
            this.SkillsPanel.Controls.Add(this.AddSkillButton2);
            this.SkillsPanel.Controls.Add(this.AddSkillButton1);
            this.SkillsPanel.Controls.Add(this.enterSkillPointsData);
            this.SkillsPanel.Controls.Add(this.enterCharismaData);
            this.SkillsPanel.Controls.Add(this.CharismaLabel);
            this.SkillsPanel.Controls.Add(this.enterWisdomData);
            this.SkillsPanel.Controls.Add(this.WisdomLabel);
            this.SkillsPanel.Controls.Add(this.enterIntellectData);
            this.SkillsPanel.Controls.Add(this.IntellectLabel);
            this.SkillsPanel.Controls.Add(this.enterConstitutionData);
            this.SkillsPanel.Controls.Add(this.ConstitutionLabel);
            this.SkillsPanel.Controls.Add(this.enterDexterityData);
            this.SkillsPanel.Controls.Add(this.DexterityLabel);
            this.SkillsPanel.Controls.Add(this.enterStrengthData);
            this.SkillsPanel.Controls.Add(this.StrengthLabel);
            this.SkillsPanel.Controls.Add(this.EnterCarryingWeightData);
            this.SkillsPanel.Controls.Add(this.CapacityLabel);
            this.SkillsPanel.Controls.Add(this.enterExperienceData);
            this.SkillsPanel.Controls.Add(this.xpToLevelLabel);
            this.SkillsPanel.Location = new System.Drawing.Point(1444, 286);
            this.SkillsPanel.Name = "SkillsPanel";
            this.SkillsPanel.Size = new System.Drawing.Size(449, 313);
            this.SkillsPanel.TabIndex = 156;
            this.SkillsPanel.Visible = false;
            // 
            // AddSkillButton6
            // 
            this.AddSkillButton6.BackColor = System.Drawing.Color.Transparent;
            this.AddSkillButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSkillButton6.BackgroundImage")));
            this.AddSkillButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSkillButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSkillButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton6.Location = new System.Drawing.Point(341, 273);
            this.AddSkillButton6.Name = "AddSkillButton6";
            this.AddSkillButton6.Size = new System.Drawing.Size(75, 23);
            this.AddSkillButton6.TabIndex = 22;
            this.AddSkillButton6.Text = "Add Stat";
            this.AddSkillButton6.UseVisualStyleBackColor = false;
            this.AddSkillButton6.Click += new System.EventHandler(this.AddSkillButton6_Click);
            // 
            // AddSkillButton5
            // 
            this.AddSkillButton5.BackColor = System.Drawing.Color.Transparent;
            this.AddSkillButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSkillButton5.BackgroundImage")));
            this.AddSkillButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSkillButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSkillButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton5.Location = new System.Drawing.Point(341, 243);
            this.AddSkillButton5.Name = "AddSkillButton5";
            this.AddSkillButton5.Size = new System.Drawing.Size(75, 23);
            this.AddSkillButton5.TabIndex = 21;
            this.AddSkillButton5.Text = "Add Stat";
            this.AddSkillButton5.UseVisualStyleBackColor = false;
            this.AddSkillButton5.Click += new System.EventHandler(this.AddSkillButton5_Click);
            // 
            // AddSkillButton4
            // 
            this.AddSkillButton4.BackColor = System.Drawing.Color.Transparent;
            this.AddSkillButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSkillButton4.BackgroundImage")));
            this.AddSkillButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSkillButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSkillButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton4.Location = new System.Drawing.Point(341, 213);
            this.AddSkillButton4.Name = "AddSkillButton4";
            this.AddSkillButton4.Size = new System.Drawing.Size(75, 23);
            this.AddSkillButton4.TabIndex = 20;
            this.AddSkillButton4.Text = "Add Stat";
            this.AddSkillButton4.UseVisualStyleBackColor = false;
            this.AddSkillButton4.Click += new System.EventHandler(this.AddSkillButton4_Click);
            // 
            // AddSkillButton3
            // 
            this.AddSkillButton3.BackColor = System.Drawing.Color.Transparent;
            this.AddSkillButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSkillButton3.BackgroundImage")));
            this.AddSkillButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSkillButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSkillButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton3.Location = new System.Drawing.Point(341, 183);
            this.AddSkillButton3.Name = "AddSkillButton3";
            this.AddSkillButton3.Size = new System.Drawing.Size(75, 23);
            this.AddSkillButton3.TabIndex = 19;
            this.AddSkillButton3.Text = "Add Stat";
            this.AddSkillButton3.UseVisualStyleBackColor = false;
            this.AddSkillButton3.Click += new System.EventHandler(this.AddSkillButton3_Click);
            // 
            // AddSkillButton2
            // 
            this.AddSkillButton2.BackColor = System.Drawing.Color.Transparent;
            this.AddSkillButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSkillButton2.BackgroundImage")));
            this.AddSkillButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSkillButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSkillButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton2.Location = new System.Drawing.Point(341, 153);
            this.AddSkillButton2.Name = "AddSkillButton2";
            this.AddSkillButton2.Size = new System.Drawing.Size(75, 23);
            this.AddSkillButton2.TabIndex = 18;
            this.AddSkillButton2.Text = "Add Stat";
            this.AddSkillButton2.UseVisualStyleBackColor = false;
            this.AddSkillButton2.Click += new System.EventHandler(this.AddSkillButton2_Click);
            // 
            // AddSkillButton1
            // 
            this.AddSkillButton1.BackColor = System.Drawing.Color.Transparent;
            this.AddSkillButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddSkillButton1.BackgroundImage")));
            this.AddSkillButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSkillButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSkillButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSkillButton1.Location = new System.Drawing.Point(341, 123);
            this.AddSkillButton1.Name = "AddSkillButton1";
            this.AddSkillButton1.Size = new System.Drawing.Size(75, 23);
            this.AddSkillButton1.TabIndex = 17;
            this.AddSkillButton1.Text = "Add Stat";
            this.AddSkillButton1.UseVisualStyleBackColor = false;
            this.AddSkillButton1.Click += new System.EventHandler(this.AddSkillButton1_Click);
            // 
            // enterSkillPointsData
            // 
            this.enterSkillPointsData.AutoSize = true;
            this.enterSkillPointsData.BackColor = System.Drawing.Color.Transparent;
            this.enterSkillPointsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterSkillPointsData.Location = new System.Drawing.Point(142, 92);
            this.enterSkillPointsData.Name = "enterSkillPointsData";
            this.enterSkillPointsData.Size = new System.Drawing.Size(153, 20);
            this.enterSkillPointsData.TabIndex = 16;
            this.enterSkillPointsData.Text = "enterSkillPointsData";
            // 
            // enterCharismaData
            // 
            this.enterCharismaData.AutoSize = true;
            this.enterCharismaData.BackColor = System.Drawing.Color.Transparent;
            this.enterCharismaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCharismaData.Location = new System.Drawing.Point(165, 273);
            this.enterCharismaData.Name = "enterCharismaData";
            this.enterCharismaData.Size = new System.Drawing.Size(148, 20);
            this.enterCharismaData.TabIndex = 15;
            this.enterCharismaData.Text = "enterCharismaData";
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.BackColor = System.Drawing.Color.Transparent;
            this.CharismaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaLabel.Location = new System.Drawing.Point(32, 276);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(84, 20);
            this.CharismaLabel.TabIndex = 14;
            this.CharismaLabel.Text = "Charisma :";
            // 
            // enterWisdomData
            // 
            this.enterWisdomData.AutoSize = true;
            this.enterWisdomData.BackColor = System.Drawing.Color.Transparent;
            this.enterWisdomData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterWisdomData.Location = new System.Drawing.Point(165, 243);
            this.enterWisdomData.Name = "enterWisdomData";
            this.enterWisdomData.Size = new System.Drawing.Size(138, 20);
            this.enterWisdomData.TabIndex = 13;
            this.enterWisdomData.Text = "enterWisdomData";
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.BackColor = System.Drawing.Color.Transparent;
            this.WisdomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomLabel.Location = new System.Drawing.Point(32, 246);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(74, 20);
            this.WisdomLabel.TabIndex = 12;
            this.WisdomLabel.Text = "Wisdom :";
            // 
            // enterIntellectData
            // 
            this.enterIntellectData.AutoSize = true;
            this.enterIntellectData.BackColor = System.Drawing.Color.Transparent;
            this.enterIntellectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIntellectData.Location = new System.Drawing.Point(165, 213);
            this.enterIntellectData.Name = "enterIntellectData";
            this.enterIntellectData.Size = new System.Drawing.Size(137, 20);
            this.enterIntellectData.TabIndex = 11;
            this.enterIntellectData.Text = "enterIntellectData";
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.AutoSize = true;
            this.IntellectLabel.BackColor = System.Drawing.Color.Transparent;
            this.IntellectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntellectLabel.Location = new System.Drawing.Point(32, 216);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(73, 20);
            this.IntellectLabel.TabIndex = 10;
            this.IntellectLabel.Text = "Intellect :";
            // 
            // enterConstitutionData
            // 
            this.enterConstitutionData.AutoSize = true;
            this.enterConstitutionData.BackColor = System.Drawing.Color.Transparent;
            this.enterConstitutionData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterConstitutionData.Location = new System.Drawing.Point(165, 183);
            this.enterConstitutionData.Name = "enterConstitutionData";
            this.enterConstitutionData.Size = new System.Drawing.Size(166, 20);
            this.enterConstitutionData.TabIndex = 9;
            this.enterConstitutionData.Text = "enterConstitutionData";
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConstitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionLabel.Location = new System.Drawing.Point(32, 186);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(102, 20);
            this.ConstitutionLabel.TabIndex = 8;
            this.ConstitutionLabel.Text = "Constitution :";
            // 
            // enterDexterityData
            // 
            this.enterDexterityData.AutoSize = true;
            this.enterDexterityData.BackColor = System.Drawing.Color.Transparent;
            this.enterDexterityData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDexterityData.Location = new System.Drawing.Point(165, 153);
            this.enterDexterityData.Name = "enterDexterityData";
            this.enterDexterityData.Size = new System.Drawing.Size(143, 20);
            this.enterDexterityData.TabIndex = 7;
            this.enterDexterityData.Text = "enterDexterityData";
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.BackColor = System.Drawing.Color.Transparent;
            this.DexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityLabel.Location = new System.Drawing.Point(32, 156);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(79, 20);
            this.DexterityLabel.TabIndex = 6;
            this.DexterityLabel.Text = "Dexterity :";
            // 
            // enterStrengthData
            // 
            this.enterStrengthData.AutoSize = true;
            this.enterStrengthData.BackColor = System.Drawing.Color.Transparent;
            this.enterStrengthData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterStrengthData.Location = new System.Drawing.Point(165, 123);
            this.enterStrengthData.Name = "enterStrengthData";
            this.enterStrengthData.Size = new System.Drawing.Size(143, 20);
            this.enterStrengthData.TabIndex = 5;
            this.enterStrengthData.Text = "enterStrengthData";
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.StrengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabel.Location = new System.Drawing.Point(32, 126);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(79, 20);
            this.StrengthLabel.TabIndex = 4;
            this.StrengthLabel.Text = "Strength :";
            // 
            // EnterCarryingWeightData
            // 
            this.EnterCarryingWeightData.AutoSize = true;
            this.EnterCarryingWeightData.BackColor = System.Drawing.Color.Transparent;
            this.EnterCarryingWeightData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCarryingWeightData.Location = new System.Drawing.Point(227, 56);
            this.EnterCarryingWeightData.Name = "EnterCarryingWeightData";
            this.EnterCarryingWeightData.Size = new System.Drawing.Size(189, 20);
            this.EnterCarryingWeightData.TabIndex = 3;
            this.EnterCarryingWeightData.Text = "enterCarryingWeightData";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityLabel.Location = new System.Drawing.Point(38, 56);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(129, 20);
            this.CapacityLabel.TabIndex = 2;
            this.CapacityLabel.Text = "Carrying Weight :";
            // 
            // enterExperienceData
            // 
            this.enterExperienceData.AutoSize = true;
            this.enterExperienceData.BackColor = System.Drawing.Color.Transparent;
            this.enterExperienceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterExperienceData.Location = new System.Drawing.Point(227, 26);
            this.enterExperienceData.Name = "enterExperienceData";
            this.enterExperienceData.Size = new System.Drawing.Size(160, 20);
            this.enterExperienceData.TabIndex = 1;
            this.enterExperienceData.Text = "enterExperienceData";
            // 
            // xpToLevelLabel
            // 
            this.xpToLevelLabel.AutoSize = true;
            this.xpToLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.xpToLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpToLevelLabel.Location = new System.Drawing.Point(38, 26);
            this.xpToLevelLabel.Name = "xpToLevelLabel";
            this.xpToLevelLabel.Size = new System.Drawing.Size(183, 20);
            this.xpToLevelLabel.TabIndex = 0;
            this.xpToLevelLabel.Text = "Experience to next level :";
            // 
            // InventoryPanel
            // 
            this.InventoryPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InventoryPanel.BackColor = System.Drawing.Color.DarkGray;
            this.InventoryPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPanel.BackgroundImage")));
            this.InventoryPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox20);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox19);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox18);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox17);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox16);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox15);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox14);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox13);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox12);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox11);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox10);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox5);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox9);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox8);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox4);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox7);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox3);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox6);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox2);
            this.InventoryPanel.Controls.Add(this.InventoryPictureBox1);
            this.InventoryPanel.Location = new System.Drawing.Point(1444, 286);
            this.InventoryPanel.MaximumSize = new System.Drawing.Size(449, 313);
            this.InventoryPanel.MinimumSize = new System.Drawing.Size(449, 313);
            this.InventoryPanel.Name = "InventoryPanel";
            this.InventoryPanel.Size = new System.Drawing.Size(449, 313);
            this.InventoryPanel.TabIndex = 158;
            this.InventoryPanel.Visible = false;
            this.InventoryPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InventoryPanel_MouseDown);
            this.InventoryPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InventoryPanel_MouseMove);
            this.InventoryPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InventoryPanel_MouseUp);
            // 
            // InventoryPictureBox20
            // 
            this.InventoryPictureBox20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox20.BackgroundImage")));
            this.InventoryPictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox20.Location = new System.Drawing.Point(345, 233);
            this.InventoryPictureBox20.Margin = new System.Windows.Forms.Padding(16);
            this.InventoryPictureBox20.Name = "InventoryPictureBox20";
            this.InventoryPictureBox20.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox20.TabIndex = 19;
            this.InventoryPictureBox20.TabStop = false;
            // 
            // InventoryPictureBox19
            // 
            this.InventoryPictureBox19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox19.BackgroundImage")));
            this.InventoryPictureBox19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox19.Location = new System.Drawing.Point(266, 233);
            this.InventoryPictureBox19.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox19.Name = "InventoryPictureBox19";
            this.InventoryPictureBox19.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox19.TabIndex = 18;
            this.InventoryPictureBox19.TabStop = false;
            // 
            // InventoryPictureBox18
            // 
            this.InventoryPictureBox18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox18.BackgroundImage")));
            this.InventoryPictureBox18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox18.Location = new System.Drawing.Point(189, 233);
            this.InventoryPictureBox18.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox18.Name = "InventoryPictureBox18";
            this.InventoryPictureBox18.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox18.TabIndex = 17;
            this.InventoryPictureBox18.TabStop = false;
            // 
            // InventoryPictureBox17
            // 
            this.InventoryPictureBox17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox17.BackgroundImage")));
            this.InventoryPictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox17.Location = new System.Drawing.Point(112, 233);
            this.InventoryPictureBox17.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox17.Name = "InventoryPictureBox17";
            this.InventoryPictureBox17.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox17.TabIndex = 16;
            this.InventoryPictureBox17.TabStop = false;
            // 
            // InventoryPictureBox16
            // 
            this.InventoryPictureBox16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox16.BackgroundImage")));
            this.InventoryPictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox16.Location = new System.Drawing.Point(36, 233);
            this.InventoryPictureBox16.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox16.Name = "InventoryPictureBox16";
            this.InventoryPictureBox16.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox16.TabIndex = 15;
            this.InventoryPictureBox16.TabStop = false;
            // 
            // InventoryPictureBox15
            // 
            this.InventoryPictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox15.BackgroundImage")));
            this.InventoryPictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox15.Location = new System.Drawing.Point(345, 161);
            this.InventoryPictureBox15.Margin = new System.Windows.Forms.Padding(16);
            this.InventoryPictureBox15.Name = "InventoryPictureBox15";
            this.InventoryPictureBox15.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox15.TabIndex = 14;
            this.InventoryPictureBox15.TabStop = false;
            // 
            // InventoryPictureBox14
            // 
            this.InventoryPictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox14.BackgroundImage")));
            this.InventoryPictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox14.Location = new System.Drawing.Point(266, 161);
            this.InventoryPictureBox14.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox14.Name = "InventoryPictureBox14";
            this.InventoryPictureBox14.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox14.TabIndex = 13;
            this.InventoryPictureBox14.TabStop = false;
            // 
            // InventoryPictureBox13
            // 
            this.InventoryPictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox13.BackgroundImage")));
            this.InventoryPictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox13.Location = new System.Drawing.Point(189, 161);
            this.InventoryPictureBox13.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox13.Name = "InventoryPictureBox13";
            this.InventoryPictureBox13.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox13.TabIndex = 12;
            this.InventoryPictureBox13.TabStop = false;
            // 
            // InventoryPictureBox12
            // 
            this.InventoryPictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox12.BackgroundImage")));
            this.InventoryPictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox12.Location = new System.Drawing.Point(112, 161);
            this.InventoryPictureBox12.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox12.Name = "InventoryPictureBox12";
            this.InventoryPictureBox12.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox12.TabIndex = 11;
            this.InventoryPictureBox12.TabStop = false;
            // 
            // InventoryPictureBox11
            // 
            this.InventoryPictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox11.BackgroundImage")));
            this.InventoryPictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox11.Location = new System.Drawing.Point(36, 161);
            this.InventoryPictureBox11.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox11.Name = "InventoryPictureBox11";
            this.InventoryPictureBox11.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox11.TabIndex = 10;
            this.InventoryPictureBox11.TabStop = false;
            // 
            // InventoryPictureBox10
            // 
            this.InventoryPictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox10.BackgroundImage")));
            this.InventoryPictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox10.Location = new System.Drawing.Point(345, 89);
            this.InventoryPictureBox10.Margin = new System.Windows.Forms.Padding(16);
            this.InventoryPictureBox10.Name = "InventoryPictureBox10";
            this.InventoryPictureBox10.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox10.TabIndex = 9;
            this.InventoryPictureBox10.TabStop = false;
            // 
            // InventoryPictureBox5
            // 
            this.InventoryPictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox5.BackgroundImage")));
            this.InventoryPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox5.Location = new System.Drawing.Point(345, 16);
            this.InventoryPictureBox5.Margin = new System.Windows.Forms.Padding(16);
            this.InventoryPictureBox5.Name = "InventoryPictureBox5";
            this.InventoryPictureBox5.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox5.TabIndex = 4;
            this.InventoryPictureBox5.TabStop = false;
            // 
            // InventoryPictureBox9
            // 
            this.InventoryPictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox9.BackgroundImage")));
            this.InventoryPictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox9.Location = new System.Drawing.Point(266, 89);
            this.InventoryPictureBox9.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox9.Name = "InventoryPictureBox9";
            this.InventoryPictureBox9.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox9.TabIndex = 8;
            this.InventoryPictureBox9.TabStop = false;
            // 
            // InventoryPictureBox8
            // 
            this.InventoryPictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox8.BackgroundImage")));
            this.InventoryPictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox8.Location = new System.Drawing.Point(189, 89);
            this.InventoryPictureBox8.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox8.Name = "InventoryPictureBox8";
            this.InventoryPictureBox8.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox8.TabIndex = 7;
            this.InventoryPictureBox8.TabStop = false;
            // 
            // InventoryPictureBox4
            // 
            this.InventoryPictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox4.BackgroundImage")));
            this.InventoryPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox4.Location = new System.Drawing.Point(266, 16);
            this.InventoryPictureBox4.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox4.Name = "InventoryPictureBox4";
            this.InventoryPictureBox4.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox4.TabIndex = 3;
            this.InventoryPictureBox4.TabStop = false;
            // 
            // InventoryPictureBox7
            // 
            this.InventoryPictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox7.BackgroundImage")));
            this.InventoryPictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox7.Location = new System.Drawing.Point(112, 89);
            this.InventoryPictureBox7.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox7.Name = "InventoryPictureBox7";
            this.InventoryPictureBox7.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox7.TabIndex = 6;
            this.InventoryPictureBox7.TabStop = false;
            // 
            // InventoryPictureBox3
            // 
            this.InventoryPictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox3.BackgroundImage")));
            this.InventoryPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox3.Location = new System.Drawing.Point(189, 16);
            this.InventoryPictureBox3.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox3.Name = "InventoryPictureBox3";
            this.InventoryPictureBox3.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox3.TabIndex = 2;
            this.InventoryPictureBox3.TabStop = false;
            // 
            // InventoryPictureBox6
            // 
            this.InventoryPictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox6.BackgroundImage")));
            this.InventoryPictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox6.Location = new System.Drawing.Point(36, 89);
            this.InventoryPictureBox6.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox6.Name = "InventoryPictureBox6";
            this.InventoryPictureBox6.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox6.TabIndex = 5;
            this.InventoryPictureBox6.TabStop = false;
            // 
            // InventoryPictureBox2
            // 
            this.InventoryPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox2.BackgroundImage")));
            this.InventoryPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox2.Location = new System.Drawing.Point(112, 16);
            this.InventoryPictureBox2.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox2.Name = "InventoryPictureBox2";
            this.InventoryPictureBox2.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox2.TabIndex = 1;
            this.InventoryPictureBox2.TabStop = false;
            // 
            // InventoryPictureBox1
            // 
            this.InventoryPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryPictureBox1.BackgroundImage")));
            this.InventoryPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryPictureBox1.Location = new System.Drawing.Point(36, 16);
            this.InventoryPictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.InventoryPictureBox1.Name = "InventoryPictureBox1";
            this.InventoryPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.InventoryPictureBox1.TabIndex = 0;
            this.InventoryPictureBox1.TabStop = false;
            // 
            // EquipmentPanel
            // 
            this.EquipmentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EquipmentPanel.BackColor = System.Drawing.Color.DarkGray;
            this.EquipmentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EquipmentPanel.BackgroundImage")));
            this.EquipmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EquipmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EquipmentPanel.Controls.Add(this.FeetSlot);
            this.EquipmentPanel.Controls.Add(this.AmmoSlot);
            this.EquipmentPanel.Controls.Add(this.LegsSlot);
            this.EquipmentPanel.Controls.Add(this.RingSlot);
            this.EquipmentPanel.Controls.Add(this.OffHandSlot);
            this.EquipmentPanel.Controls.Add(this.ChestSlot);
            this.EquipmentPanel.Controls.Add(this.BackpackSlot);
            this.EquipmentPanel.Controls.Add(this.MainWeaponSlot);
            this.EquipmentPanel.Controls.Add(this.HeadSlot);
            this.EquipmentPanel.Controls.Add(this.AmuletSlot);
            this.EquipmentPanel.Location = new System.Drawing.Point(1444, 286);
            this.EquipmentPanel.MaximumSize = new System.Drawing.Size(449, 313);
            this.EquipmentPanel.MinimumSize = new System.Drawing.Size(449, 313);
            this.EquipmentPanel.Name = "EquipmentPanel";
            this.EquipmentPanel.Size = new System.Drawing.Size(449, 313);
            this.EquipmentPanel.TabIndex = 157;
            this.EquipmentPanel.Visible = false;
            // 
            // FeetSlot
            // 
            this.FeetSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FeetSlot.BackgroundImage")));
            this.FeetSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FeetSlot.Image = ((System.Drawing.Image)(resources.GetObject("FeetSlot.Image")));
            this.FeetSlot.Location = new System.Drawing.Point(189, 230);
            this.FeetSlot.Margin = new System.Windows.Forms.Padding(20);
            this.FeetSlot.Name = "FeetSlot";
            this.FeetSlot.Size = new System.Drawing.Size(64, 64);
            this.FeetSlot.TabIndex = 17;
            this.FeetSlot.TabStop = false;
            // 
            // AmmoSlot
            // 
            this.AmmoSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AmmoSlot.BackgroundImage")));
            this.AmmoSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AmmoSlot.Image = ((System.Drawing.Image)(resources.GetObject("AmmoSlot.Image")));
            this.AmmoSlot.Location = new System.Drawing.Point(262, 194);
            this.AmmoSlot.Margin = new System.Windows.Forms.Padding(20);
            this.AmmoSlot.Name = "AmmoSlot";
            this.AmmoSlot.Size = new System.Drawing.Size(64, 64);
            this.AmmoSlot.TabIndex = 13;
            this.AmmoSlot.TabStop = false;
            // 
            // LegsSlot
            // 
            this.LegsSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LegsSlot.BackgroundImage")));
            this.LegsSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LegsSlot.Image = ((System.Drawing.Image)(resources.GetObject("LegsSlot.Image")));
            this.LegsSlot.Location = new System.Drawing.Point(189, 158);
            this.LegsSlot.Margin = new System.Windows.Forms.Padding(20);
            this.LegsSlot.Name = "LegsSlot";
            this.LegsSlot.Size = new System.Drawing.Size(64, 64);
            this.LegsSlot.TabIndex = 12;
            this.LegsSlot.TabStop = false;
            // 
            // RingSlot
            // 
            this.RingSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RingSlot.BackgroundImage")));
            this.RingSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RingSlot.Image = ((System.Drawing.Image)(resources.GetObject("RingSlot.Image")));
            this.RingSlot.Location = new System.Drawing.Point(115, 194);
            this.RingSlot.Margin = new System.Windows.Forms.Padding(20);
            this.RingSlot.Name = "RingSlot";
            this.RingSlot.Size = new System.Drawing.Size(64, 64);
            this.RingSlot.TabIndex = 11;
            this.RingSlot.TabStop = false;
            // 
            // OffHandSlot
            // 
            this.OffHandSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OffHandSlot.BackgroundImage")));
            this.OffHandSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OffHandSlot.Image = ((System.Drawing.Image)(resources.GetObject("OffHandSlot.Image")));
            this.OffHandSlot.Location = new System.Drawing.Point(262, 122);
            this.OffHandSlot.Margin = new System.Windows.Forms.Padding(20);
            this.OffHandSlot.Name = "OffHandSlot";
            this.OffHandSlot.Size = new System.Drawing.Size(64, 64);
            this.OffHandSlot.TabIndex = 8;
            this.OffHandSlot.TabStop = false;
            // 
            // ChestSlot
            // 
            this.ChestSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChestSlot.BackgroundImage")));
            this.ChestSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChestSlot.Image = ((System.Drawing.Image)(resources.GetObject("ChestSlot.Image")));
            this.ChestSlot.Location = new System.Drawing.Point(189, 86);
            this.ChestSlot.Margin = new System.Windows.Forms.Padding(20);
            this.ChestSlot.Name = "ChestSlot";
            this.ChestSlot.Size = new System.Drawing.Size(64, 64);
            this.ChestSlot.TabIndex = 7;
            this.ChestSlot.TabStop = false;
            // 
            // BackpackSlot
            // 
            this.BackpackSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackpackSlot.BackgroundImage")));
            this.BackpackSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackpackSlot.Image = ((System.Drawing.Image)(resources.GetObject("BackpackSlot.Image")));
            this.BackpackSlot.Location = new System.Drawing.Point(262, 49);
            this.BackpackSlot.Margin = new System.Windows.Forms.Padding(20);
            this.BackpackSlot.Name = "BackpackSlot";
            this.BackpackSlot.Size = new System.Drawing.Size(64, 64);
            this.BackpackSlot.TabIndex = 3;
            this.BackpackSlot.TabStop = false;
            // 
            // MainWeaponSlot
            // 
            this.MainWeaponSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainWeaponSlot.BackgroundImage")));
            this.MainWeaponSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainWeaponSlot.Image = ((System.Drawing.Image)(resources.GetObject("MainWeaponSlot.Image")));
            this.MainWeaponSlot.InitialImage = ((System.Drawing.Image)(resources.GetObject("MainWeaponSlot.InitialImage")));
            this.MainWeaponSlot.Location = new System.Drawing.Point(115, 122);
            this.MainWeaponSlot.Margin = new System.Windows.Forms.Padding(20);
            this.MainWeaponSlot.Name = "MainWeaponSlot";
            this.MainWeaponSlot.Size = new System.Drawing.Size(64, 64);
            this.MainWeaponSlot.TabIndex = 6;
            this.MainWeaponSlot.TabStop = false;
            // 
            // HeadSlot
            // 
            this.HeadSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeadSlot.BackgroundImage")));
            this.HeadSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeadSlot.Image = ((System.Drawing.Image)(resources.GetObject("HeadSlot.Image")));
            this.HeadSlot.Location = new System.Drawing.Point(189, 13);
            this.HeadSlot.Margin = new System.Windows.Forms.Padding(20);
            this.HeadSlot.Name = "HeadSlot";
            this.HeadSlot.Size = new System.Drawing.Size(64, 64);
            this.HeadSlot.TabIndex = 2;
            this.HeadSlot.TabStop = false;
            // 
            // AmuletSlot
            // 
            this.AmuletSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AmuletSlot.BackgroundImage")));
            this.AmuletSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AmuletSlot.Image = ((System.Drawing.Image)(resources.GetObject("AmuletSlot.Image")));
            this.AmuletSlot.Location = new System.Drawing.Point(115, 49);
            this.AmuletSlot.Margin = new System.Windows.Forms.Padding(20);
            this.AmuletSlot.Name = "AmuletSlot";
            this.AmuletSlot.Size = new System.Drawing.Size(64, 64);
            this.AmuletSlot.TabIndex = 1;
            this.AmuletSlot.TabStop = false;
            // 
            // MainMapImageList
            // 
            this.MainMapImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainMapImageList.ImageStream")));
            this.MainMapImageList.Tag = "MainMap";
            this.MainMapImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainMapImageList.Images.SetKeyName(0, "AutumnTree.png");
            this.MainMapImageList.Images.SetKeyName(1, "CobblestoneCrossRoad.png");
            this.MainMapImageList.Images.SetKeyName(2, "CobblestoneRoadHorizontal.png");
            this.MainMapImageList.Images.SetKeyName(3, "CobblestoneRoadHorizontalWithNorth.png");
            this.MainMapImageList.Images.SetKeyName(4, "CobblestoneRoadHorizontalWithSouth.png");
            this.MainMapImageList.Images.SetKeyName(5, "CobblestoneRoadNorthAndEast.png");
            this.MainMapImageList.Images.SetKeyName(6, "CobblestoneRoadNorthAndWest.png");
            this.MainMapImageList.Images.SetKeyName(7, "CobblestoneRoadSouthAndEast.png");
            this.MainMapImageList.Images.SetKeyName(8, "CobblestoneRoadSouthAndWest.png");
            this.MainMapImageList.Images.SetKeyName(9, "CobblestoneRoadVertical.png");
            this.MainMapImageList.Images.SetKeyName(10, "CobblestoneRoadVerticalWithEast.png");
            this.MainMapImageList.Images.SetKeyName(11, "CobblestoneRoadVerticalWithWest.png");
            this.MainMapImageList.Images.SetKeyName(12, "DeadTree.png");
            this.MainMapImageList.Images.SetKeyName(13, "DirtCrossRoad.png");
            this.MainMapImageList.Images.SetKeyName(14, "DirtRoadHorizontal.png");
            this.MainMapImageList.Images.SetKeyName(15, "DirtRoadHorizontalWithNorth.png");
            this.MainMapImageList.Images.SetKeyName(16, "DirtRoadHorizontalWithSouth.png");
            this.MainMapImageList.Images.SetKeyName(17, "DirtRoadNorthAndEast.png");
            this.MainMapImageList.Images.SetKeyName(18, "DirtRoadNorthAndWest.png");
            this.MainMapImageList.Images.SetKeyName(19, "DirtRoadSouthAndEast.png");
            this.MainMapImageList.Images.SetKeyName(20, "DirtRoadSouthAndWest.png");
            this.MainMapImageList.Images.SetKeyName(21, "DirtRoadVertical.png");
            this.MainMapImageList.Images.SetKeyName(22, "DirtRoadVerticalWithEast.png");
            this.MainMapImageList.Images.SetKeyName(23, "DirtRoadVerticalWithWest.png");
            this.MainMapImageList.Images.SetKeyName(24, "DoubleCabin.png");
            this.MainMapImageList.Images.SetKeyName(25, "DungeonFortress.png");
            this.MainMapImageList.Images.SetKeyName(26, "DungeonTower.png");
            this.MainMapImageList.Images.SetKeyName(27, "Grass.png");
            this.MainMapImageList.Images.SetKeyName(28, "GreenTree.png");
            this.MainMapImageList.Images.SetKeyName(29, "RedGoldTree.png");
            this.MainMapImageList.Images.SetKeyName(30, "RedTree.png");
            this.MainMapImageList.Images.SetKeyName(31, "SingleCabin.png");
            this.MainMapImageList.Images.SetKeyName(32, "TealTree.png");
            this.MainMapImageList.Images.SetKeyName(33, "Town.png");
            this.MainMapImageList.Images.SetKeyName(34, "TrimmedGrass.png");
            this.MainMapImageList.Images.SetKeyName(35, "TripleCabin.png");
            // 
            // monsterImageList
            // 
            this.monsterImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("monsterImageList.ImageStream")));
            this.monsterImageList.Tag = "Monsters";
            this.monsterImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.monsterImageList.Images.SetKeyName(0, "0.png");
            this.monsterImageList.Images.SetKeyName(1, "1.png");
            this.monsterImageList.Images.SetKeyName(2, "2.png");
            // 
            // AdventuresOnlineWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.CreateAccountPanel);
            this.Controls.Add(this.CharacterSelectPanel);
            this.Controls.Add(this.CreateCharacterPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.KeyPreview = true;
            this.Name = "AdventuresOnlineWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginWindow_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginWindow_KeyUp);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CreateCharacterPanel.ResumeLayout(false);
            this.CreateCharacterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateCharacterAvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.CharacterSelectPanel.ResumeLayout(false);
            this.CharacterSelectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterSelectAvatarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.CreateAccountPanel.ResumeLayout(false);
            this.CreateAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanelPlayerAvatar)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameRenderer)).EndInit();
            this.SkillsPanel.ResumeLayout(false);
            this.SkillsPanel.PerformLayout();
            this.InventoryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryPictureBox1)).EndInit();
            this.EquipmentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeetSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmmoSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegsSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RingSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffHandSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpackSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainWeaponSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadSlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmuletSlot)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private Panel LoginPanel;
        private Button CreateAccountButton;
        private Button ConnectButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private PictureBox pictureBox2;
        private TextBox Password;
        private TextBox Username;
        private Panel CreateCharacterPanel;
        private Button CreateCharacterCancelButton;
        private Button CreateCharacterButton;
        private Label CreateCharacterPlayerNameLabel;
        private Label CreateCharacterRaceLabel;
        private PictureBox pictureBox3;
        private TextBox CreateCharacterName;
        private Label CreateCharacterClassLabel;
        private TextBox CreateCharacterClass;
        private TextBox CreateCharacterRace;
        private Label CreateCharacterAvatarLabel;
        private Button CreateCharacterAvatarRightButton;
        private Button CreateCharacterAvatarLeftButton;
        private PictureBox CreateCharacterAvatarPictureBox;
        private Panel CharacterSelectPanel;
        private Button button1;
        private Button button2;
        private PictureBox CharacterSelectAvatarImage;
        private Button CharacterSelectCreateCharacterButton;
        private Button CharacterSelectConnectButton;
        private PictureBox pictureBox5;
        private ComboBox CharacterSelectDropdownBox;
        private Label CharacterSelectCharacterInfo;
        private Panel CreateAccountPanel;
        private Label CreateAccountLabel;
        private Button CreateAccountCancelButton;
        private Button CreateAccountButtonSendtoServer;
        private Label CreateAccountUsernameLabel;
        private Label CreateAccountPasswordLabel;
        private PictureBox pictureBox1;
        private TextBox CreateAccountPassword;
        private TextBox CreateAccountUsername;
        public Label CreateAccountRejectionLabel;
        public Label LoginLabelAccountInfoBoolean;
        private Button CreateCharacterRaceRightButton;
        private Button CreateCharacterClassRightButton;
        private Button CreateCharacterClassLeftButton;
        private Button CreateCharacterRaceLeftButton;
        private ImageList HumanImageList;
        private ImageList HalflingImageList;
        private ImageList GnomeImageList;
        private ImageList ElfImageList;
        private ImageList DwarfImageList;
        private ImageList DragonbornImageList;
        private ImageList GoblinImageList;
        private ImageList HalfElfImageList;
        public Label CreateCharacterRejectionLabel;
        private Button CharacterSelectLogOffButton;
        private PictureBox GamePanelPlayerAvatar;
        private Label GamePanelPlayerNameLabel;
        public Label GamePanelPlayerLevelRaceClassLabel;
        private Label GamePanelPlayerHealthLabel;
        private Label GamePanelPlayerManaLabel;
        private Label GamePanelPlayerExperienceLabel;
        private Label GamePanelPlayerHealthAmountLabel;
        private Label GamePanelPlayerManaAmountLabel;
        private Label GamePanelPlayerExperienceAmountPercentLabel;
        private Button GamePanelPlayerSkillsButton;
        private Button MainInventoryButton;
        private Button EquipmentButton;
        private Button button5;
        private ListBox GameChatBox;
        private TextBox GameChatTextBox;
        public Panel GamePanel;
        private PictureBox pictureBox14;
        private PictureBox GameRenderer;
        private ImageList MainMapImageList;
        private ProgressBar ExperienceProgressBar;
        private ProgressBar ManaProgressBar;
        private ProgressBar HealthProgressBar;
        private ImageList monsterImageList;
        private Label DexterityLabel;
        private Label enterStrengthData;
        private Label StrengthLabel;
        private Label EnterCarryingWeightData;
        private Label CapacityLabel;
        private Label enterExperienceData;
        private Label xpToLevelLabel;
        private Label ConstitutionLabel;
        private Label enterDexterityData;
        private Label IntellectLabel;
        private Label enterConstitutionData;
        private Label enterIntellectData;
        private Label WisdomLabel;
        private Label CharismaLabel;
        private Label enterWisdomData;
        private Button AddSkillButton1;
        private Label enterSkillPointsData;
        private Label enterCharismaData;
        private Button AddSkillButton6;
        private Button AddSkillButton5;
        private Button AddSkillButton4;
        private Button AddSkillButton3;
        private Button AddSkillButton2;
        public Panel SkillsPanel;
        private Button DeleteCharacterButton;
        private Button DeleteAccountButton;
        private Label LoadingBarLabel;
        private ProgressBar LoadingStartBar;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel EquipmentPanel;
        private PictureBox FeetSlot;
        private PictureBox AmmoSlot;
        private PictureBox LegsSlot;
        private PictureBox RingSlot;
        private PictureBox OffHandSlot;
        private PictureBox ChestSlot;
        private PictureBox BackpackSlot;
        private PictureBox MainWeaponSlot;
        private PictureBox HeadSlot;
        private PictureBox AmuletSlot;
        private Panel InventoryPanel;
        private PictureBox InventoryPictureBox20;
        private PictureBox InventoryPictureBox19;
        private PictureBox InventoryPictureBox18;
        private PictureBox InventoryPictureBox17;
        private PictureBox InventoryPictureBox16;
        private PictureBox InventoryPictureBox15;
        private PictureBox InventoryPictureBox14;
        private PictureBox InventoryPictureBox13;
        private PictureBox InventoryPictureBox12;
        private PictureBox InventoryPictureBox11;
        private PictureBox InventoryPictureBox10;
        private PictureBox InventoryPictureBox5;
        private PictureBox InventoryPictureBox9;
        private PictureBox InventoryPictureBox8;
        private PictureBox InventoryPictureBox4;
        private PictureBox InventoryPictureBox7;
        private PictureBox InventoryPictureBox3;
        private PictureBox InventoryPictureBox6;
        private PictureBox InventoryPictureBox2;
        private PictureBox InventoryPictureBox1;
    }
}