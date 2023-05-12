using System.Drawing;

namespace task2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 5;
            int[,] arr = new int[SIZE, SIZE];

            Random rnd = new Random();

            for (int i = 0; i < SIZE; i++)
            {

                for (int j = 0; j < SIZE; j++)
                {
                    arr[i, j] = rnd.Next(1, 20);
                }
            }

            for (int i = 0; i < SIZE; i++)
            {

                for (int j = 0; j < SIZE; j++)
                {
                    Console.Write("\t{0}", arr[i, j]);
                }
                Console.WriteLine();
            }

            Point min = new Point(0, 0);
            Point max = new Point(0, 0);

            MinMaxElIndexes(arr, ref min, ref max);

            Console.WriteLine("минимальный элемент в массиве {0}\nмаксимальный элемент в массиве {1}", arr[min.X, min.Y], arr[max.X, max.Y]);

            if ((max.X * SIZE + max.Y) - (min.X * SIZE + min.Y) < 0)
            {                                                                               // in case if element with the greatest value 
                int temp = min.X;                                                           // is positioned before the element with the least value
                min.X = max.X;                                                              // there is no difference whether to sum elements from the min to max
                max.X = temp;                                                               // of from the max to min we can omit the direct sence of min and max variables
                temp = min.Y;                                                               // 
                min.Y = max.Y;
                max.Y = temp;
            }

            int countIter = (max.X * SIZE + max.Y) - (min.X * SIZE + min.Y) + 1;             // the difference between positions of min and max elements = count of iterations

            int sum = 0;
            for (int i = min.X, j = min.Y; i <= max.X; i++)
            {
                for (; j < SIZE && countIter > 0; j++)
                {
                    sum += arr[i, j];
                    --countIter;
                }

                j = 0;
            }

            Console.WriteLine("сумма чисела между минимальным и максимальним элементами (вкулючительно): {0}", sum);
        }

        static void MinMaxElIndexes(int[,] arr, ref Point min, ref Point max)
        {

            if (arr != null)
            {
                int row = arr.GetUpperBound(0) + 1;
                int col = arr.GetUpperBound(1) + 1;

                int minValue, maxValue;
                minValue = maxValue = arr[0, 0];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (arr[i, j] < minValue)
                        {
                            minValue = arr[i, j];
                            min.X = i;
                            min.Y = j;
                        }
                        if (arr[i, j] > maxValue)
                        {
                            maxValue = arr[i, j];
                            max.X = i;
                            max.Y = j;
                        }
                    }
                }

            }
        }
    }
}