using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            labelKey.Text = e.KeyData.ToString();
            e.SuppressKeyPress = true;
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            labelKey.Text = @"nothing";
            e.SuppressKeyPress = true;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            labelKey.Text = e.Button.ToString();
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            labelKey.Text = @"nothing" ;
        }
    }
}
