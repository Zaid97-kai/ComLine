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
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Pen pen;
        Circle circle;
        Rectagle rectagle;
        Car car;
        Triangle triangle;
        Polygon polygon;
        ShapeContainer shapeContainer;
        CreateTriangleForm createTriangleForm = new CreateTriangleForm();
        CreateCarFigure createCarFigure = new CreateCarFigure();
        CreateRectangleForm createRectangleForm = new CreateRectangleForm();
        CreatePolygon createPolygon = new CreatePolygon();
        AboutAuthor aboutAuthor = new AboutAuthor();
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap1 = this.bitmap;
            Init.pictureBox1 = pictureBox1;
            Init.pen1 = this.pen;
            this.shapeContainer = new ShapeContainer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.GetType() == (new Circle()).GetType())
                {
                    try
                    {
                        this.circle = (Circle)comboBox1.SelectedItem;
                        this.circle.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Не все поля заполнены.");
                    }
                }
                if (comboBox1.SelectedItem.GetType() == (new Rectagle()).GetType())
                {
                    try
                    {
                        this.rectagle = (Rectagle)comboBox1.SelectedItem;
                        this.rectagle.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Не все поля заполнены.");
                    }
                }
                if (comboBox1.SelectedItem.GetType() == (new Car()).GetType())
                {
                    try
                    {
                        this.car = (Car)comboBox1.SelectedItem;
                        this.car.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Не все поля заполнены.");
                    }
                }
                if (comboBox1.SelectedItem.GetType() == (new Triangle()).GetType())
                {
                    try
                    {
                        this.triangle = (Triangle)comboBox1.SelectedItem;
                        this.triangle.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Не все поля заполнены.");
                    }
                }
                if (comboBox1.SelectedItem.GetType() == (new Polygon()).GetType())
                {
                    try
                    {
                        this.polygon = (Polygon)comboBox1.SelectedItem;
                        this.polygon.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                    }
                    catch
                    {
                        MessageBox.Show("Не все поля заполнены.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали фигуру!");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateCircleForm createCircleForm = new CreateCircleForm();
            createCircleForm.form = this;
            createCircleForm.Show();
            this.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            createRectangleForm.form = this;
            createRectangleForm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (Figure figure in ShapeContainer.figureList)
            {
                comboBox1.Items.Add(figure);
            }       
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.GetType() == (new Circle()).GetType())
                {
                    this.circle = (Circle)comboBox1.SelectedItem;
                    this.circle.DeleteF(this.circle);
                }
                else if (comboBox1.SelectedItem.GetType() == (new Rectagle()).GetType())
                {
                    this.rectagle = (Rectagle)comboBox1.SelectedItem;
                    this.rectagle.DeleteF(this.rectagle);
                }
                else if (comboBox1.SelectedItem.GetType() == (new Car()).GetType())
                {
                    this.car = (Car)comboBox1.SelectedItem;
                    this.car.DeleteF(this.car);
                }
                else if (comboBox1.SelectedItem.GetType() == (new Triangle()).GetType())
                {
                    this.triangle = (Triangle)comboBox1.SelectedItem;
                    this.triangle.DeleteF(this.triangle);
                }
                else if (comboBox1.SelectedItem.GetType() == (new Polygon()).GetType())
                {
                    this.polygon = (Polygon)comboBox1.SelectedItem;
                    this.polygon.DeleteF(this.polygon);
                }
            }
            catch
            {
                MessageBox.Show("Вы не выбрали фигуру!");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            createCarFigure.form = this;
            createCarFigure.Show();
            this.Visible = false;
        }

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTriangleForm.form = this;
            createTriangleForm.Show();
            this.Visible = false;
        }

        private void многоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createPolygon.form = this;
            createPolygon.Show();
            this.Visible = false;
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutAuthor.form = this;
            aboutAuthor.Show();
            this.Visible = false;
        }
    }
}
