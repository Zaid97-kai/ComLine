using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Point : Figure
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(Init.bitmap1))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                g.Clear(Color.White);
                g.DrawEllipse(Init.pen1, this.x, this.y, 1, 1);
            }
            /// Назначаем наш Bitmap свойству Image
            Init.pictureBox1.Image = Init.bitmap1;
        }

        public override void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;

            this.Draw();
        }
    }
}
