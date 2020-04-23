using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ElbarProject
{
    class HebrewTextBox:TextBox 
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar>= 'א'&&e.KeyChar<='ת' || (e.KeyChar == '\b')||(e.KeyChar==' '))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
