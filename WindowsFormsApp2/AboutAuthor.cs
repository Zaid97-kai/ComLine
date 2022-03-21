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
    public partial class AboutAuthor : Form
    {
        public Form1 form;
        public AboutAuthor()
        {
            InitializeComponent();
            label1.Text = "Автор программы - Заид Мингалиев. \n Все права защищены.";
            pictureBox1.Image = Properties.Resources.LU3dPrcSYg0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.Visible = true;
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AboutAuthor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
