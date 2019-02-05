using System;

namespace orm_january_2019.Util
{
    public class Generate
    {
        public static string GenerateName(int len)
        { 
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;
        }

        public static double GenerateDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max-min) + min;
        }
        
        public static int GenerateInt(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}