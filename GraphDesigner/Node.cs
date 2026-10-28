using System;
using System.Drawing;

namespace GraphDesigner
{
    public class Node
    {
        public Point Location { get; set; }
        public Size Size { get; private set; } = new Size(20, 20);
        public Point Centre => new Point(Location.X + Size.Width / 2, Location.Y + Size.Height / 2);
        public string Text { get; set; } = "";
        public int Width { get; set; } = 2;
        public Color Colour { get; set; } = Color.MidnightBlue;

        public bool Contains(Point p) => new Rectangle(Location, Size).Contains(p);

        public void Draw(Graphics g, bool isSelected = false)
        {
            Rectangle r = new Rectangle(Location, Size);
            Color drawColor = isSelected ? Color.Red : Colour;
            Pen p = new Pen(drawColor, Width);

            g.DrawRectangle(p, r);

            if (!string.IsNullOrEmpty(Text))
            {
                Font font = new Font("Arial", 8);
                SolidBrush brush = new SolidBrush(Color.Black);
                g.DrawString(Text, font, brush, Location.X + 2, Location.Y + 2);
            }
        }

        public void Move(Point p)
        {
            Location = p;
        }
    }
}