using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsusStore
{
    public partial class Form2 : Form
    {
        laptopstoreEntities db = new laptopstoreEntities();
        databarang data = new databarang();   
        DataUser user = new DataUser();
        int id;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
            clear();
            this.ActiveControl = txtb1;
        }
        void clear()
        {
            txtb1.Text = txtb2.Text = txtb3.Text = "";
            btncreate.Text = "Save";
            user.IdUser = 0;
        }

        void LoadData()
        {
            var data = db.databarang.ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Columns["Hapus"] == null)
            {
                DataGridViewImageColumn btnHapus = new DataGridViewImageColumn
                {
                    Name = "Hapus",
                    HeaderText = "Aksi",
                    Image = (Image)Properties.Resources.Trash,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(btnHapus);
            }
        }
        private void btncreate_Click(object sender, EventArgs e)
        {
            data.Namabarang = txtb1.Text.Trim();
            data.Hargabarang = txtb2.Text.Trim();
            data.Stokbarang = txtb3.Text.Trim();    
            db.databarang.Add(data);
            db.SaveChanges();
            clear();
            LoadData();
            MessageBox.Show("Data Berhasil Disimpan");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                id = (int)row.Cells["kodebarang"].Value;
                txtb1.Text = row.Cells["Namabarang"].Value.ToString();
                txtb2.Text = row.Cells["Hargabarang"].Value.ToString();
                txtb3.Text = row.Cells["Stokbarang"].Value.ToString();
                if (row.Cells["Hapus"].Selected)
                {
                    int id = (int)row.Cells["kodebarang"].Value;
                    var msg = MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msg == DialogResult.Yes)
                    {
                        var data = db.databarang.FirstOrDefault(x => x.kodebarang == id);
                        db.databarang.Remove(data);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var barang = db.databarang.FirstOrDefault(x => x.kodebarang == id);
            string namaBarangBaru = txtb1.Text;
            barang.Namabarang = namaBarangBaru;
            barang.Hargabarang = txtb2.Text;
            barang.Stokbarang = txtb3.Text;
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Di Update");
            LoadData();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
