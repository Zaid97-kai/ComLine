using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Polygon : Figure
    {
        public PointF[] pointFs;
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap1);
            g.DrawPolygon(Init.pen1, pointFs);
            Init.pictureBox1.Image = Init.bitmap1;
        }

        public override void MoveTo(int x, int y) 
        {
            this.x += x;
            this.y += y;

            this.DeleteF(this, false);
            this.Draw();
        }
    }
}
