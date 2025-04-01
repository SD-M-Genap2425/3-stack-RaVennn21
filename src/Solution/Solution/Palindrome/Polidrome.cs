using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string Cek)
        {
            Stack<char> stack = new Stack<char>();
            string normalCek = new string(Cek.ToLower().Where(c => char.IsLetter(c)).ToArray());
            char[] l1 = normalCek.ToCharArray();

            for (int i = 0; i < l1.Length; i++)
            {
                if (i < (l1.Length / 2))
                {
                    stack.Push(l1[i]);
                }
                else if (i >= (l1.Length + 1) / 2)
                {
                    if (stack.Pop() != l1[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
