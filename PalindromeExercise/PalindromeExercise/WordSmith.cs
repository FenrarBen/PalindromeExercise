using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] chArr = word.ToCharArray();
            Array.Reverse(chArr);

            if (new string(chArr) == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
