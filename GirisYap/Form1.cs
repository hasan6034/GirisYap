using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GirisYap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=girisyap;Uid=root;");
        MySqlCommand cmd;
        MySqlDataReader dr;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM user where kadi='" + txtKadi.Text + "' AND sifre='" + txtSifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı");
            }
            else MessageBox.Show("Kullanıcı adı veya şifre hatalı lütfen tekrar deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void lblGiris_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "Server=localhost;Database=girisyap;Uid=root;";
            string Query = "insert into user values('" + this.txtAd.Text + "','" + this.txtSoyad.Text + "','" + this.txtEmail.Text + "','" + this.txtKayıtSifre.Text + "');";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Üye oldunuz. Giriş yapabilirsiniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();

        }
    }
}
