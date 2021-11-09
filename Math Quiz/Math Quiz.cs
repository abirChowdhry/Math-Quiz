using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(textBox1.Text) == false)
                    MessageBox.Show(textBox1.Text + " Tumse Na Ho Payega!!!!!", "Result");

                else if (string.IsNullOrEmpty(textBox1.Text) == true)
                    MessageBox.Show("**You Must Have To Enter Your Name**", "Couldn't Submit");
           
        }
    }
}
