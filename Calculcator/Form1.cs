using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculcator
{
    public partial class Calculator : Form
    {
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
    }
}
