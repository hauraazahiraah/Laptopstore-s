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
    public partial class register : Form
    {
        laptopstoreEntities db = new laptopstoreEntities();

        public register()
        {
            InitializeComponent();
        }
        void regist()
        {
            DataUser z = new DataUser();
            z.Nama = txtb1.Text;
            z.Password = txtb2.Text;

            db.DataUser.Add(z);
            db.SaveChanges();
            MessageBox.Show("Daftar Berhasil");
            this.Close();
        }

        private void txtblogin_Click(object sender, EventArgs e)
        {
            regist();
        }
    }
}