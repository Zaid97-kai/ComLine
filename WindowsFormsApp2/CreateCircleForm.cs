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
    public partial class CreateCircleForm : Form
    {
        public Form1 form;
        public Circle circle;
        public CreateCircleForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
            try
            {
                this.circle = new Circle(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxR.Text));
                ShapeContainer.AddFigure(this.circle);
                this.circle.Draw();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены.");
            }
        }
    }
}
