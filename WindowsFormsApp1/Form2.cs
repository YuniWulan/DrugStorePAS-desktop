using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int harga, jumlah, total;
            harga = int.Parse(this.guna2TextBox1.Text);
            jumlah = int.Parse(this.guna2TextBox2.Text);
            total = harga * jumlah;
            this.guna2TextBox3.Text = total.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int total, tunai, kembalian;
            total = int.Parse(this.guna2TextBox3.Text);
            tunai = int.Parse(this.guna2TextBox4.Text);
            kembalian = tunai - total;
            this.guna2TextBox5.Text = kembalian.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.ResetText();
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
