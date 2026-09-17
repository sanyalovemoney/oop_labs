using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab6.Manager;

public class ManagerForm : Form
{
    public ManagerForm()
    {
        Text = "Lab 6 - Manager (.NET 8 Refactored)";
        Size = new Size(360, 320);
        StartPosition = FormStartPosition.Manual;
        Location = new Point(30, 40);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
    }
}