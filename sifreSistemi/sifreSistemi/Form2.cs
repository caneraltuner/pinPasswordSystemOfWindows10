using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sifreSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = Form1.textLenght;
            label1.Text = "Password: "+Form1.password;
            label2.Text = "Current TextBox's TextLenght: "+Form1.textLenght.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.password && textBox1.TextLength == Form1.textLenght)
            {
                MessageBox.Show("Access Granted");
            }
            else if (textBox1.Text != Form1.password && textBox1.TextLength == Form1.textLenght)
            {
                MessageBox.Show("Access Denied");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
