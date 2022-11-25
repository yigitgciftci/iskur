using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class BrandManage : Form
    {
        public BrandManage()
        {
            InitializeComponent();
        }
        private List<string> brands = new List<string>();
        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            string brandadd = txtBrandName.Text;
            lstBrand.Items.Add(brandadd);

            lstBrand.DataSource = null;
            lstBrand.DataSource = brands;
        }
        private void lstBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBrand.SelectedIndex;
            if (index >= 0)
            {
                string isim = lstBrand.SelectedItem.ToString();
                txtBrandName.Text = isim;
            }
        }
        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            int index = lstBrand.SelectedIndex;
            brands.RemoveAt(index);

            lstBrand.DataSource = null;
            lstBrand.DataSource = brands;
        }

        private void btnEditBrand_Click(object sender, EventArgs e)
        {
            int index = lstBrand.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir kişi seçiniz.");
                return;
            }
            string brandname1 = txtBrandName.Text;
            string info = $"{brandname1}";

            lstBrand.Items[lstBrand.SelectedIndex] = info;

            lstBrand.DataSource = null;
            lstBrand.DataSource = brands;
        }
        private void SaveData()
        {
            JsonSerializer.Serialize(brands, CreateJsonSerializerOptions());
        }
        private static JsonSerializerOptions CreateJsonSerializerOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            return options;
        }

        private void BrandManage_Load(object sender, EventArgs e)
        {

        }
    }
}
