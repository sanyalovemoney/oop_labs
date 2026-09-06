using System.Drawing;

namespace Lab3.Shapes
{
    public class PointShape : Shape
    {
        public PointShape(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2) { }
        public override void Draw(Graphics g, Pen pen, Brush brush) => g.FillRectangle(brush, X1, Y1, 2, 2);
    }
}
