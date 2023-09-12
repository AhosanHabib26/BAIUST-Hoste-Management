using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hoste_Management
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Select * from Salary";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Mainpage Home = new Mainpage();
            Home.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Int64 ID = Int64.Parse(textBox2.Text);
            Int64 EID = Int64.Parse(comboBox2.Text);
            String EN = textBox1.Text;
            String Pos = textBox3.Text;
            String Mon = dateTimePicker1.Text;
            String Amo = textBox4.Text;
            
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Insert into Salary (ID,EID,EN,Pos,Mon, Amo)values(" + ID + "," + EID + ",'" + EN + "','" + Pos + "','" + Mon + "','" + Amo + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 ID = Int64.Parse(textBox2.Text);
            String Amo = textBox4.Text;

            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Update Salary Set Amo ='" + Amo + "' where ID=" + ID + " ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }
    }
}
