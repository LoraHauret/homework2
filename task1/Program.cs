namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * double[] A = new double[5];
            double[,] B = new double[3,4];
            for (int i  = 0; i < A.Length; i++) 
            {
                Console.Write("Введите число; ");
                A[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            Array.Sort(A);

            Random rand = new Random();

            for (int i = 0;i<3; i++) 
            {
                for (int j = 0; j < 4; j++) 
                {
                    B[i, j] = Math.Round(rand.NextDouble() * 10, 1);
                }
            }
            
            */

            double[] A = { 1, 2, 3, 6, 4 };
            double[,] B = { { 7, 7, 6 }, { 3, 4, 7 } };

            Console.WriteLine("Массив А:");
            Print(A);
            Console.WriteLine();
            Console.WriteLine("Массив B:");
            Print(B);
            Console.WriteLine();

            MinMax(A, out double aMin, out double aMax);
            Console.WriteLine("Минимальный элемент массива А: {0}\nМаксимальный элемент массива А: {1}", aMin, aMax);

            MinMax(B, out double bMin, out double bMax);
            Console.WriteLine("Минимальный элемент массива B: {0}\nМаксимальный элемент массива B: {1}", bMin, bMax);


            CommonMin(A, B, out double min);
            Console.WriteLine("Общий минимальный элемент массивов А и В: {0}",min);

            CommonMax(A, B, out double max);
            Console.WriteLine("Общий максимальный элемент массивов А и В: {0}", max);

            double sumA = Sum(A);
            Console.WriteLine("Сумма элементов массива А: {0}", sumA);
            double sumB = Sum(null, B);
            Console.WriteLine("Сумма элементов массива B: {0}", sumB);

            double sumEvenA = SumEven(A);
            Console.WriteLine("суммa четных элементов массива А: {0}", sumEvenA);
            double sumOddColumns = SumOddCol(B);
            Console.WriteLine("суммa нечетных столбцов массива В: {0}", sumOddColumns);

        }

        static void Print(double[] arr)
        {
            foreach (double d in arr)
                Console.Write("{0}\t", d);
        }
        static void Print(double[,] arr)
        {
            int row = arr.GetUpperBound(0) + 1;
            int col = arr.GetUpperBound(1) + 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write("{0}\t", arr[i, j]);
                Console.WriteLine();

            }
        }

        static void MinMax(double[] arr, out double min, out double max)
        {
            min = max = arr[0];
            foreach (double d in arr)
            {
                if (d < min)
                {
                    min = d;
                    continue;
                }

                if (d > max)
                    max = d;
            }

        }
        static void MinMax(double[,] arr, out double min, out double max)
        {
            min = max = arr[0, 0];
            foreach (double d in arr)
            {
                if (d < min)
                {
                    min = d;
                    continue;
                }

                if (d > max)
                    max = d;
            }

        }

        static void CommonMin(double[] arr1, double[,] arr2, out double min)
        {
            min = -1;

            if (arr1 != null && arr2 != null)
            {
                int row = arr2.GetUpperBound(0) + 1;
                int col = arr2.GetUpperBound(1) + 1;

                Array.Sort(arr1);

                foreach (double elA in arr1)
                {
                    foreach (double elB in arr2)
                    {
                        if (elA == elB)
                        {
                            min = elA;
                            return;
                        }
                    }
                }
            }
        }
        static void CommonMax(double[] arr1, double[,] arr2, out double max)
        {
            max = -1;

            if (arr1 != null && arr2 != null)
            {
                int row = arr2.GetUpperBound(0) + 1;
                int col = arr2.GetUpperBound(1) + 1;

                Array.Sort(arr1);

                Array.Reverse(arr1);
                foreach (double elA in arr1)
                {
                    foreach (double elB in arr2)
                        if (elA == elB)
                        {
                            max = elA;
                            return;
                        }
                }
            }
        }

        /*
        static double Sum(double[] arr)
        {
            double ret = 0;
            foreach (double elA in arr)
                ret = inSum(ret, elA);
            return ret;

            double inSum(double a, double b) => (a + b);
        }
        static double Sum(double[,] arr)
        {
            double ret = 0;
            foreach (double elA in arr)
                ret = inSum(ret, elA);
            return ret;

            double inSum(double a, double b) => (a + b);
        }
        */

        static double Sum(double[]? arr1 = null, double[,]? arr2 = null)
        {
            double ret = 0;
            if (arr1 != null)
            {
                foreach (double elA in arr1)
                    ret = inSum(ret, elA);
            }
            else if (arr2 != null)
            {
                foreach (double elA in arr2)
                    ret = inSum(ret, elA);
            }
            return ret;

            double inSum(double a, double b) => (a + b);
        }

        static double Multiply(double[]? arr1 = null, double[,]? arr2 = null)
        {
            double ret = 0;
            if (arr1 != null)
            {
                foreach (double elA in arr1)
                    ret = inMult(ret, elA);
            }
            else if (arr2 != null)
            {
                foreach (double elA in arr2)
                    ret = inMult(ret, elA);
            }
            return ret;

            double inMult(double a, double b) => (a * b);
        }

        static double SumEven(double[] arr)
        {
            double ret = 0;
            foreach (double elA in arr)
                ret += inSumEven(elA);
            return ret;

            double inSumEven(double a) => a % 2 > 0 ? 0 : a;
        }

        static double SumOddCol(double[,] arr)
        {
            double ret = 0;
            if (arr != null)
            {
                int row = arr.GetUpperBound(0) + 1;
                int col = arr.GetUpperBound(1) + 1;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j += 2)
                    {
                        ret += arr[i, j];
                    }
                }
            }
            return ret;
        }
    }
}