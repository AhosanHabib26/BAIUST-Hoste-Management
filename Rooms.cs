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

namespace Hoste_Management
{
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mainpage Home = new Mainpage();
            Home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 Roomno = Int64.Parse( roomno.Text);
            String Status = status.Text;
            String Booked = boocked.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "insert into room (Roomnum,RoomsStatus,bocked)values("+ Roomno + ",'"+ Status + "','"+ Booked + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Select * from room";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 Roomno = Int64.Parse(roomno.Text);
            String Status = status.Text;
            String Booked = boocked.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Update room Set RoomsStatus ='"+ status.Text + "' where Roomnum="+ roomno.Text + " ";
                
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int64 Roomno = Int64.Parse(roomno.Text);
            String Status = status.Text;
            String Booked = boocked.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "delete from room where  Roomnum =" + Roomno + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
