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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

		int startpoint = 0;
		
		private void SplashScreen_Load(object sender, EventArgs e)
        {
			timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
			startpoint += 1;
			progressBar1.Value = startpoint;
			if (progressBar1.Value == 100)
			{
				progressBar1.Value = 0;
				timer1.Stop();
				Form1 log = new Form1();
				this.Hide();
				log.Show();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}
