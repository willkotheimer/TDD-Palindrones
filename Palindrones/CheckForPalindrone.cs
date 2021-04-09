using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Palindrones
{
    public class CheckForPalindrone
    {
        public bool myPalidroneChecker(string word)
        {
            var wordAsArray = word.ToLower().Replace(" ", "");
            var wordAsArrayReversed = ReverseArray(word.ToLower().Replace(" ", ""));

            if (wordAsArrayReversed == wordAsArray)  return true;

                return false;
        }

        public static string ReverseArray(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return (new string(array));
        }

    }
}
