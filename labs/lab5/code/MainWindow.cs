using System.Drawing;
using System.Windows.Forms;

namespace Lab5;

public class MainWindow : Form
{
    public MainWindow()
    {
        Text = "Graphic Object Editor - Lab 5 (.NET 8 Refactored)";
        Size = new Size(800, 600);
        DoubleBuffered = true;
    }
}