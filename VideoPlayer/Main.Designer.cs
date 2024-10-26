namespace VideoPlayer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCreateRoom = new MaterialSkin.Controls.MaterialButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelCinemaRooms = new MaterialSkin.Controls.MaterialLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelChoose = new System.Windows.Forms.Panel();
            this.panelRoom = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.tBoxChat = new System.Windows.Forms.RichTextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnSend = new MaterialSkin.Controls.MaterialButton();
            this.tBoxInput = new MaterialSkin.Controls.MaterialTextBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.splitter8 = new System.Windows.Forms.Splitter();
            this.cbControlState = new MaterialSkin.Controls.MaterialCheckbox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnChangePassword = new MaterialSkin.Controls.MaterialButton();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.btnChooseFilm = new MaterialSkin.Controls.MaterialButton();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.btnKick = new MaterialSkin.Controls.MaterialButton();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.btnSettings = new MaterialSkin.Controls.MaterialButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnOut = new MaterialSkin.Controls.MaterialButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.panelEmoji = new System.Windows.Forms.Panel();
            this.emojiSurprise = new MaterialSkin.Controls.MaterialLabel();
            this.emojiCry = new MaterialSkin.Controls.MaterialLabel();
            this.emojiLaugh = new MaterialSkin.Controls.MaterialLabel();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelChoose.SuspendLayout();
            this.panelRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelEmoji.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCreateRoom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 853);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1592, 49);
            this.panelBottom.TabIndex = 1;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreateRoom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateRoom.Depth = 0;
            this.btnCreateRoom.HighEmphasis = true;
            this.btnCreateRoom.Icon = null;
            this.btnCreateRoom.Location = new System.Drawing.Point(713, 13);
            this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnCreateRoom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateRoom.Size = new System.Drawing.Size(164, 36);
            this.btnCreateRoom.TabIndex = 0;
            this.btnCreateRoom.Text = "Создать комнату";
            this.btnCreateRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateRoom.UseAccentColor = false;
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 49);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1592, 804);
            this.panelMain.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(1592, 804);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelCinemaRooms
            // 
            this.labelCinemaRooms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCinemaRooms.AutoSize = true;
            this.labelCinemaRooms.Depth = 0;
            this.labelCinemaRooms.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCinemaRooms.Location = new System.Drawing.Point(743, 17);
            this.labelCinemaRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCinemaRooms.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCinemaRooms.Name = "labelCinemaRooms";
            this.labelCinemaRooms.Size = new System.Drawing.Size(106, 19);
            this.labelCinemaRooms.TabIndex = 0;
            this.labelCinemaRooms.Text = "Кинокомнаты";
            this.labelCinemaRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.labelCinemaRooms);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1592, 49);
            this.panelTop.TabIndex = 0;
            // 
            // panelChoose
            // 
            this.panelChoose.Controls.Add(this.panelMain);
            this.panelChoose.Controls.Add(this.panelTop);
            this.panelChoose.Controls.Add(this.panelBottom);
            this.panelChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChoose.Location = new System.Drawing.Point(4, 79);
            this.panelChoose.Margin = new System.Windows.Forms.Padding(4);
            this.panelChoose.Name = "panelChoose";
            this.panelChoose.Size = new System.Drawing.Size(1592, 902);
            this.panelChoose.TabIndex = 3;
            // 
            // panelRoom
            // 
            this.panelRoom.Controls.Add(this.splitContainer);
            this.panelRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRoom.Location = new System.Drawing.Point(4, 79);
            this.panelRoom.Margin = new System.Windows.Forms.Padding(4);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(1592, 902);
            this.panelRoom.TabIndex = 4;
            this.panelRoom.Visible = false;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.WMP);
            this.splitContainer.Panel1MinSize = 400;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer.Panel2.Controls.Add(this.tBoxChat);
            this.splitContainer.Panel2.Controls.Add(this.panelInput);
            this.splitContainer.Panel2.Controls.Add(this.panelSettings);
            this.splitContainer.Panel2.Controls.Add(this.splitter6);
            this.splitContainer.Panel2.Controls.Add(this.btnSettings);
            this.splitContainer.Panel2.Controls.Add(this.splitter2);
            this.splitContainer.Panel2.Controls.Add(this.btnOut);
            this.splitContainer.Panel2.Controls.Add(this.splitter1);
            this.splitContainer.Panel2.Controls.Add(this.splitter7);
            this.splitContainer.Panel2.Controls.Add(this.panelEmoji);
            this.splitContainer.Panel2MinSize = 222;
            this.splitContainer.Size = new System.Drawing.Size(1592, 902);
            this.splitContainer.SplitterDistance = 1290;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 2;
            // 
            // WMP
            // 
            this.WMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(0, 0);
            this.WMP.Margin = new System.Windows.Forms.Padding(4);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(1290, 902);
            this.WMP.TabIndex = 1;
            this.WMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WMP_PlayStateChange_1);
            this.WMP.PositionChange += new AxWMPLib._WMPOCXEvents_PositionChangeEventHandler(this.WMP_PositionChange);
            // 
            // tBoxChat
            // 
            this.tBoxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxChat.Location = new System.Drawing.Point(0, 301);
            this.tBoxChat.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxChat.Name = "tBoxChat";
            this.tBoxChat.ReadOnly = true;
            this.tBoxChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tBoxChat.Size = new System.Drawing.Size(297, 438);
            this.tBoxChat.TabIndex = 4;
            this.tBoxChat.Text = "";
            this.tBoxChat.SizeChanged += new System.EventHandler(this.tBoxChat_SizeChanged);
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnSend);
            this.panelInput.Controls.Add(this.tBoxInput);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 739);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(297, 57);
            this.panelInput.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSend.Depth = 0;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.HighEmphasis = true;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(233, 0);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSend.Size = new System.Drawing.Size(64, 57);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = ">";
            this.btnSend.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSend.UseAccentColor = false;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tBoxInput
            // 
            this.tBoxInput.AnimateReadOnly = false;
            this.tBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxInput.Depth = 0;
            this.tBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBoxInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tBoxInput.LeadingIcon = null;
            this.tBoxInput.Location = new System.Drawing.Point(0, 0);
            this.tBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxInput.MaxLength = 50;
            this.tBoxInput.MouseState = MaterialSkin.MouseState.OUT;
            this.tBoxInput.Multiline = false;
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(297, 50);
            this.tBoxInput.TabIndex = 0;
            this.tBoxInput.Text = "";
            this.tBoxInput.TrailingIcon = null;
            this.tBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxInput_KeyDown);
            // 
            // panelSettings
            // 
            this.panelSettings.AutoSize = true;
            this.panelSettings.Controls.Add(this.splitter8);
            this.panelSettings.Controls.Add(this.cbControlState);
            this.panelSettings.Controls.Add(this.splitter3);
            this.panelSettings.Controls.Add(this.btnChangePassword);
            this.panelSettings.Controls.Add(this.splitter4);
            this.panelSettings.Controls.Add(this.btnChooseFilm);
            this.panelSettings.Controls.Add(this.splitter5);
            this.panelSettings.Controls.Add(this.btnKick);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettings.Location = new System.Drawing.Point(0, 108);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(297, 193);
            this.panelSettings.TabIndex = 12;
            // 
            // splitter8
            // 
            this.splitter8.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter8.Enabled = false;
            this.splitter8.Location = new System.Drawing.Point(0, 181);
            this.splitter8.Margin = new System.Windows.Forms.Padding(4);
            this.splitter8.Name = "splitter8";
            this.splitter8.Size = new System.Drawing.Size(297, 12);
            this.splitter8.TabIndex = 13;
            this.splitter8.TabStop = false;
            // 
            // cbControlState
            // 
            this.cbControlState.AutoSize = true;
            this.cbControlState.Depth = 0;
            this.cbControlState.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbControlState.Location = new System.Drawing.Point(0, 144);
            this.cbControlState.Margin = new System.Windows.Forms.Padding(0);
            this.cbControlState.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbControlState.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbControlState.Name = "cbControlState";
            this.cbControlState.ReadOnly = false;
            this.cbControlState.Ripple = true;
            this.cbControlState.Size = new System.Drawing.Size(297, 37);
            this.cbControlState.TabIndex = 12;
            this.cbControlState.Text = "Запретить управление";
            this.cbControlState.UseVisualStyleBackColor = true;
            this.cbControlState.CheckedChanged += new System.EventHandler(this.cbControlState_CheckedChanged);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(0, 132);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(297, 12);
            this.splitter3.TabIndex = 11;
            this.splitter3.TabStop = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChangePassword.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChangePassword.Depth = 0;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.HighEmphasis = true;
            this.btnChangePassword.Icon = null;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 96);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnChangePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChangePassword.Size = new System.Drawing.Size(297, 36);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Изменить пароль";
            this.btnChangePassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChangePassword.UseAccentColor = false;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Enabled = false;
            this.splitter4.Location = new System.Drawing.Point(0, 84);
            this.splitter4.Margin = new System.Windows.Forms.Padding(4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(297, 12);
            this.splitter4.TabIndex = 9;
            this.splitter4.TabStop = false;
            // 
            // btnChooseFilm
            // 
            this.btnChooseFilm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseFilm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnChooseFilm.Depth = 0;
            this.btnChooseFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChooseFilm.HighEmphasis = true;
            this.btnChooseFilm.Icon = null;
            this.btnChooseFilm.Location = new System.Drawing.Point(0, 48);
            this.btnChooseFilm.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnChooseFilm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseFilm.Name = "btnChooseFilm";
            this.btnChooseFilm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnChooseFilm.Size = new System.Drawing.Size(297, 36);
            this.btnChooseFilm.TabIndex = 7;
            this.btnChooseFilm.Text = "Выбрать фильм";
            this.btnChooseFilm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnChooseFilm.UseAccentColor = false;
            this.btnChooseFilm.UseVisualStyleBackColor = true;
            this.btnChooseFilm.Click += new System.EventHandler(this.btnChooseFilm_Click);
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Enabled = false;
            this.splitter5.Location = new System.Drawing.Point(0, 36);
            this.splitter5.Margin = new System.Windows.Forms.Padding(4);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(297, 12);
            this.splitter5.TabIndex = 10;
            this.splitter5.TabStop = false;
            // 
            // btnKick
            // 
            this.btnKick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKick.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKick.Depth = 0;
            this.btnKick.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKick.HighEmphasis = true;
            this.btnKick.Icon = null;
            this.btnKick.Location = new System.Drawing.Point(0, 0);
            this.btnKick.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnKick.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKick.Name = "btnKick";
            this.btnKick.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKick.Size = new System.Drawing.Size(297, 36);
            this.btnKick.TabIndex = 8;
            this.btnKick.Text = "Исключить человека";
            this.btnKick.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKick.UseAccentColor = false;
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter6.Enabled = false;
            this.splitter6.Location = new System.Drawing.Point(0, 96);
            this.splitter6.Margin = new System.Windows.Forms.Padding(4);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(297, 12);
            this.splitter6.TabIndex = 13;
            this.splitter6.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSettings.Depth = 0;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.HighEmphasis = true;
            this.btnSettings.Icon = null;
            this.btnSettings.Location = new System.Drawing.Point(0, 60);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSettings.Size = new System.Drawing.Size(297, 36);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSettings.UseAccentColor = false;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Enabled = false;
            this.splitter2.Location = new System.Drawing.Point(0, 48);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(297, 12);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            this.splitter2.Visible = false;
            // 
            // btnOut
            // 
            this.btnOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOut.Depth = 0;
            this.btnOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOut.HighEmphasis = true;
            this.btnOut.Icon = null;
            this.btnOut.Location = new System.Drawing.Point(0, 12);
            this.btnOut.Margin = new System.Windows.Forms.Padding(53, 74, 53, 74);
            this.btnOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOut.Name = "btnOut";
            this.btnOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOut.Size = new System.Drawing.Size(297, 36);
            this.btnOut.TabIndex = 0;
            this.btnOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOut.UseAccentColor = false;
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(297, 12);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitter7
            // 
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter7.Enabled = false;
            this.splitter7.Location = new System.Drawing.Point(0, 796);
            this.splitter7.Margin = new System.Windows.Forms.Padding(4);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(297, 12);
            this.splitter7.TabIndex = 16;
            this.splitter7.TabStop = false;
            // 
            // panelEmoji
            // 
            this.panelEmoji.Controls.Add(this.emojiSurprise);
            this.panelEmoji.Controls.Add(this.emojiCry);
            this.panelEmoji.Controls.Add(this.emojiLaugh);
            this.panelEmoji.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEmoji.Location = new System.Drawing.Point(0, 808);
            this.panelEmoji.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmoji.Name = "panelEmoji";
            this.panelEmoji.Size = new System.Drawing.Size(297, 94);
            this.panelEmoji.TabIndex = 15;
            // 
            // emojiSurprise
            // 
            this.emojiSurprise.AutoSize = true;
            this.emojiSurprise.Depth = 0;
            this.emojiSurprise.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emojiSurprise.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.emojiSurprise.Location = new System.Drawing.Point(196, 4);
            this.emojiSurprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emojiSurprise.MouseState = MaterialSkin.MouseState.HOVER;
            this.emojiSurprise.Name = "emojiSurprise";
            this.emojiSurprise.Size = new System.Drawing.Size(74, 72);
            this.emojiSurprise.TabIndex = 2;
            this.emojiSurprise.Text = "😲";
            this.emojiSurprise.DoubleClick += new System.EventHandler(this.emojiSurprise_DoubleClick);
            // 
            // emojiCry
            // 
            this.emojiCry.AutoSize = true;
            this.emojiCry.Depth = 0;
            this.emojiCry.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emojiCry.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.emojiCry.Location = new System.Drawing.Point(99, 2);
            this.emojiCry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emojiCry.MouseState = MaterialSkin.MouseState.HOVER;
            this.emojiCry.Name = "emojiCry";
            this.emojiCry.Size = new System.Drawing.Size(74, 72);
            this.emojiCry.TabIndex = 1;
            this.emojiCry.Text = "😭";
            this.emojiCry.DoubleClick += new System.EventHandler(this.emojiCry_DoubleClick);
            // 
            // emojiLaugh
            // 
            this.emojiLaugh.AutoSize = true;
            this.emojiLaugh.Depth = 0;
            this.emojiLaugh.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emojiLaugh.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.emojiLaugh.Location = new System.Drawing.Point(-8, 4);
            this.emojiLaugh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emojiLaugh.MouseState = MaterialSkin.MouseState.HOVER;
            this.emojiLaugh.Name = "emojiLaugh";
            this.emojiLaugh.Size = new System.Drawing.Size(74, 72);
            this.emojiLaugh.TabIndex = 0;
            this.emojiLaugh.Text = "🤣";
            this.emojiLaugh.DoubleClick += new System.EventHandler(this.emojiLaugh_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 985);
            this.Controls.Add(this.panelRoom);
            this.Controls.Add(this.panelChoose);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(853, 591);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Совместный просмотр фильмов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelChoose.ResumeLayout(false);
            this.panelRoom.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelEmoji.ResumeLayout(false);
            this.panelEmoji.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBottom;
        private MaterialSkin.Controls.MaterialButton btnCreateRoom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel labelCinemaRooms;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelChoose;
        private System.Windows.Forms.Panel panelRoom;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.SplitContainer splitContainer;
        private MaterialSkin.Controls.MaterialButton btnSettings;
        private System.Windows.Forms.Splitter splitter2;
        private MaterialSkin.Controls.MaterialButton btnOut;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox tBoxChat;
        private MaterialSkin.Controls.MaterialButton btnChangePassword;
        private System.Windows.Forms.Splitter splitter4;
        private MaterialSkin.Controls.MaterialButton btnChooseFilm;
        private System.Windows.Forms.Splitter splitter5;
        private MaterialSkin.Controls.MaterialButton btnKick;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panelInput;
        private MaterialSkin.Controls.MaterialButton btnSend;
        private MaterialSkin.Controls.MaterialTextBox tBoxInput;
        private System.Windows.Forms.Panel panelEmoji;
        private System.Windows.Forms.Splitter splitter7;
        private MaterialSkin.Controls.MaterialLabel emojiLaugh;
        private MaterialSkin.Controls.MaterialLabel emojiSurprise;
        private MaterialSkin.Controls.MaterialLabel emojiCry;
        private System.Windows.Forms.Splitter splitter8;
        private MaterialSkin.Controls.MaterialCheckbox cbControlState;
    }
}

