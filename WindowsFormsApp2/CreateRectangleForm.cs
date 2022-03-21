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
    public partial class CreateRectangleForm : Form
    {
        public Form1 form;
        public Rectagle rectagle;
        public CreateRectangleForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
            try
            {
                this.rectagle = new Rectagle(int.Parse(textBoxRectX.Text), int.Parse(textBoxRectY.Text), int.Parse(textBoxW.Text), int.Parse(textBoxH.Text));
                ShapeContainer.AddFigure(this.rectagle);
                this.rectagle.Draw();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены.");
            }
        }
    }
}
