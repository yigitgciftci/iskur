using Ganss.Excel;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Math.EC.Multiplier;
using System.Drawing;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsGaleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Album> albums = new List<Album>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.AlbumName = txtAlbumName.Text;
            album.Descripiton = txtDescription.Text;
            //album.ImagePath = picAlbum.ImageLocation;

            albums.Add(album);

            lstAlbum.DataSource = null;
            lstAlbum.DataSource = albums;
        }
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            openFileDialog.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox picture = new PictureBox();
            }
            flowLayoutPanel1.Controls.Add(picture);               
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstAlbum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayýt seçiniz..");
                return;
            }

            albums.RemoveAt(lstAlbum.SelectedIndex);

            lstAlbum.DataSource = null;
            lstAlbum.DataSource = albums;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(albums, new JsonSerializerOptions() { WriteIndented = true });

            string path = Application.StartupPath + "albums.json";
            
            File.WriteAllText(path, json);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelMapper excelMapper = new ExcelMapper();
            excelMapper.Save("albums.xlsx", albums, "Albums");

            MessageBox.Show("Kaydedildi.");
        }
    }
}