using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleAreaApp
{
    public partial class CircleUI : Form
    {
        public CircleUI()
        {
            InitializeComponent();
        }

        Circle aCircle = new Circle();
        private void areaButton_Click(object sender, EventArgs e)
        {
            aCircle.radious = Convert.ToDouble(radiusTextBox.Text);
            MessageBox.Show("The Circle Area is= " + aCircle.GetArea());
        }

        private void diameterButton_Click(object sender, EventArgs e)
        {
            aCircle.radious = Convert.ToDouble(radiusTextBox.Text);
            MessageBox.Show("The circle diamiter is=" + aCircle.GetDiamiter());
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            aCircle.radious = Convert.ToDouble(radiusTextBox.Text);
            MessageBox.Show("The circle is Perimiter is= " + aCircle.GetPerimeter());
        }
    }
}
