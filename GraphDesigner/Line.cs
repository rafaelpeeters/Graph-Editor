using System;
using System.Drawing;

namespace GraphDesigner
{
    public class Line
    {
        public Node Start { get; set; }
        public Node End { get; set; }

        public void Draw(Graphics g)
        {
            if (Start == null || End == null) { return; }
            Pen p = Pens.Black;
            g.DrawLine(p, Start.Centre, End.Centre);
        }
    }
}