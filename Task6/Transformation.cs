using System;
namespace Clipping
{
    public class Transformations
    {

        public static Matrix RotateX(double angle)
        {
            Matrix result = new Matrix(4, 4);
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double[,] m = {
                { 1,   0,    0, 0 },
                { 0, cos, -sin, 0 },
                { 0, sin,  cos, 0 },
                { 0,   0,    0, 1 },
            };
            result.matrix = m;
            return result;
        }

        public static Matrix RotateY(double angle)
        {
            Matrix result = new Matrix(4, 4);
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double[,] m = {
                {  cos, 0, sin, 0 },
                {    0, 1,   0, 0 },
                { -sin, 0, cos, 0 },
                {    0, 0,   0, 1 },
            };
            result.matrix = m;
            return result;
        }

        public static Matrix RotateZ(double angle)
        {
            Matrix result = new Matrix(4, 4);
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);
            double[,] m = {
                { cos, -sin, 0, 0 },
                { sin,  cos, 0, 0 },
                {   0,    0, 1, 0 },
                {   0,    0, 0, 1 },
            };
            result.matrix = m;
            return result;
        }
        public static Matrix Translate(double tx, double ty, double tz)
        {
            Matrix result = new Matrix(4, 4);
            double[,] m = {
                { 1, 0, 0, tx },
                { 0, 1, 0, ty },
                { 0, 0, 1, tz },
                { 0, 0, 0,  1 },
            };
            result.matrix = m;
            return result;
        }

        public static Matrix PerspectiveProjection(double left, double right, double bottom, double top, double near, double far)
        {
            Matrix result = new Matrix(4, 4);
            var a = 2 * near / (right - left);
            var b = (right + left) / (right - left);
            var c = 2 * near / (top - bottom);
            var d = (top + bottom) / (top - bottom);
            var e = -(far + near) / (far - near);
            var f = -2 * far * near / (far - near);
            double[,] m = {
                { a, 0, 0, 0 },
                { 0, c, 0, 0 },
                { b, d, e, -1 },
                { 0, 0, f, 0 }
                };
            result.matrix = m;
            return result;
        }


        public static Matrix Scale(double tx, double ty, double tz)
        {
            Matrix result = new Matrix(4, 4);
            double[,] m = {
                { tx, 0,  0, 0 },
                {  0, ty, 0, 0 },
                {  0, 0, tz, 0 },
                {  0, 0,  0, 1 },
            };
            result.matrix = m;
            return result;
        }
    }
}
