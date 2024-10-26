using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class InputRoomDialog : MaterialForm
    {
        public string title;
        public string userName;
        public string password;

        public bool passwordUsing;
        public InputRoomDialog()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void checkBoxPassword_CheckStateChanged(object sender, EventArgs e)
        {
            labelPassword.Visible = textBoxPassword.Visible = checkBoxPassword.Checked;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxNick.Text.Length == 0 || textBoxTitle.Text.Length == 0 || (checkBoxPassword.Checked && textBoxPassword.Text.Length == 0))
            {
                MessageBox.Show("Заполните все необходимые поля", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.userName = textBoxNick.Text;
            this.title = textBoxTitle.Text;
            this.passwordUsing = checkBoxPassword.Checked;
            this.password = textBoxPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
