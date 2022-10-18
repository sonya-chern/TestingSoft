using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingSoft.Utils
{
    public static class ValuesRandomGenerator
    {
        private const string rusAlphabet = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЫЭЮЯ";

        public static string GenerateNumbersSequence(int count)
        {
            var random = new Random();
            var list = new List<string>(count);
            list.ForEach(s => s = random.Next(10).ToString());
            return string.Concat(list);
        }

        public static string GenerateLettersSequence(int count)
        {
            var random = new Random();
            return new string(Enumerable.Repeat(rusAlphabet, count)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
