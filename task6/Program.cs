using System.Text;

namespace task6
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для редактирования:");
            string? text = Console.ReadLine();  // "today is a good day for walking. i will try to walk near the sea.    i will surelly succeed in my plan and I will even get some suntan   ";
            if (string.IsNullOrEmpty(text))
                Console.WriteLine("Вы не ввели строку.");
            else
            {
                text = text.Trim();
                int indStart = 0, indEnd = 0;

                StringBuilder sb = new StringBuilder(text.Length + 1);


                do
                {
                    indEnd = text.IndexOf(".", indStart);
                    if (indEnd == 0)
                    {
                        text = text.Substring(indStart + 1).Trim();     // если первая точка
                        continue;
                    }

                    if (text.Length > 0)
                    {

                        sb.Append(text.Substring(indStart).Trim().Substring(indStart, 1).ToUpper());     // добавить первую букву текста

                        if (indEnd != -1)
                        {
                            ++indStart;
                            sb.Append(text.Substring(indStart, indEnd - indStart));

                            indStart = 0;
                            text = text.Substring(indEnd + 1).Trim();
                        }
                        else
                        {
                            indStart = text.LastIndexOf(".") + 1; ;
                            sb.Append(text.Substring(indStart).Trim().Substring(1));
                        }
                        sb.Append(". ");
                    }
                } while (indEnd != -1);

                Console.WriteLine(sb.ToString());
            }

        }
    }
}