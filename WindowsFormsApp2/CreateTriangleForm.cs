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
    public partial class CreateTriangleForm : Form
    {
        public Form1 form;
        public Triangle triangle;
        public CreateTriangleForm()
        {
            InitializeComponent();
            textBoxX1.Text = "100";
            textBoxY1.Text = "200";
            textBoxX2.Text = "200";
            textBoxY2.Text = "300";
            textBoxX3.Text = "500";
            textBoxY3.Text = "400";
        }

        private void buttonCreateTriangle_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
            try
            {
                this.triangle = new Triangle(float.Parse(textBoxX1.Text), float.Parse(textBoxY1.Text), float.Parse(textBoxX2.Text), float.Parse(textBoxY2.Text), float.Parse(textBoxX3.Text), float.Parse(textBoxY3.Text));
                ShapeContainer.AddFigure(this.triangle);
                this.triangle.Draw();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены.");
            }
        }
    }
}
