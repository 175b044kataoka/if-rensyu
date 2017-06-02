using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_rensyu
{
    public partial class Form1 : Form
    {
        int vx = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += vx;
            button1.Top += vx;
            if (button1.Left <= 0)
            {
                vx += 40;
            }
            else if(button1.Left >= 823)
            {
                vx -= 40;
            }
           else if (button1.Top <= 0)
           {
               vx -= 40;
           }
            else if (button1.Top >= 413)
            {
                vx += 40;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
        }
    }
}
