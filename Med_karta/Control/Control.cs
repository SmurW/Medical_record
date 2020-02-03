using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med_karta.Control
{
    class Control : System.Windows.Forms.Control
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(this.ForeColor, this.Width);
            e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
            base.OnPaint(e);
        }
    }
}
