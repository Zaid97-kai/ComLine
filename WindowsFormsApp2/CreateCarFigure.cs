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
    public partial class CreateCarFigure : Form
    {
        public Form1 form;
        public Car car;
        public CreateCarFigure()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
            try
            {
                this.car = new Car(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text), int.Parse(textBox1.Text), textBoxNameCar.Text);
                ShapeContainer.AddFigure(this.car);
                this.car.Draw();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены.");
            }
        }
    }
}
