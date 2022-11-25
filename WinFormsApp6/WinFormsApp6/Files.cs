using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp6
{
    public partial class Files : Form    {        
        public Files()
        {
            InitializeComponent();
        }
        Vehicle vehicle1 = null;
        private List<Vehicle> _vehicle = new List<Vehicle>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            vehicle1 = new Vehicle
            {
                Brands = cmbBrands.Text,
                Models = cmbModels.Text,
                Km = txtKm.Text,
                Year = txtYear.Text,
            };
            _vehicle.Add(vehicle1);

            lstBrandModel.Items.Add(vehicle1);

            //lstBrandModel.DataSource = null;
            //lstBrandModel.DataSource = _vehicle;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BrandManage BrandManage = new BrandManage();
            BrandManage.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ModelManage ModelManage = new ModelManage();
            ModelManage.Show();
        }
        private List<Rent> _rent = new List<Rent>();
        private void btnRent_Click(object sender, EventArgs e)
        {
            Rent rent1 = new Rent
            {
                FullName = txtFullName.Text,
                IdentifyNumber = txtIdentifyNumber.Text,
                StartDate = dtpStartDate.Value,
                FinishDate = dtpFinishDate.Value,
                DownPayment = (int)nudDownPayment.Value,
            };
            _rent.Add(rent1);

            lstRentalList.Items.Add(rent1);

            lstRentalList.DataSource = null;
            lstRentalList.DataSource = _rent;
        }
        private void lstRentalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstRentalList.SelectedIndex;
        }
        private void btnDeleteRentList_Click(object sender, EventArgs e)
        {
            _rent.RemoveAt(lstRentalList.SelectedIndex);

            lstRentalList.DataSource = null;
            lstRentalList.DataSource = _rent;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\user.json";

            string json = JsonSerializer.Serialize(_vehicle);
            
            File.WriteAllText(path, json);

            MessageBox.Show("Kaydedildi.");
        }
    }
}
