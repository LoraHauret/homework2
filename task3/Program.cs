namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalText = "Je Veux (ZAZ)\nDonnez moi un suite au Ritz, je n'en veux pas!\nDes bijoux de chez CHANEL, je n'en veux pas!\nDonnez moi une limousine, j'en ferais quoi? Papalapapapala\\nOffrez moi du personnel, j'en ferais quoi?\nUn manoir a Neuchâtel, ce n'est pas pour moi.\nOffrez moi la Tour Eiffel, j'en ferais quoi? Papalapapapala\n[Refrain:]\nJe veux d'l'amour, d'la joie, de la bonne humeur,\nCe n'est pas votre argent qui f'ra mon bonheur,\nMoi j'veux crever la main sur le coeur papalapapapala\nAllons ensemble, découvrir ma liberté,\nOubliez donc tous vos clichés,\nBienvenue dans ma réalité.";
            //string originalText = "Je Veux (оригинал ZAZ)";
            int key = 3;
            Console.WriteLine("Оригинальный текст:\n {0}", originalText);
            Console.WriteLine("\n\n");

            char[] encryptedText = originalText.ToCharArray();
            char[] decryptedText = new char[encryptedText.Length];

            for (int i = 0; i < encryptedText.Length; i++)
            {
                encryptedText[i] = (char)((int)encryptedText[i] + key);
            }

            Console.WriteLine("Зашифрованный текст:");
            Console.WriteLine(encryptedText);
            Console.WriteLine("\n\n");

            for (int i = 0; i < encryptedText.Length; i++)
            {
                decryptedText[i] = (char)((int)encryptedText[i] - key);
            }
            Console.WriteLine("Расшифрованный текст:");
            Console.WriteLine(decryptedText);
        }
    }
}