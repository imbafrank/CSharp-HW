using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImporvedTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }
            else
            {
                graphics.Clear(Color.LightGray);
                //graphics.Dispose();
                graphics = this.CreateGraphics();
            }
            int n = 10;
            double x0 = 200, y0 = 310;
            //double leng = 100;
            double th = -Math.PI / 2;
            DrawTree(n, x0, y0, leng, th);
        }

        void DrawTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = (x0 + leng * Math.Cos(th)),y1= (y0 + leng * Math.Sin(th));
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
            DrawTree(n - 1, x1, y1, 0.6 * leng, th + 60 * Math.PI / 180);
            DrawTree(n - 1, x1, y1, 0.7* leng, th - 20 * Math.PI / 180);
        }

    
        private Graphics graphics;
        private double leng=10;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //this.trackBar1.DataBindings.Add("Value", leng, "Name");
            leng = this.trackBar1.Value;
            this.label1.Text = "Length=" + leng;
        }
    }
}
