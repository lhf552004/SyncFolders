using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.IO;
using BusinessObjects;

namespace SyncFolders
{
    public partial class Filters : MaterialForm
    {
        public Filters()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo600, Primary.Indigo500, Primary.Indigo600, Accent.LightBlue200, TextShade.WHITE);
        }

        private void NewFilterText_Enter(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewFilterText.Text))
            {
                Utils.addFilter(NewFilterText.Text);
                this.FilterListBox.Items.Add(NewFilterText.Text);
                NewFilterText.Text = "";
            }


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (FilterListBox.SelectedItems.Count > 0)
            {

                string filterToDelete = FilterListBox.SelectedItems[0].ToString();
                Utils.deleteFilter(filterToDelete);
                this.FilterListBox.Items.Remove(FilterListBox.SelectedItems[0]);
            }
        }

        private void Filters_Load(object sender, EventArgs e)
        {
            Utils.readFilters();
            updateList();

        }
        private void updateList()
        {
            this.FilterListBox.Items.Clear();
            this.FilterListBox.BeginUpdate();
            foreach (var filter in Utils.Filters)
            {
                this.FilterListBox.Items.Add(filter.ToString());

            }
            this.FilterListBox.EndUpdate();
        }

        private void NewFilterText_Click(object sender, EventArgs e)
        {
            NewFilterText.Text = "";
        }

        private void NewFilterText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton_Click(null, null);
            }
        }
    }
}
