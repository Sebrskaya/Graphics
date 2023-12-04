using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Graphics.FigureItems;
using Graphics.SetOfPropsItems;

namespace Graphics
{
    public partial class Form1 : Form
    {
        Painter painter = new Painter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            painter.SetPort(Handle);
            painter.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frame frame = new Frame(400, 100, 300, 520);
            Properties properties = new Properties();
            LineSetOfProps lineSetOfProps = new LineSetOfProps(Color.LightSkyBlue,10);
            properties.Add(lineSetOfProps);
            Line line = new Line(frame, properties);
            line.DrawGeometry(painter);

            List<GraphObject> list = new List<GraphObject>();
            list.Add(line);

            Group group = new Group(list);
            group.Draw(painter);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Properties properties = new Properties();
            Frame frame = new Frame(200, 200, 300, 100);
            LineSetOfProps lineSetOfProps = new LineSetOfProps(Color.Yellow, 5);
            properties.Add(lineSetOfProps);
            Line line = new Line(frame, properties);

            Properties properties1 = new Properties();
            Frame frame1 = new Frame(200, 200, 400, 50);
            LineSetOfProps lineSetOfProps1 = new LineSetOfProps(Color.LightPink, 5);
            FillSetOfProps fillSetOfProps1 = new FillSetOfProps(Color.Pink);
            properties1.Add(lineSetOfProps1);
            properties1.Add(fillSetOfProps1);
            Rectangl rectangl = new Rectangl(frame1, properties1);

            List<GraphObject> list = new List<GraphObject>();
            list.Add(line);
            list.Add(rectangl);

            Group group = new Group(list);
            group.Draw(painter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties props = new Properties();
            Frame frame = new Frame(500, 250, 200, 200);
            LineSetOfProps lineSetOfProps = new LineSetOfProps(Color.DarkBlue, 10);
            FillSetOfProps fillSetOfProps = new FillSetOfProps(Color.Blue);
            props.Add(lineSetOfProps);
            props.Add(fillSetOfProps);
            
            Rectangl rectangle = new Rectangl(frame, props);

            List<GraphObject> list = new List<GraphObject>();
            list.Add(rectangle);

            Group group = new Group(list);
            group.Draw(painter);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties props = new Properties();
            Frame frame = new Frame(600, 50, 100, 100);
            LineSetOfProps lineSetOfProps = new LineSetOfProps(Color.LightYellow, 30);
            FillSetOfProps fillSetOfProps = new FillSetOfProps(Color.Yellow);
            props.Add(lineSetOfProps);
            props.Add(fillSetOfProps);

            Ellipse ellipse = new Ellipse(frame, props);

            List<GraphObject> list = new List<GraphObject>();
            list.Add(ellipse);

            Group group = new Group(list);
            group.Draw(painter);

        }
    }
}