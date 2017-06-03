using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int randomNum = rng.Next(1, Convert.ToInt32(textBox1.Text) + 1);
            Number.Text = Convert.ToString(randomNum);
        }
    }
}
