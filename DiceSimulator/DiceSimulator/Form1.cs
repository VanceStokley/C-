using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int num = rd.Next(7);
            switch (num) 
            {
                case 1 :
                    dice1.Visible = true;
                    dice2.Visible = false;
                    dice3.Visible = false;
                    Dice4.Visible = false;
                    dice5.Visible = false;
                    dice6.Visible = false;
                    break;
                case 2:
                    dice2.Visible = true;
                    dice1.Visible = false;
                    dice3.Visible = false;
                    Dice4.Visible = false;
                    dice5.Visible = false;
                    dice6.Visible = false;
                    break;
                case 3:
                    dice3.Visible = true;
                    dice2.Visible = false;
                    dice1.Visible = false;
                    Dice4.Visible = false;
                    dice5.Visible = false;
                    dice6.Visible = false;
                    break;
                case 4:
                    Dice4.Visible = true;
                    dice2.Visible = false;
                    dice1.Visible = false;
                    dice3.Visible = false;
                    dice5.Visible = false;
                    dice6.Visible = false;
                    break;
                case 5:
                    dice5.Visible = true;
                    dice2.Visible = false;
                    dice1.Visible = false;
                    dice3.Visible = false;
                    Dice4.Visible = false;
                    dice6.Visible = false;
                    break;
                case 6:
                    dice6.Visible = true;
                    dice2.Visible = false;
                    dice1.Visible = false;
                    dice3.Visible = false;
                    Dice4.Visible = false;
                    dice5.Visible = false;
                    break;
                
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dice6_Click(object sender, EventArgs e)
        {

        }
    }
}
