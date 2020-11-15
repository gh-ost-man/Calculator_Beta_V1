using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalaizerClassLib;
using CalcLibrary;

namespace Calculcator
{
    public partial class Calculator : Form
    {
        double memoryValue = 0;
        char symb;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "1";
        }

        private void button_Backspace_Click(object sender, EventArgs e)
        {
            if (textBox_Expression.Text.Length == 0) return;
            textBox_Expression.Text = textBox_Expression.Text.Remove((textBox_Expression.Text.Length - 1), 1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "9";
        }

        private void button1_Editing_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "(";
        }

        private void button2_Editing_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + ")";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            textBox_Expression.Clear();
        }

        private void button_Zero_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "0";
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "/";
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "*";
        }

        private void button_diff_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "-";
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text = textBox_Expression.Text + "+";
        }

        private void button_total_Click(object sender, EventArgs e)
        {
            try
            {
                double res = 0;

                res = Analaizer.Calculate(textBox_Expression.Text);

                textBox_Result.Text = res.ToString();
                textBox_Expression.Text = string.Empty;
            }
            catch (Exception ex) { textBox_Result.Text = ex.Message; }
        }

        private void button_Mod_Click(object sender, EventArgs e)
        {
            if (textBox_Expression.Text == string.Empty || textBox_Result.Text == string.Empty) return;

            string symb = "()/*-+";

            for (int i = 0; i < textBox_Expression.Text.Length; i++)
                if (symb.IndexOf(textBox_Expression.Text[i]) != -1) return;


            double n1 = Convert.ToDouble(textBox_Result.Text);
            double n2 = Convert.ToDouble(textBox_Expression.Text);

            textBox_Result.Text = Calc.Mod(n1, n2).ToString();
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text.Length == 0) return;

            string pattern = @"[a-z]";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(textBox_Result.Text))
            {
                MessageBox.Show("Неможливо перетворити до числа");
                return;
            }
            else memoryValue += Convert.ToDouble(textBox_Result.Text);
        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
        }

        private void button_MR_Click(object sender, EventArgs e)
        {
            textBox_Expression.Text += memoryValue.ToString();
        }

        private void button_sum_and_diff_Click(object sender, EventArgs e)
        {
            if (textBox_Expression.Text.Length == 0) return;
            symb = textBox_Expression.Text[textBox_Expression.Text.Length - 1];

            if (Char.IsDigit(symb)) textBox_Expression.Text += "-";
            else if (symb == '-')
            {
                textBox_Expression.Text = textBox_Expression.Text.Remove(textBox_Expression.Text.Length - 1, 1);
                textBox_Expression.Text += "+";
            }
            else if (symb == '+')
            {
                textBox_Expression.Text = textBox_Expression.Text.Remove(textBox_Expression.Text.Length - 1, 1);
                textBox_Expression.Text += "-";
            }
        }
    }
}
