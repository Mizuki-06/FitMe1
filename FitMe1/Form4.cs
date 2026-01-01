using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMe1
{
    public partial class Form4 : Form
    {
        Form1 login = new Form1();
        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            this.Close();
            login.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            home.Visible = true;
            workouts.Visible = false;
            meal.Visible = false;
            progress.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            home.Visible = false;
            workouts.Visible = true;
            meal.Visible = false;
            progress.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            home.Visible = false;
            workouts.Visible = false;
            meal.Visible = true;
            progress.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            home.Visible = false;
            workouts.Visible = false;
            meal.Visible = false;
            progress.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            this.Close();
            login.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            this.Close();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            this.Close();
            login.Show();
        }
    }
}
