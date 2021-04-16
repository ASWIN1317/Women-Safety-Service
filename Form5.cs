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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Auto will arrive at your current loaction '"+ textBox1.Text +"' ,Please be ready with the amount Rs 50 ,Upon reaching your area we will contact your  registered number");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Prime will arrive at your current loaction '" + textBox1.Text + "' ,Please be ready with the amount Rs 100 ,Upon reaching your area we will contact your  registered number");
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

        private void button4_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int randomNumber;
            Random randm = new Random();
            randomNumber = randm.Next(1000, 10000);
            MessageBox.Show("The OTP for your ride is '" + randomNumber + "'");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
