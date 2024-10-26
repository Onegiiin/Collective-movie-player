namespace VideoPlayer
{
    partial class JoinRoomDialog
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
            this.btnConfirm = new MaterialSkin.Controls.MaterialButton();
            this.textBoxNick = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirm.Depth = 0;
            this.btnConfirm.HighEmphasis = true;
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(184, 294);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirm.Size = new System.Drawing.Size(71, 36);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Войти";
            this.btnConfirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirm.UseAccentColor = false;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textBoxNick
            // 
            this.textBoxNick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNick.AnimateReadOnly = false;
            this.textBoxNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNick.Depth = 0;
            this.textBoxNick.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNick.Hint = "Никнейм";
            this.textBoxNick.LeadingIcon = null;
            this.textBoxNick.Location = new System.Drawing.Point(126, 97);
            this.textBoxNick.MaxLength = 50;
            this.textBoxNick.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNick.Multiline = false;
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(193, 50);
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
            this.textBoxPassword.Hint = "Пароль";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(126, 199);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(193, 50);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            this.textBoxPassword.Visible = false;
            // 
            // JoinRoomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 378);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.btnConfirm);
            this.Name = "JoinRoomDialog";
            this.Sizable = false;
            this.Text = "Вход в комнату";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnConfirm;
        private MaterialSkin.Controls.MaterialTextBox textBoxNick;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
    }
}