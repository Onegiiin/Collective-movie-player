namespace VideoPlayer
{
    partial class SettingsDialog
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
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.listViewFilms = new MaterialSkin.Controls.MaterialListView();
            this.panelMembers = new System.Windows.Forms.Panel();
            this.listViewMembers = new MaterialSkin.Controls.MaterialListView();
            this.tbFind = new MaterialSkin.Controls.MaterialTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelPassword.SuspendLayout();
            this.panelFilm.SuspendLayout();
            this.panelMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPassword.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.labelPassword.Location = new System.Drawing.Point(69, 84);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(240, 41);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Новый пароль:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(249, 352);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(129, 36);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = false;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(315, 84);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(232, 50);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.labelPassword);
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPassword.Location = new System.Drawing.Point(3, 538);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(631, 237);
            this.panelPassword.TabIndex = 13;
            this.panelPassword.Visible = false;
            // 
            // panelFilm
            // 
            this.panelFilm.Controls.Add(this.listViewFilms);
            this.panelFilm.Controls.Add(this.splitter1);
            this.panelFilm.Controls.Add(this.tbFind);
            this.panelFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilm.Location = new System.Drawing.Point(3, 64);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(631, 237);
            this.panelFilm.TabIndex = 14;
            this.panelFilm.Visible = false;
            // 
            // listViewFilms
            // 
            this.listViewFilms.AutoSizeTable = false;
            this.listViewFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewFilms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFilms.Depth = 0;
            this.listViewFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFilms.FullRowSelect = true;
            this.listViewFilms.HideSelection = false;
            this.listViewFilms.Location = new System.Drawing.Point(0, 57);
            this.listViewFilms.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewFilms.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewFilms.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewFilms.MultiSelect = false;
            this.listViewFilms.Name = "listViewFilms";
            this.listViewFilms.OwnerDraw = true;
            this.listViewFilms.Size = new System.Drawing.Size(631, 180);
            this.listViewFilms.TabIndex = 0;
            this.listViewFilms.UseCompatibleStateImageBehavior = false;
            this.listViewFilms.View = System.Windows.Forms.View.Details;
            // 
            // panelMembers
            // 
            this.panelMembers.Controls.Add(this.listViewMembers);
            this.panelMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMembers.Location = new System.Drawing.Point(3, 301);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(631, 237);
            this.panelMembers.TabIndex = 15;
            this.panelMembers.Visible = false;
            // 
            // listViewMembers
            // 
            this.listViewMembers.AutoSizeTable = false;
            this.listViewMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewMembers.Depth = 0;
            this.listViewMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMembers.FullRowSelect = true;
            this.listViewMembers.HideSelection = false;
            this.listViewMembers.Location = new System.Drawing.Point(0, 0);
            this.listViewMembers.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewMembers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewMembers.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewMembers.MultiSelect = false;
            this.listViewMembers.Name = "listViewMembers";
            this.listViewMembers.OwnerDraw = true;
            this.listViewMembers.Size = new System.Drawing.Size(631, 237);
            this.listViewMembers.TabIndex = 0;
            this.listViewMembers.UseCompatibleStateImageBehavior = false;
            this.listViewMembers.View = System.Windows.Forms.View.Details;
            // 
            // tbFind
            // 
            this.tbFind.AnimateReadOnly = false;
            this.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFind.Depth = 0;
            this.tbFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFind.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFind.Hint = "Поиск по названию";
            this.tbFind.LeadingIcon = null;
            this.tbFind.Location = new System.Drawing.Point(0, 0);
            this.tbFind.MaxLength = 50;
            this.tbFind.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFind.Multiline = false;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(631, 50);
            this.tbFind.TabIndex = 1;
            this.tbFind.Text = "";
            this.tbFind.TrailingIcon = null;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 50);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(631, 7);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 423);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelMembers);
            this.Controls.Add(this.panelFilm);
            this.Controls.Add(this.btnConfirm);
            this.Name = "SettingsDialog";
            this.Sizable = false;
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelFilm.ResumeLayout(false);
            this.panelMembers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelFilm;
        private MaterialSkin.Controls.MaterialListView listViewFilms;
        private System.Windows.Forms.Panel panelMembers;
        private MaterialSkin.Controls.MaterialListView listViewMembers;
        private MaterialSkin.Controls.MaterialTextBox tbFind;
        private System.Windows.Forms.Splitter splitter1;
    }
}