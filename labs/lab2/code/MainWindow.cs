using System.Drawing;
using System.Windows.Forms;

namespace Lab2
{
    public class MainWindow : Form
    {
        public MainWindow()
        {
            this.Text = "Graphic Object Editor - Lab 2";
            this.Size = new Size(800, 600);
            this.DoubleBuffered = true;
        }
    }
}