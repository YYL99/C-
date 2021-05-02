using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //定义一个Pen对象，并设置颜色为蓝色
            Pen myPen = new Pen(Color.Blue);
            //通过CreateGraphics()方法创建定义一个Graphics对象
            Graphics g;
            g = this.CreateGraphics();
            //使用Pen对象画直线，并设置位置和大小
            g.DrawLine(myPen, 100, 100, 200, 200);
            //释放资源
            myPen.Dispose();
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen myPen1 = new Pen(Color.Blue);
            Graphics g1;
            g1 = this.CreateGraphics();
            g1.DrawEllipse(myPen1, new Rectangle(10, 10, 200, 200));//画圆
            myPen1.Dispose();
            g1.Dispose();

            Pen myPen2 = new Pen(Color.Red);
            Graphics g2;
            g2 = this.CreateGraphics();
            g2.DrawRectangle(myPen2, new Rectangle(10, 10, 200, 200));
            myPen2.Dispose();
            g2.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush sdBrush = new SolidBrush(Color.Red);
            g.FillEllipse(sdBrush, 10, 10, 200, 120);
            g.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            HatchBrush hBrush = new HatchBrush(HatchStyle.Plaid, Color.Red);
            g.FillRectangle(hBrush, 10, 10, 240, 150);
            hBrush.Dispose();
            g.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Image image = Image.FromFile("vs2019_logo.png");//图片未找到，出现错误
            TextureBrush hBrush = new TextureBrush(image);
            g.FillEllipse(hBrush, 10, 10, 260, 170);
            hBrush.Dispose();
            g.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle myRectangle = new Rectangle(40, 20, 190, 70);
            LinearGradientBrush lgBrush = new LinearGradientBrush(myRectangle, 
                Color.Red, Color.YellowGreen, LinearGradientMode.Horizontal);
            g.FillRectangle(lgBrush, myRectangle);
            lgBrush.Dispose();
            g.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point centerPoint = new Point(150, 160);
            GraphicsPath path = new GraphicsPath();
            int R = 20;
            path.AddEllipse(centerPoint.X - R, centerPoint.Y - R, 2 * R, 2 * R);
            path.AddEllipse(centerPoint.X - 2 * R, centerPoint.Y - 2 * R, 4 * R, 4 * R);
            path.AddEllipse(centerPoint.X - 3 * R, centerPoint.Y - 3 * R, 6 * R, 6 * R);
            PathGradientBrush pgbrush = new PathGradientBrush(path);
            pgbrush.CenterPoint = centerPoint;
            pgbrush.CenterColor = Color.Red;
            pgbrush.SurroundColors = new Color[] { Color.Red, Color.Green, Color.BlueViolet };
            g.FillPath(pgbrush, path);
            pgbrush.Dispose();
            g.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string drawString = "使用DrawString方法";
            System.Drawing.Font myFont = new System.Drawing.Font("微软雅黑", 20);
            System.Drawing.Brush b = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            float x = 15.0F;
            float y = 15.0F;
            System.Drawing.StringFormat myFormat = new System.Drawing.StringFormat();
            g.DrawString(drawString, myFont, b, x, y, myFormat);
        }
    }
}
