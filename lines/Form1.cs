using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;

namespace Lines
{
    public partial class Form1 : Form
    {
        float i, x1, y1, x2, y2;
        List<Point> Point1 = new List<Point>();
        //class Line
        //{
        //    private static void Main(string[] args)
        //    {
        //        Point1.Add(new Point
        //        {
        //            y1 = 200.0F,
        //            y2 = 200.0f
        //        });
        //        Point1.Add(new Point
        //        {
        //            y1 = 400.0F,
        //            y2 = 400.0f
        //        });
        //        Point1.Add(new Point
        //        {
        //            y1 = 600.0F,
        //            y2 = 600.0f
        //        });
        //        Point1.Add(new Point
        //        {
        //            y1 = 800.0F,
        //            y2 = 800.0f
        //        });
        //        Point1.Add(new Point
        //        {
        //            y1 = 1000.0F,
        //            y2 = 1000.0f
        //        });

        //        foreach(var Line in Point1)
        //        {
        //            Console.WriteLine(Line.y1);
        //            Console.WriteLine(Line.y2);
        //        }

        //    }
        //    class Point
        //    {
        //        public float x1 = 100.0F;
        //        public float y1 { get; set; }
        //        public float x2 = 500.0F;
        //        public float y2 { get; set; }
        //    }

        //}


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Graphics g = this.panel1.CreateGraphics();
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, 100.0F, y1, 500.0F, y2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Point1[i];
        }
    }
}