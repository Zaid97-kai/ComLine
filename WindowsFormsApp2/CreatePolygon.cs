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
    public partial class CreatePolygon : Form
    {
        public Form1 form;
        public Polygon polygon;

        private bool flag = false;
        public int numPoints = 0;
        PointF[] pointFs;
        private int i = 0;
        public CreatePolygon()
        {
            InitializeComponent();
            label1.Text = "Введите количество точек: ";
            buttonDrawPolygon.Enabled = false;
            textBoxCoordX.Enabled = false;
            textBoxCoordY.Enabled = false;
            buttonDrawPolygon.Enabled = false;
        }

        private void buttonCreatePoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    numPoints = int.Parse(textBoxNumPoints.Text);
                    this.pointFs = new PointF[numPoints];
                    flag = true;
                    textBoxNumPoints.Enabled = false;
                    textBoxCoordX.Enabled = true;
                    textBoxCoordY.Enabled = true;
                    label1.Text = $"Введите координаты {i + 1}-й точки: ";
                }
                else
                {
                    if (i != numPoints - 1)
                    {
                        label1.Text = $"Введите координаты {i + 1}-й точки: ";
                        pointFs[i].X = float.Parse(textBoxCoordX.Text);
                        pointFs[i].Y = float.Parse(textBoxCoordY.Text);
                        i++;
                    }
                    else
                    {
                        buttonCreatePoint.Enabled = false;
                        buttonDrawPolygon.Enabled = true;
                        flag = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены.");
            }
}

        private void buttonDrawPolygon_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;

            this.polygon = new Polygon();
            this.polygon.pointFs = this.pointFs;
            ShapeContainer.AddFigure(this.polygon);
            this.polygon.Draw();
        }
    }
}
