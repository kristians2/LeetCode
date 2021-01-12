using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n) {
            List<string> list = new List<string>();
            int opening = n;
            int closing = n;

            Generate(list, opening - 1, closing, "(");

            return list;
        }

        private void Generate(List<string> list, int opening, int closing, string str)
        {
            if (opening <= 0 && closing <= 0)
            {
                list.Add(str);
                return;
            }

            if (closing > 0)
            {
                Generate(list, opening, closing - 1, str + ")");
            }

            if (opening > 0)
            {
                if (closing >= opening)
                {
                    Generate(list, opening - 1, closing, str + "(");
                }
            }
        }
    }
}
