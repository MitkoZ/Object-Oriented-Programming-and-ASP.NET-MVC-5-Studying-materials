using System.Drawing;

namespace TestForm
{
    public class Square : IClicable, IDrawable
    {
        public int a { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }

        public Square (int x, int y, int a)
        {
            this.x = x;
            this.y = y;
            this.a = a;
        }

        public bool Contains(int x, int y)
        {
            if (x > this.x - this.a/2 && y > this.y - this.a/2 && x < this.x + this.a/2 && y < this.y + this.a/2)
            {
                return true;
            }
            return false;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.DarkCyan);
            g.DrawRectangle(p, this.x - this.a/2, this.y - this.a/2, this.a, this.a);
        }
    }
}
