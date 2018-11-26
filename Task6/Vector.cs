using System;
namespace Clipping
{
    public class Vector
    {
        public double X, Y, Z;

        public Vector()
        {
            this.X = this.Y = this.Z = 0;
        }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Matrix getVector()
        {
            Matrix result = new Matrix(4, 1);
            double[,] m ={
                { X }, {Y}, {Z }, {1 }
            };
            result.matrix = m;
            return result;
        }

        public void updateFromVector(Matrix vector)
        {
            X = vector.matrix[0, 0];
            Y = vector.matrix[1, 0];
            Z = vector.matrix[2, 0];
        }

        // Скалярное произведение векторов
        public static double dotProduct(Vector a, Vector b)
        {
            double result = 0;
            result += a.X * b.X;
            result += a.Y * b.Y;
            result += a.Z * b.Z;
            return result;
        }

        public void Normalize(double dist)
        {
            this.X /= dist;
            this.Y /= dist;
            this.Z /= dist;
        }

        public static double Dist(Vector v1, Vector v2)
        {
            return Math.Sqrt(Math.Pow(v1.Y * v2.Z - v1.Z * v2.Y, 2) +
                             Math.Pow(v1.Z * v2.X - v1.X * v2.Z, 2) +
                             Math.Pow(v1.X * v2.Y - v1.Y * v2.X, 2));
            //return Math.Sqrt(Math.Pow(a.X - b.X, 2) +
            //                 Math.Pow(a.Y - b.Y, 2) +
            //                 Math.Pow(a.Z - b.Z, 2));
        }

        // Модуль вектора
        public static double modul(Vector a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }


        // Векторное произведение векторов
        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector(v1.Y * v2.Z - v1.Z * v2.Y,
                              v1.Z * v2.X - v1.X * v2.Z,
                              v1.X * v2.Y - v1.Y * v2.X);
            //return new Vector((v1.Z * v2.X - v1.X * v2.Z)a.Y * b.Z - a.Z * b.Y,
            //                  (v1.X * v2.Y - v1.Y * v2.X)  a.Z * b.X - a.X * b.Z,
            //                    a.X * b.Y - a.Y * b.X);

            //double mult = a.X * b.X + a.Y * b.Y + a.Z * b.Z;
            //double abs_a = Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(a.Y, 2) + Math.Pow(a.Z, 2));
            //double abs_b = Math.Sqrt(Math.Pow(b.X, 2) + Math.Pow(b.Y, 2) + Math.Pow(b.Z, 2));
            //double cos = mult / (abs_a * abs_b);

            // return cos;

        }

        public static double CosBetweenNormals(Vector a, Vector b)
        {
            return (a.X * b.X + a.Y * b.Y + a.Z * b.Z) /
                   (Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z) *
                   Math.Sqrt(b.X * b.X + b.Y * b.Y + b.Z * b.Z));
        }
    }
}
