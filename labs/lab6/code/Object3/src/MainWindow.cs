using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6.Object3;

public class Object3Form : Form
{
    public Object3Form()
    {
        Text = "Object 3 - Graph y=f(x) (.NET 8 Refactored)";
        Size = new Size(640, 530);
        StartPosition = FormStartPosition.Manual;
        Location = new Point(880, 40);
        DoubleBuffered = true;
    }
}