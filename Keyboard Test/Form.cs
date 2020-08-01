using System.Diagnostics;
using System.Windows.Forms;

namespace Keyboard_Test
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            labelKey.Text = e.KeyCode.ToString();
            e.SuppressKeyPress = true;
            e.Handled = true;
            labelCtrl.Text = e.Control ? "Control" : "";
            labelAlt.Text = e.Alt ? "Alt" : "";
            labelShift.Text = e.Shift ? "Shift" : "";
            listBox.Items.Add($"▼ [{(e.Control ? "C" : "") }{(e.Alt ? "A" : "") }{(e.Shift ? "S" : "") }] {e.KeyCode}");
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            labelKey.Text = "";
            labelCtrl.Text = "";
            labelAlt.Text = "";
            labelShift.Text = "";
            e.SuppressKeyPress = true;
            e.Handled = true;
            listBox.Items.Add($"▲ [{(e.Control ? "C" : "") }{(e.Alt ? "A" : "") }{(e.Shift ? "S" : "") }] {e.KeyCode}");
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            labelKey.Text = e.Button.ToString();
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            labelKey.Text = "";
        }
    }
}
