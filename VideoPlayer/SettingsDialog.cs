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
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VideoPlayer
{
    public partial class SettingsDialog : MaterialForm
    {
        public string newPassword;
        public string id;
        private List<ListViewItem> originalItems;

        private void InitializeMaterialSkin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
        public SettingsDialog()
        {
            InitializeMaterialSkin();
            this.Text = "Смена пароля";
            panelPassword.Visible = true;
        }
              
        public SettingsDialog(Dictionary<int, Movie> movies)
        {
            InitializeMaterialSkin();
            this.Text = "Выбор фильма";
            listViewFilms.Columns.Add("Year", 100, HorizontalAlignment.Left);
            listViewFilms.Columns.Add("Title", -2, HorizontalAlignment.Left);
            originalItems = new List<ListViewItem>();

            foreach (var movie in movies.Values)
            {
                ListViewItem item = new ListViewItem(new string[] {  movie.Year.ToString(), movie.Title });
                item.Tag = movie.Id;
                listViewFilms.Items.Add(item);
                originalItems.Add((ListViewItem)item.Clone());
            }

            panelFilm.Visible = true;   
        }

        public SettingsDialog(Dictionary<string, string> members)
        {
            InitializeMaterialSkin();
            this.Text = "Исключение зрителя";

            var column = new ColumnHeader
            {
                Text = "Зрители",
                Width = listViewMembers.Width

            };

            listViewMembers.Columns.Add(column);


            foreach (var member in members)
            {
                ListViewItem item = new ListViewItem(member.Value);
                item.Tag = member.Key; 
                listViewMembers.Items.Add(item);
            }

            panelMembers.Visible = true;
        }




        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0 && listViewMembers.SelectedItems.Count == 0 && listViewFilms.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы ничего не ввели", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxPassword.Text.Length != 0)
            {
                newPassword = textBoxPassword.Text;

            } 
            else if (listViewMembers.SelectedItems.Count != 0)
            {
                id = listViewMembers.SelectedItems[0].Tag.ToString();
            }
            else if (listViewFilms.SelectedItems.Count != 0)
            {
                id = listViewFilms.SelectedItems[0].Tag.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbFind.Text;

            listViewFilms.BeginUpdate();
            listViewFilms.Items.Clear();

            foreach (ListViewItem item in originalItems)
            {
                if (item.SubItems[1].Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    listViewFilms.Items.Add(item);
                }
            }

            listViewFilms.EndUpdate();
        }
    }
}
