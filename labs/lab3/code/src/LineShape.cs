using System.Drawing;

namespace Lab3.Shapes
{
    public class LineShape : Shape
    {
        public LineShape(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }
        public override void Draw(Graphics g, Pen pen, Brush brush) => g.DrawLine(pen, X1, Y1, X2, Y2);
    }
}
