using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatore
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        string c;
        double x;

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (txtcalc.Text == "0")
                txtcalc.Clear();
            txtcalc.Text = txtcalc.Text + b.Text;
            if (txtcalc.Text == "." && b.Text == ".")
                txtcalc.Text = "0.";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtcalc.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            if (txtcalc.Text != "" && label1.Text != "")
                button17.PerformClick();
            c = b.Text;
            x = Convert.ToDouble(txtcalc.Text);
            label1.Text = txtcalc.Text + " " + c;
            txtcalc.Clear();
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(txtcalc.Text);
                        txtcalc.Text = (x + y).ToString();
                        label1.Text = "";

                    }
                    break;

                case "-":
                    {
                        double y = Convert.ToDouble(txtcalc.Text);
                        txtcalc.Text = (x - y).ToString();
                        label1.Text = "";

                    }
                    break;

                case "*":
                    {
                        double y = Convert.ToDouble(txtcalc.Text);
                        txtcalc.Text = (x * y).ToString();
                        label1.Text = "";

                    }
                    break;

                case "/":
                    {
                        double y = Convert.ToDouble(txtcalc.Text);
                        txtcalc.Text = (x/ y).ToString();
                        label1.Text = "";

                    }
                    break;
            }
        }

        private void txtcalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    {
                        e.Handled = true;
                        button16.PerformClick();

                    }break;
                case '-':
                    {
                        e.Handled = true;
                        button15.PerformClick();

                    }
                    break;
                case '*':
                    {
                        e.Handled = true;
                        button14.PerformClick();

                    }
                    break;
                case '/':
                    {
                        e.Handled = true;
                        button13.PerformClick();

                    }
                    break;
                case(char)Keys.Enter:
                    {
                        //e.Handled = true;
                        button17.PerformClick();
                    }break;
                case(char)Keys.Back:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("الرجاء ادخل ارقام فقط");
                    break;
            }
        }
    }
}
