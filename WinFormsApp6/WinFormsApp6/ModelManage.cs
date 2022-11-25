using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class ModelManage : Form
    {
        public ModelManage()
        {
            InitializeComponent();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            string modeladd = txtModelName.Text;
            lstModel.Items.Add(modeladd);
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            int index = lstModel.SelectedIndex;
            lstModel.Items.RemoveAt(index);
        }

        private void btnEditModel_Click(object sender, EventArgs e)
        {
            int index = lstModel.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir kişi seçiniz.");
                return;
            }
            string brandname1 = txtModelName.Text;
            string info = $"{brandname1}";

            lstModel.Items[lstModel.SelectedIndex] = info;
        }

        private void lstModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstModel.SelectedIndex;
            if (index >= 0)
            {
                string isim = lstModel.SelectedItem.ToString();
                txtModelName.Text = isim;
            }
        }
    }
}
