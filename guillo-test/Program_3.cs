namespace guillo_test
{
    internal class Program_3
    {
        private static readonly List<char> vowels = new List<char>(['a', 'e', 'i', 'o', 'u']);
        public static int CountMinimumOperations(string password)
        {
            var carry = LettersCounter(password);
            if (carry == 0) return 0;
            var counter = 0;
            var index = 0;
            void Trasform (char[] chars) 
            {
                string transformed = new(chars);
                int calcualtedCarry = LettersCounter(transformed);
                if (calcualtedCarry < carry)
                {
                    carry = calcualtedCarry;
                    password = transformed;
                    counter++;
                }
            }
            foreach (var letter in password)
            {
                char[] chars = password.ToCharArray();
                var code = Convert.ToInt16(letter);
                if (code >= 97)
                {
                    chars[index] = Convert.ToChar(code + 1);
                    Trasform(chars);
                }
                if (code <= 122)
                {
                    chars[index] = Convert.ToChar(code - 1);
                    Trasform(chars);
                }
                if (carry == 0) break;
                index++;
            }
            return counter;
        }
        static private int LettersCounter (string value)
        {
            var vowel = 0;
            var consonant = 0;
            foreach (var letter in value)
            {
                if (vowels.Contains(letter)) vowel++;
                else consonant++;
            }
            return Math.Abs(vowel - consonant);
        }
    }
}
