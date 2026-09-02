using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public class Module2Form : Form
    {
        private TextBox txtInput;
        private Button btnOk;
        private Button btnCancel;

        public string Result { get; private set; } = "";

        public Module2Form()
        {
            this.Text = "Робота 2 - Введення тексту";
            this.Size = new Size(250, 150);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lbl = new Label
            {
                Text = "Введіть текст:",
                Location = new Point(10, 10),
                AutoSize = true
            };

            txtInput = new TextBox
            {
                Location = new Point(10, 30),
                Size = new Size(210, 20)
            };

            btnOk = new Button
            {
                Text = "Так",
                Location = new Point(50, 70),
                DialogResult = DialogResult.OK
            };

            btnCancel = new Button
            {
                Text = "Відміна",
                Location = new Point(120, 70),
                DialogResult = DialogResult.Cancel
            };

            btnOk.Click += (s, e) =>
            {
                Result = txtInput.Text;
                this.Close();
            };

            this.Controls.Add(lbl);
            this.Controls.Add(txtInput);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnCancel);
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
        }
    }
}