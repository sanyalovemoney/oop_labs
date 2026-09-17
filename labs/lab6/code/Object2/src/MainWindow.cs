using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6.Object2;

public class Object2Form : Form
{
    public Object2Form()
    {
        Text = "Object 2 - Data Gen (.NET 8 Refactored)";
        Size = new Size(460, 380);
        StartPosition = FormStartPosition.Manual;
        Location = new Point(410, 40);
        DoubleBuffered = true;
    }
}