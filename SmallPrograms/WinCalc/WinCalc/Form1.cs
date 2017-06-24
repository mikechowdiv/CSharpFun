using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class Form1 : Form
    {
        double value = 0;
        String operation = "";
        bool operation_press = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_press))
                result.Clear();

            operation_press = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_press = true;
            equation.Text = value + " " + operation;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
