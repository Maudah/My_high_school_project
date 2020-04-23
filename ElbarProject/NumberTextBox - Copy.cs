using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ElbarProject
{
    class NumberAndPointTextBox:TextBox 
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (char.IsNumber(e.KeyChar) ||(e.KeyChar == '\b')|| (e.KeyChar == '.'))
                e.Handled = false;
            else
                e.Handled = true;
            
        }
        
    }
}
