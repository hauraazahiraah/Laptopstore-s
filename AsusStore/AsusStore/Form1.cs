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
    public partial class Form1 : Form
    {
        laptopstoreEntities db = new laptopstoreEntities(); 

        public Form1()
        {
            InitializeComponent();
        }
        void login()
        {
            var Nama = txtb1.Text;
            var Password = txtb2.Text;
            var Data = db.DataUser.FirstOrDefault(X => X.Nama == Nama && X.Password == Password);
            if (Data != null) 
            {
                MessageBox.Show("Welcome " + Data.Nama);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void txtblogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register register = new register(); 
            register.ShowDialog();
        }
    }
}
