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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void fees_Load(object sender, EventArgs e)
        {
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Select * from Fees";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainpage Home = new Mainpage();
            Home.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Int64 ID = Int64.Parse(textBox2.Text);
            String Taka = comboBox2.Text;
            String SName = textBox1.Text;
            String RS = comboBox1.Text;
            String Mon = dateTimePicker1.Text;
            String Amo = textBox3.Text;
            
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Insert into Fees (ID,Taka,SName,RS,Mon,Amo)values(" + ID + ",'" + Taka + "','" + SName + "','" + RS + "','" + Mon+ "','" + Amo + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 ID = Int64.Parse(textBox2.Text);
            String Taka = comboBox2.Text;
            String RS = comboBox1.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Update Fees Set Taka ='" + Taka + "' where ID=" + ID + " ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd.CommandText = "Update Fees Set RS ='" + RS+ "' where ID=" + ID + " ";

            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            MessageBox.Show("Data Saved");
        }
    }
}
