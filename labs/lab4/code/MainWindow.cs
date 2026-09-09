using System;
using System.Drawing;
using System.Windows.Forms;
using Lab4.Shapes;

namespace Lab4;

public class MainWindow : Form
{
    private enum ShapeType { Point, Line, Rectangle, Ellipse, LineCircles, Cube }
    private ShapeType _currentType = ShapeType.Line;
    private readonly MyEditor _editor = new();

    private Point _startPoint;
    private Point _currentPoint;
    private bool _isDrawing;

    private MenuStrip? _menuStrip;
    private ToolStrip? _toolStrip;

    public MainWindow()
    {
        Text = "Graphic Object Editor - Lab 4 (.NET 8 Refactored)";
        Size = new Size(800, 600);
        DoubleBuffered = true;
    }
}