using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphDesigner
{
    public partial class MainWindow : Form
    {
        private readonly List<Node> nodes;
        private readonly List<Line> lines;
        private Node selection;
        private bool moving;
        private bool drawingLines;
        private Point currentMousePos;
        private int BaseNodeWidth = Settings.NodeWidth;
        private Color BaseNodeColour = Settings.NodeColour;

        public MainWindow()
        {
            InitializeComponent();
            nodes = new List<Node>();
            lines = new List<Line>();
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            selection = Selected(e.Location);

            if (moveModeToolStripButton.Checked)
            {
                moving = selection != null;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (selection == null)
                    {
                        nodes.Add(new Node() { Location = e.Location });
                        nodes[nodes.Count - 1].Width = BaseNodeWidth;
                        nodes[nodes.Count - 1].Colour = BaseNodeColour;
                        Refresh();
                    }
                    else
                    {
                        drawingLines = true;
                        currentMousePos = e.Location;
                    }
                } 
                else if (e.Button == MouseButtons.Right)

                {
                    if (selection != null)
                    {
                        NodeSettings settings = new NodeSettings(selection.Colour, selection.Width);
                        if (settings.ShowDialog() == DialogResult.OK)
                        {
                            selection.Colour = settings.Colour;
                            selection.Width = settings.Width;
                            selection = null;
                            Refresh();
                        }
                    }
                }
               
            }
        }

        private Node Selected(Point p)
        {
            Node res = null;
            int i = 0;
            while (res == null && i < nodes.Count)
            {
                if (nodes[i].Contains(p))
                {
                    res = nodes[i];
                }
                i++;
            }
            return res;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            if (drawingLines)
            {
                Node end = Selected(e.Location);
                if (end != null && selection != null && !end.Equals(selection))
                {
                    lines.Add(new Line() { Start = selection, End = end });
                }
                drawingLines = false;
                Refresh();
            }
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && selection != null)
            {
                selection.Move(e.Location);
                Refresh();
            }
            else if (drawingLines)
            {
                currentMousePos = e.Location;
                Refresh();
            }
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            foreach (Line l in lines)
            {
                l.Draw(e.Graphics);
            }

            if (drawingLines && selection != null)
            {
                Pen dashPen = new Pen(Color.Black, 1);
                dashPen.DashStyle = DashStyle.Dash;
                e.Graphics.DrawLine(dashPen, selection.Centre, currentMousePos);
            }

            foreach (Node n in nodes)
            {
                n.Draw(e.Graphics, n == selection);
            }
        }

        private void growTSbutton_Click(object sender, EventArgs e)
        {
            BaseNodeWidth++;
        }

        private void shrinkTSButton_Click(object sender, EventArgs e)
        {
            BaseNodeWidth--;
        }

        private void eraseTSButton_Click(object sender, EventArgs e)
        {
            nodes.Clear();
            lines.Clear();
            Refresh();
        }

        private void colorTSButton_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog() { Color = BaseNodeColour };
            if (col.ShowDialog() == DialogResult.OK)
            {
                BaseNodeColour = col.Color;
            }
        }
    }
}