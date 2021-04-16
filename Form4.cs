using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton10.Checked)
                textBox1.Text = "R1 Mambalam Police Station";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton1.Checked)
                textBox1.Text = "Triplicane Police Station";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton2.Checked)
                textBox1.Text = "Velachery Police Station";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton3.Checked)
                textBox1.Text = "Adyar Police Station";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton4.Checked)
                textBox1.Text = "EGMORE Police Station";

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton5.Checked)
                textBox1.Text = "Anna Salai D2 Police Station";

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton6.Checked)
                textBox1.Text = "Rajamangalam Police station";

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton7.Checked)
                textBox1.Text = "Periamet Police Station";

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton8.Checked)
                textBox1.Text = "Choolaimedu Police Station";

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton9.Checked)
                textBox1.Text = "R11 Royala Nagar Police Station";

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton11.Checked)
                textBox1.Text = "R9 Valasaravakkam Police Station";

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton12.Checked)
                textBox1.Text = "R6 Kumaran Nagar, Police Station";

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton13.Checked)
                textBox1.Text = "H4 Korukkupet Police Station";

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton14.Checked)
                textBox1.Text = "Kotturpuram Police Station";

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton15.Checked)
                textBox1.Text = "K4 Police Station";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.Diagnostics.Process.Start("https://www.livechennai.com/chennai_triplicane_DCPoffice_police_station_in_chennai.asp");           
            }
            else if (radioButton2.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/police-stations/velachery-chennai");
            }
            else if (radioButton3.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/police-stations/adyar-chennai");

            }
            else if (radioButton4.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/police-stations/egmore-chennai");

            }
            else if (radioButton5.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/d2-annasalai-police-station-chintadripet-chennai-contact-address");

            }
            else if (radioButton6.Checked)
            {
                System.Diagnostics.Process.Start("http://www.reach2biz.com/listings/v-4-kolathur-rajamangalam-police-station/");

            }
            else if (radioButton7.Checked)
            {
                System.Diagnostics.Process.Start("https://vymaps.com/IN/G2-Periamet-Police-Station-152598612039223/");

            }
            else if (radioButton8.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/police-stations/choolaimedu-chennai");

            }
            else if (radioButton9.Checked)
            {
                System.Diagnostics.Process.Start("https://vymaps.com/IN/R11-Police-Station-392598/");

            }
            else if (radioButton10.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/r1-mambalam-police-station-t-nagar-chennai-contact-address");

            }
            else if (radioButton11.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/r9-police-station-valasaravakkam-chennai-contact-address");

            }
            else if (radioButton12.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/r6-kumaran-nagar-police-station-ashok-nagar-chennai-contact-address");

            }
            else if (radioButton13.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/h4-korukkupet-police-station-korrukupet-chennai-contact-address");

            }
            else if (radioButton14.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sulekha.com/police-stations/kotturpuram-chennai");

            }
            else if (radioButton15.Checked)
            {
                System.Diagnostics.Process.Start("K4 Police Station");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
    }
}

