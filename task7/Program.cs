namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep";
            string changedText = text.Replace("die", "***");
            Console.WriteLine("Оригинальный текст\n{0}:\n\n", text);
            Console.WriteLine("Текст с замененным запрещенным словом\n{0}:\n\n", changedText);



            string prohibitedWord = "die";
            int count = 0;
            int index = text.IndexOf(prohibitedWord);
            while (index != -1)
            {
                ++count;
                index = text.IndexOf(prohibitedWord, index + prohibitedWord.Length);
            }

            Console.WriteLine("\nВ тексте произведено {0} замен.", count);

        }
    }
}