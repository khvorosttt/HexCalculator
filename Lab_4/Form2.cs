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
    public partial class Form2 : Form
    {
        Vector vector;
        string[] numbers;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "";
                label4.Text = vector[int.Parse(textBox3.Text)].ToString();
            }
            catch (Exception)
            {
                label4.Text = "ОШИБКА";
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                char[] separator = { ' ' };
                numbers = textBox1.Text.ToUpper().Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int count = 10 <= numbers.Length ? 10 : numbers.Length;
                vector = new Vector(count);
                In();
                textBox1.Text = "";

            }
            else
            {
                vector = null;
                label7.Text = "ОШИБКА";
            }
        }
        public void In()
        {
            label7.Text = "[";
            for (int i = 0; i < vector.Length() - 1; i++)
            {
                vector[i] = new Hex(numbers[i]);
                label7.Text = String.Concat(label7.Text, numbers[i], "; ");
            }
            vector[vector.Length() - 1] = new Hex(numbers[vector.Length() - 1]);
            label7.Text = String.Concat(label7.Text, numbers[vector.Length() - 1], "] ");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label7.Text = "";
            label4.Text = "";
            vector = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Text = "";
                // string temp = vector[int.Parse(textBox2.Text)].ToString();
                vector[int.Parse(textBox2.Text)] = new Hex(textBox4.Text);
                numbers[int.Parse(textBox2.Text)] = textBox4.Text;
                //label7.Text=label7.Text.Replace(temp, vector[int.Parse(textBox2.Text)].ToString());
                In();
            }
            catch (Exception)
            {
                label8.Text = "ОШИБКА";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
