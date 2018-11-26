using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelixToolkit;
using System.Drawing.Drawing2D;

namespace Clipping
{

    public partial class Form1 : Form
    {
        Bitmap bmp;
        Bitmap ColorBuffer;
        double[,] ZBuffer;
        Graphics g;
        Pen pen_shape = new Pen(Color.Blue); // для фигуры
        Pen pen_axis = new Pen(Color.Green); // для осей
        int centerX, centerY; // центр pictureBox
        double Width, Height = 0;
        List<Face> shape = new List<Face>(); // фигура - список граней
        List<Vector> shape_points = new List<Vector>(); // точки без повторений
        List<Vector> points = new List<Vector>(); // список образующих точек

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;

            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                switch (keyData)
                {
                    case Keys.Down:
                        //do shit;
                        break;

                    case Keys.Up:
                        //do shit;
                        break;

                    case Keys.Left:
                        //do shit;
                        break;

                    case Keys.Right:
                        //do shit;
                        break;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
            Console.WriteLine(bmp.Width);
            Console.WriteLine(bmp.Height);
            this.Width = bmp.Width;
            this.Height = bmp.Height;
            pictureBox.Image = ColorBuffer; centerX = pictureBox.Width / 2; centerY = pictureBox.Height / 2;
            this.ColorBuffer = new Bitmap((int)Math.Ceiling(this.Width), (int)Math.Ceiling(this.Height));
            this.ZBuffer = new double[(int)Math.Ceiling(this.Width), (int)Math.Ceiling(this.Height)];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = Graphics.FromImage(ColorBuffer);
            NoShape.Checked = true;
            countRotation.Value = 20;
            BuildPoints();
        }


