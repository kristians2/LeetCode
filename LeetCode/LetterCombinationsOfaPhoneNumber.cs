using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LetterCombinationsOfaPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> list = new List<string>();

            string[] mappings = new string[] {
                "",
                "",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz",
            };

            char[] d = digits.ToCharArray();

            BuildString(mappings, list, d, 0, "");

            return list;
        }

        public void BuildString(string[] mappings, List<string> list, char[] digits, int depth, string str)
        {
           if (depth == digits.Length)
           {
                list.Add(str);
                return;
           }

            char[] current = mappings[(int) Char.GetNumericValue(digits[depth])].ToCharArray();
            
            for (int i = 0; i < current.Length; i++)
            {
                BuildString(mappings, list, digits, depth + 1, str + current[i]);
            }
        }
    }
}
