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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton1.Checked)
                textBox1.Text = "Be Well Hospital";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton2.Checked)
                textBox1.Text = "Apollo City Centre Hospital Sowcarpet";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                System.Diagnostics.Process.Start("https://www.bewellhospitals.in/");

            }
            else if (radioButton2.Checked)
            {
                System.Diagnostics.Process.Start("https://www.askapollo.com/404");
            }
            else if (radioButton3.Checked)
            {
                System.Diagnostics.Process.Start("http://www.mehtahospital.com/");

            }
            else if (radioButton4.Checked)
            {
                System.Diagnostics.Process.Start("https://www.vhospitals.com/");

            }
            else if (radioButton5.Checked)
            {
                System.Diagnostics.Process.Start("https://www.miotinternational.com/");

            }
            else if (radioButton6.Checked)
            {
                System.Diagnostics.Process.Start("https://www.kauveryhospital.com/");

            }
            else if (radioButton7.Checked)
            {
                System.Diagnostics.Process.Start("https://www.stisabelshospital.in/");

            }
            else if (radioButton8.Checked)
            {
                System.Diagnostics.Process.Start("https://www.billrothhospitals.com/");

            }
            else if (radioButton9.Checked)
            {
                System.Diagnostics.Process.Start("https://vijayahospital.org/");

            }
            else if (radioButton10.Checked)
            {
                System.Diagnostics.Process.Start("http://www.medindiahospitals.com/");

            }
            else if (radioButton11.Checked)
            {
                System.Diagnostics.Process.Start("http://lifecarehospitals.in/");

            }
            else if (radioButton12.Checked)
            {
                System.Diagnostics.Process.Start("http://www.tngmssh.tn.gov.in/");

            }
            else if (radioButton13.Checked)
            {
                System.Diagnostics.Process.Start("https://www.sriramachandra.edu.in/medical/career/");

            }
            else if (radioButton14.Checked)
            {
                System.Diagnostics.Process.Start("http://www.velacherykshospital.org/");

            }
            else if (radioButton15.Checked)
            {
                System.Diagnostics.Process.Start("https://vihaahospital.com/");

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton3.Checked)
                textBox1.Text = "Dr. Mehta's Hospitals";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton4.Checked)
                textBox1.Text = "Venkataeswara Hospitals";

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton5.Checked)
                textBox1.Text = "Miot Hospital ";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton6.Checked)
                textBox1.Text = "Kauvery Hospital Chennai";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton7.Checked)
                textBox1.Text = "St.Isabel's Hospital";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton8.Checked)
                textBox1.Text = "Billroth Hospital";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton9.Checked)
                textBox1.Text = "Vijaya Group of Hospital";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton10.Checked)
                textBox1.Text = "MedIndia Hospitals";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton11.Checked)
                textBox1.Text = "Life Care Hospital";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton12.Checked)
                textBox1.Text = "Corporation Govt. hospital";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton13.Checked)
                textBox1.Text = "SRI RAMCHANDARAN HOSPITAL";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton14.Checked)
                textBox1.Text = "Velachery KS Hospital";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            string value = "";
            if (radioButton15.Checked)
                textBox1.Text = "Vihaa Multi Speciality Hospital";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
