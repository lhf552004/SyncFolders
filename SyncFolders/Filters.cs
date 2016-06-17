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
            }
           

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void Filters_Load(object sender, EventArgs e)
        {
            Utils.readFilters();
        }
    }
}
