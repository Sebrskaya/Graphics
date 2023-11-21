using System.Security.Cryptography.X509Certificates;

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
            Frame frame = new Frame(10,10,20,20);
            Properties properties = new Properties();
            LineSetOfProps lineSetOfProps = new LineSetOfProps(Color.LightSkyBlue,10);
            properties.Add(lineSetOfProps);
            Line line = new Line(frame, properties);
            line.DrawGeometry(painter);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Properties properties = new Properties();
            Frame frame = new Frame(300, 300, 200, 200);
            LineSetOfProps lineSetOfProps = new LineSetOfProps(Color.LightSkyBlue, 10);
            properties.Add(lineSetOfProps);
            Line line = new Line(frame, properties);

            Properties properties1 = new Properties();
            Frame frame1 = new Frame(200, 200, 100, 100);
            LineSetOfProps lineSetOfProps1 = new LineSetOfProps(Color.RosyBrown, 20);
            properties1.Add(lineSetOfProps1);
            Line line1 = new Line(frame1, properties1);

            List<GraphObject> list = new List<GraphObject>();
            list.Add(line);
            list.Add(line1);

            Group group = new Group(list);
            group.Draw(painter);
        }
    }
}