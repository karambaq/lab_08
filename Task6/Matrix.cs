using System;
namespace Clipping
{
    public class Matrix
    {
        public double[,] matrix;

        public int Row { get; protected set; }
        public int Column { get; protected set; }
        public Matrix(int row, int column)
        {
            Row = row;
            Column = column;
            matrix = new double[row, column];
        }


        public Matrix Multiple(Matrix value)
        {
            Matrix result = new Matrix(Row, value.Column);
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < value.Column; j++)
                    for (int k = 0; k < value.Row; k++)
                        result.matrix[i, j] += matrix[i, k] * value.matrix[k, j];
            return result;
        }

    }
}
