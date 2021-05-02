using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //重写OnPaint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics gc = e.Graphics;
            Point p1 = new Point(25, 80);
            Point p2 = new Point(60, 30);
            Point p3 = new Point(160, 150);
            Point p4 = new Point(210, 50);
            Point[] pointList = { p1, p2, p3, p4 };
            Pen pen = new Pen(Color.BlueViolet, 3);
            //gc.DrawCurve(pen, pointList, 1.5F);
            gc.DrawBezier(pen, p1, p2, p3, p4);
        }
    }
}
