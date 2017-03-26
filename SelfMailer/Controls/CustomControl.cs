using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfMailer.Controls
{
   public  class CustomControl : System.Windows.Forms.Control
    {
            protected override void OnPaint(PaintEventArgs e)
            {
            Rectangle R = new Rectangle(0,0, Size.Width, Size.Height);
            e.Graphics.FillRectangle(Brushes.Green, R);
            }
        
    }
}
