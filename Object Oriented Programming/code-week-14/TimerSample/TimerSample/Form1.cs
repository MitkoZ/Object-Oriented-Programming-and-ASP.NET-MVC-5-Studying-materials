using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Location.X > this.Width)
            {
                button1.Location = new Point(0, button1.Location.Y);
            }
            else
            {
                button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Tag == null)
            {
                timer1.Start();
                timer1.Tag = true;
            }
            else
            {
                timer1.Stop();
                timer1.Tag = null;
            }
        }
    }
}
