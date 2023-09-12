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
    public partial class employe : Form
    {
        public employe()
        {
            InitializeComponent();
        }

        private void employe_Load(object sender, EventArgs e)
        {
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Select * from Employe ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {   
            Int64 ID = Int64.Parse(textBox2.Text);
            String E_name = textBox1.Text;
            String A_dd = textBox3.Text;
            String M_num = textBox4.Text;
            String position = comboBox2.Text;
            String E_status = comboBox1.Text;
            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Insert into Employe (ID,EName,Addr, Mbl,Position,Estatus)values("+ID+",'" + E_name + "','" + A_dd + "','" + M_num + "','" + position + "','" + E_status + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String Status = comboBox1.Text;
            Int64 ID = Int64.Parse(textBox2.Text);

            SqlConnection cnnn = new SqlConnection();
            cnnn.ConnectionString = "data source = SAKIB\\SQLEXPRESS; database = BHMS ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnnn;

            cmd.CommandText = "Update Employe Set Position  ='" + comboBox1.Text + "' where ID=" + textBox2.Text + " ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved");
        }
    }
}
