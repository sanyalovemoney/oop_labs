using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lab3.Shapes;

namespace Lab3
{
    public class MainWindow : Form
    {
        private enum ShapeType { Point, Line, Rectangle, Ellipse }
        private ShapeType _currentType = ShapeType.Line;
        private List<Shape> _shapes = new List<Shape>();

        private Point _startPoint;
        private Point _currentPoint;
        private bool _isDrawing = false;

        private MenuStrip? _menuStrip;
        private ToolStrip? _toolStrip;

        public MainWindow()
        {
            this.Text = "Graphic Object Editor - Lab 3";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;
        }
    }
}