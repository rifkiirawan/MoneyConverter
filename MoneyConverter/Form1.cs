using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "IDR" && comboBox2.SelectedItem == "JPY")
            {
                label5.Text = "JPY :";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label6.Text = "Insert a number.";
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    double val = double.Parse(textBox3.Text);
                    val = val * 0.0076;

                    label6.Text = val.ToString();
                    label6.ForeColor = Color.Black;
                }
            }
            else if (comboBox1.SelectedItem == "IDR" && comboBox2.SelectedItem == "USD") //idr-usd
            {
                label5.Text = "USD :";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label6.Text = "Insert a number.";
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    double val = double.Parse(textBox3.Text);
                    val = val * 0.00007;

                    label6.Text = val.ToString();
                    label6.ForeColor = Color.Black;
                }
            }
            else if (comboBox1.SelectedItem == "JPY" && comboBox2.SelectedItem == "IDR") //jpy-idr
            {
                label5.Text = "IDR :";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label6.Text = "Insert a number.";
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    double val = double.Parse(textBox3.Text);
                    val = val * 131.81;

                    label6.Text = val.ToString();
                    label6.ForeColor = Color.Black;
                }
            }
            else if (comboBox1.SelectedItem == "JPY" && comboBox2.SelectedItem == "USD") //jpy-usd
            {
                label5.Text = "USD :";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label6.Text = "Insert a number.";
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    double val = double.Parse(textBox3.Text);
                    val = val * 0.0092;

                    label6.Text = val.ToString();
                    label6.ForeColor = Color.Black;
                }
            }
            else if (comboBox1.SelectedItem == "USD" && comboBox2.SelectedItem == "IDR") //usd-idr
            {
                label5.Text = "IDR :";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label6.Text = "Insert a number.";
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    double val = double.Parse(textBox3.Text);
                    val = val * 14372.25;

                    label6.Text = val.ToString();
                    label6.ForeColor = Color.Black;
                }
            }
            else if (comboBox1.SelectedItem == "USD" && comboBox2.SelectedItem == "JPY") //usd-jpy
            {
                label5.Text = "JPY :";

                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    label6.Text = "Insert a number.";
                    label6.ForeColor = Color.Red;
                }
                else
                {
                    double val = double.Parse(textBox3.Text);
                    val = val * 108.92;

                    label6.Text = val.ToString();
                    label6.ForeColor = Color.Black;
                }
            }
            else
            {
                label5.Text = "";
                label6.Text = "Choose the currency";
                label6.ForeColor = Color.Red;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
