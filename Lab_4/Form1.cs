using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCalculator
{
    public partial class Form1 : Form
    {
        Hex h1, h2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button_add_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void Button_diff_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void Button_mult_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Button_div_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (label1.Text)
                {
                    case "+":
                        h1 = new Hex(textBox1.Text);
                        h2 = new Hex(textBox2.Text);
                        result = h1 + h2;
                        label1.Text = result.ToString();
                        break;
                    case "-":
                        h1 = new Hex(textBox1.Text);
                        h2 = new Hex(textBox2.Text);
                        result = h1 - h2;
                        label1.Text = result.ToString();
                        break;
                    case "*":
                        h1 = new Hex(textBox1.Text);
                        h2 = new Hex(textBox2.Text);
                        result = h1 * h2;
                        label1.Text = result.ToString();
                        break;
                    case "/":
                        h1 = new Hex(textBox1.Text);
                        h2 = new Hex(textBox2.Text);
                        result = h1 / h2;
                        label1.Text = result.ToString();
                        break;
                    default:
                        label1.Text = "ОШИБКА";
                        break;

                }
            }
            catch (Exception)
            {
                label1.Text = "ОШИБКА";
            }
        }
    }
}
