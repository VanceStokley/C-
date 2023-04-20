using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtoF_Stokley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void buttonCakculate_Click(object sender, EventArgs e)
        {
            int c = 1;
            int f;
            while (c <= 20)
            {
                f = (c * (9 / 5)) + 32;
                
                listBox1.Items.Add(c+" degrees Celsius is "+f +" degrees Fahrenheit");
                c++;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
