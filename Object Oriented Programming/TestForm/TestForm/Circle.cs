using System.Drawing;

namespace TestForm
{
    class Circle : IDrawable
    {
        public int r { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }

        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.DarkCyan);
            g.DrawEllipse(p, this.x - r/2, this.y - r/2, this.r, this.r);
        }
    }
}
