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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
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

        private void student_Load(object sender, EventArgs e)
        {

            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Int64 ID = Int64.Parse(textBox1.Text);
            String S_name = textBox2.Text;
            String F_name = textBox3.Text;
            String M_name = textBox4.Text;
            String A_dd = textBox5.Text;
            String M_num = textBox6.Text;
            String R_num = comboBox2.Text;
            String S_status = comboBox1.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Insert into Student (ID,SName,Fname,MName,Addr, Mbl,Roomn,Sstatus)values("+ID+",'" + S_name + "','" + F_name + "','"+M_name+ "','" + A_dd + "','"+M_num+ "','"+ R_num + "','"+S_status+"')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 ID = Int64.Parse(textBox1.Text);
            String R_num = comboBox2.Text;
            String S_status = comboBox1.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Update Student Set Roomn ='" + R_num + "' where ID=" + ID + " ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cmd.CommandText = "Update Student Set Sstatus ='" + S_status + "' where ID=" + ID + " ";

            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            MessageBox.Show("Data Saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
