namespace task5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("введите математическое выражение типа a+b или a-b:");
            string? str = Console.ReadLine();
            if (str != null)
            {
                char[] operationsArr = { '+', '-' };
                int idex = str.IndexOfAny(operationsArr);
                if (idex == -1)
                {
                    Console.WriteLine("неверное математическое выражение");
                    return;
                }
                int operand1 = Convert.ToInt32(str.Substring(0, idex).Trim());
                int operand2 = Convert.ToInt32(str.Substring(idex + 1).Trim());

                string operation = str.Substring(idex, 1);
                int result = operation switch
                {
                    "+" => operand1 + operand2,
                    "-" => operand1 - operand2,
                    _ => 0
                };

                Console.WriteLine("{0} {1} {2} = {3}", operand1, operation, operand2, result);

            }

        }
        /*
        public static void Main()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            // Generate 10 random numbers and store them in a StringBuilder.
            for (int ctr = 0; ctr <= 9; ctr++)
                sb.Append(rnd.Next().ToString("N5"));

            Console.WriteLine("The original string:");
            Console.WriteLine(sb.ToString());

            // Decrease each number by one.
            for (int ctr = 0; ctr < sb.Length; ctr++)
            {
                if (Char.GetUnicodeCategory(sb[ctr]) == UnicodeCategory.DecimalDigitNumber)
                {
                    int number = (int)Char.GetNumericValue(sb[ctr]);
                    number--;
                    if (number < 0) number = 9;

                    sb[ctr] = number.ToString()[0];
                }
            }
            Console.WriteLine("\nThe new string:");
            Console.WriteLine(sb.ToString());
        }*/
    }
}