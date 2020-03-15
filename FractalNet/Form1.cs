using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalNet
{
    public partial class Form1 : Form
    {
        private Graphics gBitmap;
        private Graphics g;
        private Bitmap bitmap;
        private Screen screen;
        private IFractal fractal;       
        public Form1()
        {

            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gBitmap = Graphics.FromImage(bitmap);
            Pen p = new Pen(Color.Blue);
            fractal = new Mandlebrot();
            screen = new Screen(g, fractal, this);
            g = this.CreateGraphics();
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            screen.Paint(gBitmap);
            pictureBox1.Image = bitmap;
            //g.DrawImage(bitmap,new Rectangle(0,0,this.Width,this.Height), new Rectangle(0, 0, this.Width, this.Height),GraphicsUnit.Pixel);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            fractal.Center = screen.GetClickFractalPosition(new Point(e.Location.X,e.Location.Y));

            if (e.Button == MouseButtons.Left)
            {
                fractal.ScaleFactor = fractal.ScaleFactor * 0.8f;
            }
            if (e.Button == MouseButtons.Right)
            {
                fractal.ScaleFactor = fractal.ScaleFactor * 1.2f;
            }


            screen.Paint(gBitmap);
            pictureBox1.Image = bitmap;
        }
    }
}
