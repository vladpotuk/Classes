using System;

public class Matrix
{
    private int[,] matrix;


    public Matrix(int rows, int cols)
    {
        matrix = new int[rows, cols];
    }


    public int this[int i, int j]
    {
        get { return matrix[i, j]; }
        set { matrix[i, j] = value; }
    }


    public static Matrix operator +(Matrix mat1, Matrix mat2)
    {
        if (mat1.matrix.GetLength(0) != mat2.matrix.GetLength(0) || mat1.matrix.GetLength(1) != mat2.matrix.GetLength(1))
        {
            throw new ArgumentException("Розміри матриць не співпадають");
        }

        Matrix result = new Matrix(mat1.matrix.GetLength(0), mat1.matrix.GetLength(1));

        for (int i = 0; i < mat1.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.matrix.GetLength(1); j++)
            {
                result[i, j] = mat1[i, j] + mat2[i, j];
            }
        }

        return result;
    }


    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        if (mat1.matrix.GetLength(0) != mat2.matrix.GetLength(0) || mat1.matrix.GetLength(1) != mat2.matrix.GetLength(1))
        {
            throw new ArgumentException("Розміри матриць не співпадають");
        }

        Matrix result = new Matrix(mat1.matrix.GetLength(0), mat1.matrix.GetLength(1));

        for (int i = 0; i < mat1.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.matrix.GetLength(1); j++)
            {
                result[i, j] = mat1[i, j] - mat2[i, j];
            }
        }

        return result;
    }


    public static Matrix operator *(Matrix mat, int scalar)
    {
        Matrix result = new Matrix(mat.matrix.GetLength(0), mat.matrix.GetLength(1));

        for (int i = 0; i < mat.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat.matrix.GetLength(1); j++)
            {
                result[i, j] = mat[i, j] * scalar;
            }
        }

        return result;
    }


    public static Matrix operator *(Matrix mat1, Matrix mat2)
    {
        if (mat1.matrix.GetLength(1) != mat2.matrix.GetLength(0))
        {
            throw new ArgumentException("Кількість стовпців першої матриці не дорівнює кількості рядків другої матриці");
        }

        Matrix result = new Matrix(mat1.matrix.GetLength(0), mat2.matrix.GetLength(1));

        for (int i = 0; i < mat1.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.matrix.GetLength(1); j++)
            {
                for (int k = 0; k < mat1.matrix.GetLength(1); k++)
                {
                    result[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }

        return result;
    }


    public static bool operator ==(Matrix mat1, Matrix mat2)
    {
        if (mat1.matrix.GetLength(0) != mat2.matrix.GetLength(0) || mat1.matrix.GetLength(1) != mat2.matrix.GetLength(1))
        {
            return false;
        }

        for (int i = 0; i < mat1.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.matrix.GetLength(1); j++)
            {
                if (mat1[i, j] != mat2[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }


    public static bool operator !=(Matrix mat1, Matrix mat2)
    {
        return !(mat1 == mat2);
    }


    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Matrix))
            return false;

        Matrix mat = (Matrix)obj;

        return this == mat;
    }
}
