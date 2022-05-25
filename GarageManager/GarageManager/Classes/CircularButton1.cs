using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager.Classes
{
     public class CircularButton1 : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath  graphicsPath = new GraphicsPath();    
            graphicsPath.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(pevent);
        }
    }
}
