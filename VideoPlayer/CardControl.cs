using MaterialSkin;
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
    public partial class CardControl : UserControl
    {
        public event EventHandler ButtonClicked;
        public int roomId;
        public CardControl(string title, string views, string film, bool passwordUsing, int roomId)
        {
            InitializeComponent();
            labelTitle.FontType = MaterialSkinManager.fontType.H4;
            this.Load += new EventHandler(CardControl_Load);
            panel2.SizeChanged += new EventHandler(Panel_SizeChanged);
            panel1.SizeChanged += new EventHandler(Panel_SizeChanged);
            labelTitle.Text = title;
            labelViews.Text += views;
            labelFilm.Text += film;
            labelPassword.Text += passwordUsing ? "Да" : "Нет";
            this.roomId = roomId;
        }

        private void CardControl_Load(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void Panel_SizeChanged(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            labelTitle.Location = new Point((panel2.Width - labelTitle.Width) / 2, 10);
            btnConnect.Location = new Point((panel1.Width - btnConnect.Width) / 2, 0);
        }

        private void CardControl_Load_1(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        public void UpdateView(string title, string views, string film, bool passwordUsing)
        {
            labelTitle.Text = title;
            labelViews.Text = "Зрители: " + views;
            labelFilm.Text = "Фильм: " + film;
            labelPassword.Text = "Вход по паролю: " + (passwordUsing ? "Да" : "Нет");
        }
    }
}