        public void Model(string filename)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                shape.Clear();
                var read = new System.IO.StreamReader(openFileDialog1.FileName);
                string text;
                int n = Int32.Parse(read.ReadLine());
                shape = new List<Face>();
                List<Vector> ps = new List<Vector>();
                for (int i = 0; i < n; i++)
                {
                    text = read.ReadLine();
                    string[] coords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var c in coords)
                    {
                        Console.WriteLine(c);
                    }
                    if (text.Substring(0, 2) == "v ")
                    {
                        Vector p = new Vector(double.Parse(coords[0]), double.Parse(coords[1]), double.Parse(coords[2]));
                        ps.Add(p);
                    }
                    else if (text.Substring(0, 2) == "f ")
                    {
                        Face f = new Face();
                        Vector p1 = ps[int.Parse(coords[0]) - 1];
                        Vector p2 = ps[int.Parse(coords[1]) - 1];
                        Vector p3 = ps[int.Parse(coords[2]) - 1];
                        f.add(p1);
                        f.add(p2);
                        f.add(p3);
                        shape.Add(f);
                    }
                    //Vector p2 = new Vector(double.Parse(coords[3]), double.Parse(coords[4]), double.Parse(coords[5]));
                    //Vector p3 = new Vector(double.Parse(coords[6]), double.Parse(coords[7]), double.Parse(coords[8]));
                    //f.add(p1); f.add(p2); f.add(p3);
                    //shape.Add(f);
                }
                read.Dispose();
                BuildPoints();
                RedrawImage();
            }
        }

        private void BuildPoints()
        {
            shape_points.Clear();
            foreach (Face sh in shape)
                for (int i = 0; i < sh.points.Count; i++)
                    if (!shape_points.Contains(sh.points[i]))
                        shape_points.Add(sh.points[i]);
        }


        private void DrawPoint(Vector p) // рисуем точку
        {
            g.FillEllipse(new SolidBrush(Color.Red), (int)Math.Round(p.X + centerX - 3), (int)Math.Round(-p.Y + centerY - 3), 6, 6);
        }

        private void DrawFace(Face f, Pen pen) // рисуем грань
        {
            int n = f.points.Count - 1;

            Console.WriteLine("NEW FACE");
            /*
            PointF[] ps = { };
            foreach (Vector p in f.points)
            {
                Console.WriteLine("x:" + p.X + " " + "y:" + p.Y + " " + "z:" + p.Z);
                PointF po = new PointF((float)p.X + centerX, -(float)p.Y + centerY);
                Array.Resize(ref ps, ps.Length + 1);
                ps[ps.Length - 1] = po;
            }
            */
            //SolidBrush brush = new SolidBrush(pen.Color);

            if (ZBufferBox.Checked)
            {
                int x1 = (int)Math.Round(f.points[0].X + centerX);
                int x2 = (int)Math.Round(f.points[1].X + centerX);
                int x3 = (int)Math.Round(f.points[2].X + centerX);
                int y1 = (int)Math.Round(-f.points[0].Y + centerY);
                int y2 = (int)Math.Round(-f.points[1].Y + centerY);
                int y3 = (int)Math.Round(-f.points[2].Y + centerY);
                Vertex a = new Vertex(new Vector(x1, y1, f.points[0].Z), new Vector(), Color.White);
                Vertex b = new Vertex(new Vector(x2, y2, f.points[1].Z), new Vector(), Color.Black);
                Vertex c = new Vertex(new Vector(x3, y3, f.points[2].Z), new Vector(), Color.Black);
                DrawTriangle(a, b, c);
            }
            else
            {
                Vector norm = f.Normal();

                Console.WriteLine("Color:" + pen.Color);
                double cos = Vector.CosBetweenNormals(norm, new Vector(0, 0, -1));
                //Console.WriteLine("Cos:" + cos);

                if (cos < 0)
                {
                    int x1 = (int)Math.Round(f.points[0].X + centerX);
                    int x2 = (int)Math.Round(f.points[n].X + centerX);
                    int y1 = (int)Math.Round(-f.points[0].Y + centerY);
                    int y2 = (int)Math.Round(-f.points[n].Y + centerY);
                    g.DrawLine(pen, x1, y1, x2, y2);

                    for (int i = 0; i < n; i++)
                    {
                        x1 = (int)Math.Round(f.points[i].X + centerX);
                        x2 = (int)Math.Round(f.points[i + 1].X + centerX);
                        y1 = (int)Math.Round(-f.points[i].Y + centerY);
                        y2 = (int)Math.Round(-f.points[i + 1].Y + centerY);
                        g.DrawLine(pen, x1, y1, x2, y2);
                    }
                }
            }

        }


        private void RedrawImage() 
        {
            Console.WriteLine("NEW REDRAWING------------------");
            g.Clear(Color.Black);
            g.DrawLine(pen_axis, new Point(0, centerY), new Point(pictureBox.Width, centerY));
            g.DrawLine(pen_axis, new Point(centerX, 0), new Point(centerX, pictureBox.Height));

            if (ZBufferBox.Checked)
            {
                this.ZBuffer = new double[(int)Math.Ceiling(this.Width), (int)Math.Ceiling(this.Height)];
                for (int j = 0; j < (int)Math.Ceiling(this.Height); ++j)
                    for (int i = 0; i < (int)Math.Ceiling(this.Width); ++i)
                        ZBuffer[i, j] = double.MinValue;
            }

            if (points.Count > 1)
            {
                DrawPoint(points[0]);
                for (int i = 1; i < points.Count; i++)
                {
                    DrawPoint(points[i]);
                    g.DrawLine(pen_axis, (float)points[i - 1].X + centerX, centerY - (float)points[i - 1].Y, (float)points[i].X + centerX, centerY - (float)points[i].Y);
                }
            }

            foreach (Vector p in points)
                DrawPoint(p);

            foreach (Face f in shape)
            {
                //Pen pen_shape = new Pen(f.color); 
                DrawFace(f, pen_shape);
            }
            pictureBox.Image = ColorBuffer;
        }

        private void BuildTetrahedron()
        {
            //BuildCube();
            double h = Math.Sqrt(3) / 2 * 100;

            Vector p1 = new Vector(-50, -h / 2, 0);
            Vector p2 = new Vector(0, -h / 2, -h);
            Vector p3 = new Vector(50, -h / 2, 0);
            Vector p4 = new Vector(0, h / 2, 0);

            Face f1 = new Face(); f1.add(p4); f1.add(p1); f1.add(p3); f1.color = Color.Blue; shape.Add(f1);
            Face f2 = new Face(); f2.add(p4); f2.add(p2); f2.add(p1); f2.color = Color.Yellow; shape.Add(f2);
            Face f3 = new Face(); f3.add(p4); f3.add(p3); f3.add(p2); f3.color = Color.Cyan; shape.Add(f3);
            Face f4 = new Face(); f4.add(p1); f4.add(p2); f4.add(p3); f4.color = Color.Red; shape.Add(f4);
        }
        private void BuildCube(double xc = 0, double yc = 0, double zc = 0, double h = 50)
        {
            Vector p1 = new Vector(xc - h, yc - h, zc - h);
            Vector p2 = new Vector(xc + h, yc - h, zc - h);
            Vector p3 = new Vector(xc + h, yc - h, zc + h);
            Vector p4 = new Vector(xc - h, yc - h, zc + h);
            Vector p5 = new Vector(xc - h, yc + h, zc - h);
            Vector p6 = new Vector(xc + h, yc + h, zc - h);
            Vector p7 = new Vector(xc + h, yc + h, zc + h);
            Vector p8 = new Vector(xc - h, yc + h, zc + h);

            if (!ZBufferBox.Checked)
            {
                Face f1 = new Face(); f1.add(p5); f1.add(p1); f1.add(p4); f1.add(p8); f1.color = Color.Orange; shape.Add(f1);
                Face f2 = new Face(); f2.add(p6); f2.add(p2); f2.add(p1); f2.add(p5); f2.color = Color.Blue; shape.Add(f2);
                Face f3 = new Face(); f3.add(p7); f3.add(p3); f3.add(p2); f3.add(p6); f3.color = Color.Red; shape.Add(f3);
                Face f4 = new Face(); f4.add(p8); f4.add(p4); f4.add(p3); f4.add(p7); f4.color = Color.Green; shape.Add(f4);
                Face f5 = new Face(); f5.add(p5); f5.add(p8); f5.add(p7); f5.add(p6); f5.color = Color.White; shape.Add(f5);
                Face f6 = new Face(); f6.add(p4); f6.add(p1); f6.add(p2); f6.add(p3); f6.color = Color.Yellow; shape.Add(f6);
            }
            else
            {
                Face f11 = new Face(); f11.add(p5); f11.add(p1); f11.add(p8); f11.color = Color.Orange; shape.Add(f11);
                Face f12 = new Face(); f12.add(p1); f12.add(p4); f12.add(p8); f12.color = Color.Orange; shape.Add(f12);
                Face f21 = new Face(); f21.add(p6); f21.add(p2); f21.add(p5); f21.color = Color.Blue; shape.Add(f21);
                Face f22 = new Face(); f22.add(p2); f22.add(p1); f22.add(p5); f22.color = Color.Blue; shape.Add(f22);
                Face f31 = new Face(); f31.add(p7); f31.add(p3); f31.add(p6); f31.color = Color.Red; shape.Add(f31);
                Face f32 = new Face(); f32.add(p3); f32.add(p2); f32.add(p6); f32.color = Color.Red; shape.Add(f32);
                Face f41 = new Face(); f41.add(p8); f41.add(p4); f41.add(p7); f41.color = Color.Green; shape.Add(f41);
                Face f42 = new Face(); f42.add(p4); f42.add(p3); f42.add(p7); f42.color = Color.Green; shape.Add(f42);
                Face f51 = new Face(); f51.add(p5); f51.add(p8); f51.add(p6); f51.color = Color.White; shape.Add(f51);
                Face f52 = new Face(); f52.add(p8); f52.add(p7); f52.add(p6); f52.color = Color.White; shape.Add(f52);
                Face f61 = new Face(); f61.add(p4); f61.add(p1); f61.add(p3); f61.color = Color.Yellow; shape.Add(f61);
                Face f62 = new Face(); f62.add(p1); f62.add(p2); f62.add(p3); f62.color = Color.Yellow; shape.Add(f62);
            }
        }

        private void Displacement(double kx, double ky, double kz) // сдвиг
        {
            Matrix transform = Transformations.Translate(kx, ky, kz);
            foreach (Vector p in shape_points)
            {
                p.updateFromVector(transform.Multiple(p.getVector()));
            }
        }

        private void Rotate(double xangle, double yangle, double zangle) // поворот
        {
            Matrix mx = Transformations.RotateX(xangle);
            Matrix my = Transformations.RotateY(yangle);
            Matrix mz = Transformations.RotateZ(zangle);
            Matrix transform = mx.Multiple(my).Multiple(mz);
            foreach (Vector p in shape_points)
            {
                p.updateFromVector(transform.Multiple(p.getVector()));
                //p.updateFromVector(mx.Multiple(p.getVector()));
                //p.updateFromVector(my.Multiple(p.getVector()));
                //p.updateFromVector(mz.Multiple(p.getVector()));
            }
        }


        private Vector CenterPoint() // центр фигуры
        {
            double sumX = 0, sumY = 0, sumZ = 0;
            int count = 0;
            for (int i = 0; i < shape.Count; i++)
                for (int j = 0; j < shape[i].points.Count; j++)
                {
                    sumX += shape[i].points[j].X;
                    sumY += shape[i].points[j].Y;
                    sumZ += shape[i].points[j].Z;
                    ++count;
                }
            return new Vector(sumX / count, sumY / count, sumZ / count);
        }

        private void Scaling(double xScale, double yScale, double zScale) // масштабирование
        {
            Vector center_P = CenterPoint();

            Matrix scale = Transformations.Scale(xScale, yScale, zScale);
            Matrix displ1 = Transformations.Translate(-center_P.X, -center_P.Y, -center_P.Z);
            Matrix displ2 = Transformations.Translate(center_P.X, center_P.Y, center_P.Z);
            foreach (Vector p in shape_points)
            {
                p.updateFromVector(displ1.Multiple(p.getVector()));
                p.updateFromVector(scale.Multiple(p.getVector()));
                p.updateFromVector(displ2.Multiple(p.getVector()));
            }

        }

        private void DisplacementButtonClick(object sender, EventArgs e) // перенос
        {
            int kx = (int)x_shift.Value, ky = (int)y_shift.Value, kz = (int)z_shift.Value;
            Displacement(kx, ky, kz);
            RedrawImage();
        }


        private void RotateButtonClick(object sender, EventArgs e) // поворот
        {
            double xangle = ((double)x_rotate.Value * Math.PI) / 180;
            double yangle = ((double)y_rotate.Value * Math.PI) / 180;
            double zangle = ((double)z_rotate.Value * Math.PI) / 180;
            Rotate(xangle, yangle, zangle);
            RedrawImage();
        }

        private void ScaleButtonClick(object sender, EventArgs e) // масштабирование
        {
            Scaling((double)x_scale.Value, (double)y_scale.Value, (double)z_scale.Value);
            RedrawImage();
        }


        //Указать образующие
        private void pictureBoxMouseClick(object sender, MouseEventArgs e)
        {
            if (SetPoints.Checked)
            {
                Vector p = new Vector(e.X - centerX, centerY - e.Y, 0);
                if (p.X > 0)
                    points.Add(p);
            }
            RedrawImage();
        }

        //Открыть из файла
        private void button1_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    shape.Clear();
            //    var read = new System.IO.StreamReader(openFileDialog1.FileName);
            //    string text;
            //    int n = Int32.Parse(read.ReadLine());
            //    shape = new List<Face>();
            //    for (int i = 0; i < n; i++)
            //    {
            //        text = read.ReadLine();
            //        string[] coords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //        //Face f1 = new Face();
            //        //Face f2 = new Face();
            //        //Console.WriteLine(coords.Count());
            //        //Vector p1 = new Vector(double.Parse(coords[0]), double.Parse(coords[1]), double.Parse(coords[2]));
            //        //Vector p2 = new Vector(double.Parse(coords[3]), double.Parse(coords[4]), double.Parse(coords[5]));
            //        //Vector p3 = new Vector(double.Parse(coords[6]), double.Parse(coords[7]), double.Parse(coords[8]));
            //        //Vector p4 = new Vector(double.Parse(coords[9]), double.Parse(coords[10]), double.Parse(coords[11]));
            //        //f1.add(p1); f1.add(p2); f1.add(p4);
            //        //f2.add(p2); f2.add(p3); f2.add(p4);
            //        //shape.Add(f1);
            //        //shape.Add(f2);
            //
            //        Face f = new Face();
            //        Console.WriteLine(coords.Count());
            //        Vector p1 = new Vector(double.Parse(coords[0]), double.Parse(coords[1]), double.Parse(coords[2]));
            //        Vector p2 = new Vector(double.Parse(coords[3]), double.Parse(coords[4]), double.Parse(coords[5]));
            //        Vector p3 = new Vector(double.Parse(coords[6]), double.Parse(coords[7]), double.Parse(coords[8]));
            //        f.add(p1); f.add(p2); f.add(p3);
            //        shape.Add(f);
            //    }
            //    read.Dispose();
            //    BuildPoints();
            //    RedrawImage();
            //}

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                shape.Clear();
                var read = new System.IO.StreamReader(openFileDialog1.FileName);
                string text;
                int n = Int32.Parse(read.ReadLine());
                shape = new List<Face>();
                List<Vector> ps = new List<Vector>();
                for (int i = 0; i < n; i++)
                {
                    text = read.ReadLine();
                    string[] coords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    //foreach (var c in coords)
                    //    Console.WriteLine(c);
                    if (text.Substring(0, 2) == "v ")
                    {
                        Vector p = new Vector(double.Parse(coords[1]) * 250, double.Parse(coords[2]) * 250, double.Parse(coords[3]) * 250);
                        ps.Add(p);
                    }
                    else if (text.Substring(0, 2) == "f ")
                    {
                        Face f = new Face();
                        Vector p1 = ps[int.Parse(coords[1]) - 1];
                        Vector p2 = ps[int.Parse(coords[2]) - 1];
                        Vector p3 = ps[int.Parse(coords[3]) - 1];
                        f.add(p1);
                        f.add(p2);
                        f.add(p3);
                        shape.Add(f);
                    }
                    //Vector p2 = new Vector(double.Parse(coords[3]), double.Parse(coords[4]), double.Parse(coords[5]));
                    //Vector p3 = new Vector(double.Parse(coords[6]), double.Parse(coords[7]), double.Parse(coords[8]));
                    //f.add(p1); f.add(p2); f.add(p3);
                    //shape.Add(f);
                }
                Console.WriteLine("Done.");
                read.Dispose();
                BuildPoints();
                RedrawImage();
            }
        }

        //Сохранить в файл
        private void button2_Click(object sender, EventArgs e)
        {
            string file_name = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                file_name = saveFileDialog1.FileName;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(file_name))
            {
                file.WriteLine(shape.Count());
                foreach (Face f in shape)
                {
                    foreach (Vector p in f.points)
                    {
                        file.Write(p.X.ToString() + " " + p.Y.ToString() + " " + p.Z.ToString() + " ");
                    }
                    file.WriteLine();
                }

            }
        }


        private void shape_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked == false)
                return;
            shape.Clear();
            if (tetrahedron.Checked)
                BuildTetrahedron();
            if (Cube.Checked)
            {
                BuildCube(0, 0, 0, 50);
            }
            BuildPoints();
            RedrawImage();
        }

        private void CreateRotationFigure(object sender, EventArgs e)
        {
            shape.Clear();
            int count = (int)countRotation.Value;
            double angle = (360 / count * Math.PI) / 180;
            Matrix m = Transformations.RotateY(angle);
            for (int c = 0; c < count; c++)
            {
                List<Vector> nextPoints = new List<Vector>();
                for (int i = 0; i < points.Count; i++)
                {
                    Vector p = new Vector();
                    p.updateFromVector(m.Multiple(points[i].getVector()));
                    nextPoints.Add(p);
                }
                for (int i = 1; i < points.Count; i++)
                {
                    Face f = new Face();
                    f.add(points[i - 1]);
                    f.add(points[i]);
                    f.add(nextPoints[i - 1]);

                    Face f1 = new Face();
                    f1.add(points[i]);
                    f1.add(nextPoints[i]);
                    f1.add(nextPoints[i - 1]);
                    f.color = Color.Blue;
                    shape.Add(f);
                    shape.Add(f1);
                }
                points = nextPoints;
            }
            points.Clear();
            BuildPoints();
            RedrawImage();
        }

        private double Interpolate(double x0, double x1, double f)
        {
            return x0 + (x1 - x0) * f;
        }

        private long Interpolate(long x0, long x1, double f)
        {
            return x0 + (long)((x1 - x0) * f);
        }

        private Color Interpolate(Color a, Color b, double f)
        {
            var R = Interpolate(a.R, b.R, f);
            var G = Interpolate(a.G, b.G, f);
            var B = Interpolate(a.B, b.B, f);
            return Color.FromArgb((byte)R, (byte)G, (byte)B);
        }

        private Vector Interpolate(Vector a, Vector b, double f)
        {
            return new Vector(
                Interpolate(a.X, b.X, f),
                Interpolate(a.Y, b.Y, f),
                Interpolate(a.Z, b.Z, f));
        }

        private void Interpolate(Vertex a, Vertex b, double f, ref Vertex v)
        {
            v.Coordinate = Interpolate(a.Coordinate, b.Coordinate, f);
            v.Normal = Interpolate(a.Normal, b.Normal, f);
            v.Color = Interpolate(a.Color, b.Color, f);
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }

        private void ZBufferBox_CheckedChanged(object sender, EventArgs e)
        {
            RedrawImage();
        }

        double converter(int val)
        {
            const int A = -300;
            const int B = 300;
            const int a = 0;
            const int b = 255;
            return (val - A) * (b - a) / (B - A) + a;
        }

        public void DrawTriangle(Vertex a, Vertex b, Vertex c)
        {
            if (a.Coordinate.Y > b.Coordinate.Y)
                Swap(ref a, ref b);
            if (a.Coordinate.Y > c.Coordinate.Y)
                Swap(ref a, ref c);
            if (b.Coordinate.Y > c.Coordinate.Y)
                Swap(ref b, ref c);

            Vertex left = new Vertex();
            Vertex right = new Vertex();
            Vertex point = new Vertex();

            for (double y = a.Coordinate.Y; y < c.Coordinate.Y; ++y)
            {
                if (y < 0 || y > (Height - 1))
                    continue;

                bool topHalf = y < b.Coordinate.Y;

                var a0 = a;
                var a1 = c;
                Interpolate(a0, a1, (y - a0.Coordinate.Y) / (a1.Coordinate.Y - a0.Coordinate.Y), ref left);

                var b0 = topHalf ? a : b;
                var b1 = topHalf ? b : c;
                Interpolate(b0, b1, (y - b0.Coordinate.Y) / (b1.Coordinate.Y - b0.Coordinate.Y), ref right);

                if (left.Coordinate.X > right.Coordinate.X) Swap(ref left, ref right);

                for (double x = left.Coordinate.X; x < right.Coordinate.X; ++x)
                {
                    if (x < 0 || x > (Width - 1))
                        continue;

                    Interpolate(left, right, (x - left.Coordinate.X) / (right.Coordinate.X - left.Coordinate.X), ref point);

                    if (point.Coordinate.Z > 300 || point.Coordinate.Z < -300)
                        continue;

                    if (point.Coordinate.Z > ZBuffer[(int)x, (int)y])
                    {
                        ZBuffer[(int)x, (int)y] = point.Coordinate.Z;

                        int comp = (int)converter((int)point.Coordinate.Z);
                        point.Color = Color.FromArgb(comp,
                                                     comp,
                                                     comp);
                        ColorBuffer.SetPixel((int)x, (int)y, point.Color);
                    }
                }
            }

        }
    }
}