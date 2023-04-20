using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5_8_Stokley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonToss_Click(object sender, EventArgs e)
        {
            int sideUp;
            Random rand = new Random();
            sideUp = rand.Next(2);
            if (sideUp == 0)
            {
                pictureBoxTails.Visible = true;
                pictureBoxHead.Visible = false;

            }
            else
            {
                pictureBoxTails.Visible = false;
                pictureBoxHead.Visible = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
