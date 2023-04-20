using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP1_3Stokley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(MPGTextBox.Text);
            double five = speed * 5;
            double eight = speed * 8;
            double twelve = speed * 12;

            string sfive = five.ToString("");
            string seight = eight.ToString("");
            string stwelve = twelve.ToString("");

            label5Hour.Text = "" + sfive;
            label8Hour.Text = "" + seight;
            label12Hour.Text = "" + stwelve;
        }

        private void MPGTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
