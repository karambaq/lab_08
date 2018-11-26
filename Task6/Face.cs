using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace Clipping
{
    public class Face
    {
        public List<Vector> points;
        public Color color;


        public Face()
        {
            points = new List<Vector>();
        }

        public void add(Vector p)
        {
            points.Add(p);
        }

        public Vector Normal()
        {
            Vector v1 = new Vector();
            Vector v2 = new Vector();

            Vector a = points[0];
            Vector b = points[1];
            Vector c = points[2];
            v1.X = a.X - b.X;
            v1.Y = a.Y - b.Y;
            v1.Z = a.Z - b.Z;

            v2.X = b.X - c.X;
            v2.Y = b.Y - c.Y;
            v2.Z = b.Z - c.Z;

            double dist = Vector.Dist(v1, v2);
            Vector vec = Vector.CrossProduct(v1, v2);
            vec.Normalize(dist);

            return vec;
        }
    }
}
