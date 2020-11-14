using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalaizerClassLib;

namespace Calculcator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_total_Click(object sender, EventArgs e)
        {
            try
            {
                double res = 0;

                res = Analaizer.Calculate(textBox_Expression.Text);

                textBox_Result.Text = res.ToString();
            }
            catch (Exception ex) { textBox_Result.Text = ex.Message; }
        }
    }
}
