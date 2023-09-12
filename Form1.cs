using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoste_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            fees Myfees = new fees ();
            Myfees.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employe Myemploye = new employe();
            Myemploye.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ROOMS_Click(object sender, EventArgs e)
        {
            Rooms Myroom = new Rooms();
            Myroom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student Mystudent = new student();
            Mystudent.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Salary Mysalary = new Salary();
            Mysalary.Show();
            this.Hide();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          if((textBox1.Text.Equals("1111026")) && (textBox2.Text.Equals("abcd")))
            {
                Form f2 = new Mainpage();
                f2.Show();
               // MessageBox.Show("Login Successful");
            }
          else
            {
                MessageBox.Show("LoginID or Password is not correct");
                    }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
