using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n1, n2, result;
        String op;
        private void button5_Click(object sender, EventArgs e)
        {
            op = "+";
            n1 = int.Parse(display.Text);
            display.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            op = "-";
            n1 = int.Parse(display.Text);
            display.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            op = "/";
            n1 = int.Parse(display.Text);
            display.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            op = "*";
            n1 = int.Parse(display.Text);
            display.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n2 = int.Parse(display.Text);
            
            if (op == "+")
            {
                result = n1 + n2;
                display.Text = n1 + " + " + n2 + " = " + result;
            }
            
            
            else if(op == "-")
            {
                result = n1 - n2;
                display.Text = n1 + " - " + n2 + " = " + result;
            }
            else if(op == "/")
            {
                result = n1 / n2;
                display.Text = n1 + "/" + n2 + " = " + result;
            }
            else if( op == "*")
            {
                result = n1 * n2;
                display.Text = n1 + "*" + n2 + " = " + result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            display.Text = display.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button3.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button7.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button11.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + button17.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = display.Text + button1.Text;

        }
    }
}
