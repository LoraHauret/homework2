namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 2, 0, -1 }, { 0, -2, 2 } };
            int[,] matrix2 = { { 4, 1, 0 }, { 3, 2, 1 }, { 0, 1, 0 } };
            int[,] matrix3 = { { 6, 7, -3 }, { 5, -1, 3 } };

            Console.WriteLine("Матрица 1:");
            Print(matrix1);
            Console.WriteLine("Матрица 2:");
            Print(matrix2);
            Console.WriteLine("Матрица 3:");
            Print(matrix3);

            int[,] matrix4 = MultiplyNumber(matrix2, 3);
            Console.WriteLine("Mатрица 2 после умножение на {0}", 3);
            Print(matrix4);

            matrix4 = SumMatrix(matrix1, matrix3);
            Console.WriteLine("Сумма матрицы 1 и 3");
            Print(matrix4);

            matrix4 = MultyplyMatrix(matrix1, matrix2);
            Console.WriteLine("Перемноженные матрицы 1 и 2");
            Print(matrix4);
        }

        static int[,]? MultiplyNumber(int[,] arr, int number)
        {
            if (arr != null)
            {
                int row = arr.GetUpperBound(0) + 1;
                int col = arr.GetUpperBound(1) + 1;
                int[,] resultArr = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        resultArr[i, j] = arr[i, j] * number;
                    }
                }
                return resultArr;
            }
            return null;
        }
        static int[,]? SumMatrix(int[,] matrix1, int[,] matrix2)
        {
            int row = matrix1.GetUpperBound(0);
            int col = matrix1.GetUpperBound(1);
            if (matrix2.GetUpperBound(0) != row || matrix2.GetUpperBound(1) != col)
                return null;
            int[,] matrix3 = new int[++row, ++col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }
        static int[,]? MultyplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int col1 = matrix1.GetUpperBound(1) + 1;
            int row2 = matrix2.GetUpperBound(0) + 1;
            if (matrix1 != null && matrix2 != null && col1 == row2)
            {
                int row1 = matrix1.GetUpperBound(0) + 1;
                int col2 = matrix2.GetUpperBound(1) + 1;
                int[,] matrix3 = new int[row1, col1];
                /*
                 Произведением двух матриц А и В называется матрица С, элемент которой, 
                находящийся на пересечении i-й строки и j-го столбца, 
                равен сумме произведений элементов i-й строки матрицы А 
                на соответствующие (по порядку) элементы j-го столбца матрицы В.
                 */
                int res = 0;
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        for (int k = 0; k < col2; k++)
                        {
                            res += matrix1[i, k] * matrix2[k, j];
                        }
                        matrix3[i, j] = res;
                        res = 0;
                    }
                }
                return matrix3;

            }
            return null;
        }

        static void Print(int[,] matrix)
        {
            if (matrix != null)
            {
                int row = matrix.GetUpperBound(0) + 1;
                int col = matrix.GetUpperBound(1) + 1;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("{0}\t", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
