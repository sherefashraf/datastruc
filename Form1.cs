using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            button1.Focus();
            if (textBox1.Text == "user" && textBox2.Text == "1234")
            {
                this.Hide();
                Form2 a = new Form2();
                a.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("write E_mail and password in correct ");
            }
            else
            {
                MessageBox.Show("write E_mail and password in correct ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
