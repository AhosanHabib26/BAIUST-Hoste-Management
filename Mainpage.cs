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
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void ROOMS_Click(object sender, EventArgs e)
        {
            Rooms Myroom = new Rooms();
            Myroom.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student Mystudent = new student();
            Mystudent.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            employe Myemploye = new employe();
            Myemploye.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fees Myfees = new fees();
            Myfees.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Salary Mysalary = new Salary();
            Mysalary.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
