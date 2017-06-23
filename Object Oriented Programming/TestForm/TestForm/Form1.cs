using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public List<IDrawable> items { get; set; }
        public Form1()
        {
            this.items = new List<IDrawable>();
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.DarkCyan);
            foreach (Square item in this.items)
            {
                g.DrawRectangle(p, item.x, item.y, item.a, item.a);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            
            foreach (IDrawable item in this.items)
            {
                item.Draw(g);   
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (IDrawable item in this.items)
                {
                    if (item is IClicable && ((IClicable)item).Contains(e.X,e.Y))
                    {
                        MessageBox.Show("Това е клик върху квадратченценце!!!");
                        return;
                    }
                }
                items.Add(new TestForm.Square(e.X, e.Y, 100));
            } else
            {
                //foreach (IDrawable item in this.items)
                for (int i = 0; i<items.Count; i++)
                {
                    if (items[i] is IClicable && ((IClicable)items[i]).Contains(e.X, e.Y))
                    {
                        items.RemoveAt(i);
                        this.Refresh();
                        return;
                    }
                }
                items.Add(new Circle(e.X, e.Y, 100));
            }
            this.Refresh();
        }
    }
}
