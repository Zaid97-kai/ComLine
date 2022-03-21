using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Car : Figure
    {
        public Rectagle r1;
        public Circle c1;
        public Circle c2;
        public Rectagle r2;
        public String str;

        public Car()
        {

        }
        public Car(int x, int y, int w, int h, string nameCar)
        {
            this.r1 = new Rectagle(x, y, w, h);
            this.c1 = new Circle(x, y + h, w / 5);
            this.c2 = new Circle((x + w) - w / 5, y + h, w / 5);
            this.r2 = new Rectagle(x, y, w, h + w/5);
            this.str = new String(this.r1.x + this.r1.w/2 - 25, this.r1.y + this.r1.h/2 - 25, nameCar);
        }

        public override void Draw()
        {
            this.r1.Draw();
            this.c1.Draw();
            this.c2.Draw();
            this.str.Draw();

            Init.pictureBox1.Image = Init.bitmap1;
        }
        public override void MoveTo(int x, int y)
        {
           if (!((this.r1.x + x < 0 && this.r1.y + y < 0) || (this.r1.y + y < 0) || (this.r1.x + x > Init.pictureBox1.Width && this.r1.y + y < 0) || (this.r2.x + this.r1.w + x > Init.pictureBox1.Width) || (this.r1.x + x > Init.pictureBox1.Width && this.r1.y + y > Init.pictureBox1.Height) || (this.r1.y + this.r2.h + y > Init.pictureBox1.Height) || (this.r1.x + x < 0 && this.r1.y+y > Init.pictureBox1.Height) || (this.r1.x + x < 0)))
            {
                    this.r1.x += x;
                    this.r1.y += y;

                    this.c1.x += x;
                    this.c1.y += y;

                    this.c2.x += x;
                    this.c2.y += y;

                    this.r2.x += x;
                    this.r2.y += y;

                    this.str.x += x;
                    this.str.y += y;

                this.DeleteF(this, false);
                this.Draw();
            }
        }
    }
}
