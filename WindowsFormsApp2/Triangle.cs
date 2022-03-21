using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Triangle : Polygon
    {
        public Triangle(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            this.pointFs = new PointF[3];
            this.pointFs[0].X = x1;
            this.pointFs[0].Y = y1;
            this.pointFs[1].X = x2;
            this.pointFs[1].Y = y2;
            this.pointFs[2].X = x3;
            this.pointFs[2].Y = y3;
            this.x = Convert.ToInt32(pointFs[0].X);
            this.y = Convert.ToInt32(pointFs[0].Y);
        }
        public Triangle()
        {

        }
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(Init.bitmap1))
            {
                g.DrawPolygon(Init.pen1, this.pointFs);
            }
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
