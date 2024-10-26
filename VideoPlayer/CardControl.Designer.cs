namespace VideoPlayer
{
    partial class CardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.btnConnect = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.labelViews = new MaterialSkin.Controls.MaterialLabel();
            this.labelFilm = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(112, 18);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1, 0);
            this.labelTitle.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConnect.Depth = 0;
            this.btnConnect.HighEmphasis = true;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(98, 17);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConnect.Size = new System.Drawing.Size(98, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Вступить";
            this.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConnect.UseAccentColor = false;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 54);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 45);
            this.panel2.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelPassword.Location = new System.Drawing.Point(9, 128);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(126, 19);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Вход по паролю:";
            // 
            // labelViews
            // 
            this.labelViews.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelViews.AutoSize = true;
            this.labelViews.Depth = 0;
            this.labelViews.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelViews.Location = new System.Drawing.Point(9, 48);
            this.labelViews.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(67, 19);
            this.labelViews.TabIndex = 1;
            this.labelViews.Text = "Зрители:";
            // 
            // labelFilm
            // 
            this.labelFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFilm.AutoSize = true;
            this.labelFilm.Depth = 0;
            this.labelFilm.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilm.Location = new System.Drawing.Point(9, 88);
            this.labelFilm.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(56, 19);
            this.labelFilm.TabIndex = 3;
            this.labelFilm.Text = "Фильм:";
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.labelViews);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.MaximumSize = new System.Drawing.Size(0, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(300, 250);
            this.Load += new System.EventHandler(this.CardControl_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialLabel labelViews;
        private MaterialSkin.Controls.MaterialLabel labelFilm;
    }
}
