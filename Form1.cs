using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_System
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Aswini\Documents\DB_Server1.mdf;Integrated Security = True; Connect Timeout = 30");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [MyTable]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Aswini\Documents\DB_Server1.mdf;Integrated Security = True; Connect Timeout = 30");


            Connection.Open();

            SqlCommand cmd = new SqlCommand("insert into [MyTable] values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim()  + "')", Connection);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ACCOUNT CREATED!!");
            Connection.Close();


        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Aswini\Documents\DB_Server1.mdf;Integrated Security = True; Connect Timeout = 30");


            Connection.Open();

            SqlCommand cmd = new SqlCommand("delete from [MyTable] where name='" + textBox1.Text.Trim() + "'", Connection);

            cmd.ExecuteNonQuery();
            MessageBox.Show("ACCOUNT DELETED!!");
            Connection.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Aswini\Documents\DB_Server1.mdf;Integrated Security = True; Connect Timeout = 30");


            Connection.Open();

            SqlCommand cmd = new SqlCommand("update [MyTable] set name ='" + textBox5.Text.Trim() + "' where name ='"+textBox1.Text.Trim()+"'", Connection);

            cmd.ExecuteNonQuery();
            MessageBox.Show(" DETAILS UPDATED!!");
            Connection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [MyTable] where name= '" + textBox4.Text + "'";
            connection.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
