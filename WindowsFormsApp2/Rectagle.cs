using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Rectagle : Figure
    {
        public Rectagle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public Rectagle()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap1);  
            g.DrawRectangle(Init.pen1, this.x, this.y, this.w, this.h);
            Init.pictureBox1.Image = Init.bitmap1;
        }
        public void Draw(Pen pen)
        {
            Graphics g = Graphics.FromImage(Init.bitmap1);
            g.DrawRectangle(pen, this.x, this.y, this.w, this.h);
            Init.pictureBox1.Image = Init.bitmap1;
        }

        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0) || (this.y + y < 0) || (this.x + x > Init.pictureBox1.Width && this.y + y < 0) || (this.x + this.w + x > Init.pictureBox1.Width) || (this.x + x > Init.pictureBox1.Width && this.y + y > Init.pictureBox1.Height) || (this.y + this.h + y > Init.pictureBox1.Height) || (this.x + x < 0 && this.y + y > Init.pictureBox1.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;

                this.DeleteF(this, false);
                this.Draw();
            }
        }
    }
}
