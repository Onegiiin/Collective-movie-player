namespace VideoPlayer
{
    partial class InputRoomDialog
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
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxPassword = new MaterialSkin.Controls.MaterialCheckbox();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.textBoxTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxNick = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.labelName.Location = new System.Drawing.Point(67, 147);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(226, 41);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Ваш никнейм:";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.labelTitle.Location = new System.Drawing.Point(67, 89);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(316, 41);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Название комнаты:";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Depth = 0;
            this.checkBoxPassword.Location = new System.Drawing.Point(67, 205);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.ReadOnly = false;
            this.checkBoxPassword.Ripple = true;
            this.checkBoxPassword.Size = new System.Drawing.Size(156, 37);
            this.checkBoxPassword.TabIndex = 7;
            this.checkBoxPassword.Text = "Вход по паролю";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckStateChanged += new System.EventHandler(this.checkBoxPassword_CheckStateChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelPassword.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.labelPassword.Location = new System.Drawing.Point(67, 259);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(128, 41);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль:";
            this.labelPassword.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(269, 337);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(89, 36);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Создать";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = false;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTitle.AnimateReadOnly = false;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitle.LeadingIcon = null;
            this.textBoxTitle.Location = new System.Drawing.Point(393, 89);
            this.textBoxTitle.MaxLength = 50;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTitle.Multiline = false;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(155, 50);
            this.textBoxTitle.TabIndex = 10;
            this.textBoxTitle.Text = "";
            this.textBoxTitle.TrailingIcon = null;
            // 
            // textBoxNick
            // 
            this.textBoxNick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNick.AnimateReadOnly = false;
            this.textBoxNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNick.Depth = 0;
            this.textBoxNick.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNick.LeadingIcon = null;
            this.textBoxNick.Location = new System.Drawing.Point(393, 147);
            this.textBoxNick.MaxLength = 50;
            this.textBoxNick.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNick.Multiline = false;
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(155, 50);
            this.textBoxNick.TabIndex = 11;
            this.textBoxNick.Text = "";
            this.textBoxNick.TrailingIcon = null;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(393, 259);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 50);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            this.textBoxPassword.Visible = false;
            // 
            // InputRoomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 423);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.Name = "InputRoomDialog";
            this.Sizable = false;
            this.Text = "Создание комнаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxPassword;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialButton btnConfirm;
        private MaterialSkin.Controls.MaterialTextBox textBoxTitle;
        private MaterialSkin.Controls.MaterialTextBox textBoxNick;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
    }
}