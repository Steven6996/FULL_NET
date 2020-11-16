using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_APP
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string c;

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }



        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "/";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "*";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "-";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (this.txtpantalla.Text.Contains('.') == false)
            {
                this.txtpantalla.Text = this.txtpantalla.Text + ".";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "%";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.txtpantalla.Text);
            switch (c)
            {
                case "+":
                    this.textR.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.textR.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.textR.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.textR.Text = Convert.ToString(b / a);
                    break;
                case "&":
                    this.textR.Text = Convert.ToString(b % a);
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textR.Text = "";
            this.txtpantalla.Text = "";
        }

        private void txtpantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "+";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();


        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
