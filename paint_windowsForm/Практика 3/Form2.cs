using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curves
{
    public partial class Form2 : Form
    {
        Form1 form1;
        Color clrU;
        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            form1 = parentForm;
            clrU = parentForm.ColorPoint;
            clrU = parentForm.ColorLine;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = clrU;
            form1.ColorLine = clrU;
            form1.Refresh();
            Close();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Black;
            form1.ColorLine = Color.Black;
            form1.Refresh();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(64, 0, 0);
            form1.ColorLine = Color.FromArgb(64, 0, 0);
            form1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(128, 64, 64);
            form1.ColorLine = Color.FromArgb(128, 64, 64);
            form1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(64, 64, 0);
            form1.ColorLine = Color.FromArgb(64, 64, 0);
            form1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(0, 64, 0);
            form1.ColorLine = Color.FromArgb(0, 64, 0);
            form1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(0, 64, 64);
            form1.ColorLine = Color.FromArgb(0, 64, 64);
            form1.Refresh();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(0, 0, 64);
            form1.ColorLine = Color.FromArgb(0, 0, 64);
            form1.Refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(64, 64, 64);
            form1.ColorLine = Color.FromArgb(64, 64, 64);
            form1.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Maroon;
            form1.ColorLine = Color.Maroon;
            form1.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(128, 64, 64);
            form1.ColorLine = Color.FromArgb(128, 64, 64);
            form1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Olive;
            form1.ColorLine = Color.Olive;
            form1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Green;
            form1.ColorLine = Color.Green;
            form1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Teal;
            form1.ColorLine = Color.Teal;
            form1.Refresh();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Navy;
            form1.ColorLine = Color.Navy;
            form1.Refresh();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Gray;
            form1.ColorLine = Color.Gray;
            form1.Refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(192, 0, 0);
            form1.ColorLine = Color.FromArgb(192, 0, 0);
            form1.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(192, 64, 0);
            form1.ColorLine = Color.FromArgb(192, 64, 0);
            form1.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(192, 192, 0);
            form1.ColorLine = Color.FromArgb(192, 192, 0);
            form1.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(0, 192, 0);
            form1.ColorLine = Color.FromArgb(0, 192, 0);
            form1.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(0, 192, 192);
            form1.ColorLine = Color.FromArgb(0, 192, 192);
            form1.Refresh();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(0, 0, 192);
            form1.ColorLine = Color.FromArgb(0, 0, 192);
            form1.Refresh();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Silver;
            form1.ColorLine = Color.Silver;
            form1.Refresh();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Red;
            form1.ColorLine = Color.Red;
            form1.Refresh();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 128, 0);
            form1.ColorLine = Color.FromArgb(255, 128, 0);
            form1.Refresh();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Yellow;
            form1.ColorLine = Color.Yellow;
            form1.Refresh();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Lime;
            form1.ColorLine = Color.Lime;
            form1.Refresh();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Aqua;
            form1.ColorLine = Color.Aqua;
            form1.Refresh();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.Blue;
            form1.ColorLine = Color.Blue;
            form1.Refresh();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(224, 224, 224);
            form1.ColorLine = Color.FromArgb(224, 224, 224);
            form1.Refresh();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 128, 128);
            form1.ColorLine = Color.FromArgb(255, 128, 128);
            form1.Refresh();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 192, 128);
            form1.ColorLine = Color.FromArgb(255, 192, 128);
            form1.Refresh();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 255, 128);
            form1.ColorLine = Color.FromArgb(255, 255, 128);
            form1.Refresh();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(128, 255, 128);
            form1.ColorLine = Color.FromArgb(128, 255, 128);
            form1.Refresh();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(128, 255, 255);
            form1.ColorLine = Color.FromArgb(128, 255, 255);
            form1.Refresh();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(128, 128, 255);
            form1.ColorLine = Color.FromArgb(128, 128, 255);
            form1.Refresh();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.White;
            form1.ColorLine = Color.White;
            form1.Refresh();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 192, 192);
            form1.ColorLine = Color.FromArgb(255, 192, 192);
            form1.Refresh();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 224, 192);
            form1.ColorLine = Color.FromArgb(255, 224, 192);
            form1.Refresh();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(255, 255, 192);
            form1.ColorLine = Color.FromArgb(255, 255, 192);
            form1.Refresh();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(192, 255, 192);
            form1.ColorLine = Color.FromArgb(192, 255, 192);
            form1.Refresh();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(192, 255, 255);
            form1.ColorLine = Color.FromArgb(192, 255, 255);
            form1.Refresh();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            form1.ColorPoint = Color.FromArgb(192, 192, 255);
            form1.ColorLine = Color.FromArgb(192, 192, 255);
            form1.Refresh();
        }
    }
}
