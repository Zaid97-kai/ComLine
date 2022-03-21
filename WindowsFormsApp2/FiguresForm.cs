using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FiguresForm : Form
    {
        public FiguresForm()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Pen pen = new Pen(Color.Black, 5);

            Graphics g = Graphics.FromImage(bitmap);
            g.DrawLine(pen, float.Parse(textBoxCoordX.Text), float.Parse(textBoxCoordY.Text), float.Parse(textBoxCoordX.Text) * 2, float.Parse(textBoxCoordY.Text));
            pictureBox1.Image = bitmap;

        }
    }
}
