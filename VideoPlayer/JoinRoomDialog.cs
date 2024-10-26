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
    public partial class JoinRoomDialog : MaterialForm
    {
        public bool passwordUsing;
        public string nick;
        public string password;
        public JoinRoomDialog(bool password)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            passwordUsing  = password;  
            textBoxPassword.Visible = passwordUsing;
         
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxNick.Text.Length == 0 ||(passwordUsing && textBoxPassword.Text.Length == 0))
            {
                MessageBox.Show("Заполните все необходимые поля", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.nick = textBoxNick.Text;
            this.password = textBoxPassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
