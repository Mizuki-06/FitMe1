using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitMe1
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            create.Enabled = false;
            signinp.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                create.Enabled = true;
                create.BackColor = Color.FromArgb(93, 41, 106);
            }
            else
            {
                create.Enabled = false;
                create.BackColor = Color.FromArgb(108, 48, 130);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text) || //check for empty fields in registration
            string.IsNullOrEmpty(textBox4.Text) ||
            string.IsNullOrEmpty(textBox3.Text))
            {
                create.Enabled = false;
                create.BackColor = Color.FromArgb(108, 48, 130);
                MessageBox.Show("Please enter the correct username and password.");
                return;
            }
            else
            {
                create.Enabled = true;
                create.BackColor = Color.FromArgb(93, 41, 106);
            }

            MessageBox.Show("You have successfully registered!");
            registrationp.Visible = false;
            signinp.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox6.Text ||
                textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Please enter the correct information!");
                return;
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signinp.Visible = true;
            registrationp.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signinp.Visible = false;
            registrationp.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
