using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap paper = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics graphics = Graphics.FromImage(paper);// crate disagner

            graphics.Clear(Color.White); // paint backgrond picture box as white to simulate a paper

            #region Lines


            //Point point1= new Point(100, 200);
            //Point point2 = new Point(400, 300);

            //Point[] points= 
            //{
            //    new Point(50, 100),
            //    new Point(20, 300),
            //    new Point(300, 15),
            //    new Point(120, 270)
            //};

            //Brush brush= new SolidBrush(Color.Red);
            //Pen pen1 =  new Pen(brush, 5);
            //Pen pen = new Pen(Color.Black, 5);


            //graphics.DrawLines(pen1, points);

            //graphics.DrawLine(pen, point1, point2);

            #endregion

            #region Rectangles

            // Pen pen = new Pen(Color.Black, 5);
            // Pen pencil = new Pen(Color.Blue, 2);

            // Rectangle rectangle1 = new Rectangle(130, 50, 200, 100);
            // Rectangle rectangle2 = new Rectangle(195, 75, 200, 100);
            // Rectangle rectangle3 = new Rectangle(250, 125, 200, 100);
            // Rectangle rectangle4 = new Rectangle(270, 170, 200, 100);

            // Rectangle[] rectangles = { rectangle1, rectangle2, rectangle3, rectangle4, new Rectangle(15, 60, 200,100) };

            // ////graphics.DrawRectangle(pen, rectangle1);
            // ////graphics.DrawRectangle(pencil, 195, 75, 200,100);

            // //graphics.DrawRectangles(pen, rectangles);
            // Brush brush1= new SolidBrush(Color.Red);
            // Brush brush2 = new LinearGradientBrush(rectangle4, Color.Green, Color.Yellow, 30     ); // gradient 65 grades 
            //// graphics.FillRectangle(brush2, rectangle4);

            // graphics.FillRectangles(brush2, rectangles);

            #endregion

            #region Ellipse or Circle

            //Pen pen = new Pen(Color.Red, 3);
            //Pen pen1 = new Pen(Color.Cyan, 3);
            //Rectangle rectangle = new Rectangle(100, 2, 250, 300);
            //Brush brush= new SolidBrush(Color.Gray);
            ////Brush brush1 = new SolidBrush(Color.Yellow);
            //graphics.DrawRectangle(pen, rectangle);
            //graphics.FillRectangle(Brushes.Yellow, rectangle);
            //graphics.DrawEllipse(pen1, rectangle);
            //graphics.FillEllipse(brush, rectangle);

            #endregion

            #region Poligon

            //Pen pen = new Pen(Color.Red, 3);


            //Point[] points =
            //{
            //    new Point(100, 100),
            //    new Point(100, 200),
            //    new Point(250, 250),
            //    new Point(200,100)
            //};

            ////graphics.DrawPolygon(pen, points);
            //Brush brush= new LinearGradientBrush(new Rectangle(100,100,200,200), Color.Orange, Color.Red, 65);
            //graphics.FillPolygon(brush, points);

            #endregion

            #region Curves

            //Pen pen = new Pen(Color.Red, 3);

            //Point[] points =
            //{
            //    new Point(100, 100),
            //    new Point(100, 200),
            //    new Point(250, 250),
            //    new Point(200,100)
            //};

            //graphics.DrawCurve(pen, points, 2.4f); // my nose XD
            //graphics.FillClosedCurve(Brushes.Yellow, points, 0);

            #endregion

            #region Arc

            //Pen pencil = new Pen(Color.Blue, 2);

            //Rectangle rectangle1 = new Rectangle(130, 50, 300, 250);

            //graphics.DrawArc(pencil, rectangle1, 45f, 200f);

            #endregion

            #region Bezier

            //Pen pen = new Pen(Color.Red, 3);




            //Point point1 = new Point(50, 300);
            //Point point2 = new Point(200, 400);
            //Point point3 = new Point(400, 100);
            //Point point4 = new Point(500, 200);

            //// we can do bezier with a list of point

            //graphics.DrawBezier(pen, point1, point2, point3, point4);

            #endregion

            #region Pie

            //Pen pencil = new Pen(Color.Blue, 2);

            //Rectangle rectangle1 = new Rectangle(50,50,300,300);

            //graphics.DrawPie(pencil, rectangle1, 45f, 45f);

            //FillPie 

            #endregion

            #region Strings

            //            string name = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, 
            //sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
            //Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris 
            //nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in 
            //reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
            //Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia 
            //deserunt mollit anim id est laborum.";
            //            Font font = new Font("comic sans", 16);
            //            Brush brush = new LinearGradientBrush(new Rectangle(0, 0, 829,1000), Color.Red, Color.Yellow, 45);
            //            PointF pointF = new PointF(23,45);

            //            // graphics.DrawString(name, font, brush, pointF);
            //            graphics.DrawString(name, font ,brush, new Rectangle(10, 20, 600, 400)); // put text inside rectangle

            //            // play with StringFormat for align, wrap, vertical,  text and line

            #endregion

            #region Image

            Image image = Image.FromFile(Application.StartupPath + @"\images\couple.jpg");
            Rectangle origin = new Rectangle(0, 0, image.Width, image.Height); // here we can cut the image
            Rectangle destiny = new Rectangle(0,0, image.Width, image.Height);

            graphics.DrawImage(image, destiny, origin, GraphicsUnit.Pixel);


            #endregion


            pictureBox1.BackgroundImage = paper;

            paper.Save(@"C:\Users\Cangel\Desktop\design.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);


        }
    }
}
