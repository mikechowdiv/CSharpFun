using System;

namespace String1
{
    public class Class1
    {
        /*
         * Given 2 strings, a and b, return a string of the form short+long+short, 
         * with the shorter string on the outside and the longer string on the inside. 
         * The strings will not be the same length, but they may be empty (length 0). 

LongInMiddle("Hello", "hi") -> "hiHellohi"
LongInMiddle("hi", "Hello") -> "hiHellohi"
LongInMiddle("aaa", "b") -> "baaab"
         */
        public string LongInMiddle(string a, string b)
        {
            //return a.Length > b.Length ? b + a + b : a + b + a;
            if (a.Length > b.Length) return b + a + b;
            else
            {
                return a + b + a;
            }
        }

        //------------------------------------------------------------------------------------------------

        /*
         * Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. The string length will be at least 2. 

Rotateleft2("Hello") -> "lloHe"
Rotateleft2("java") -> "vaja"
Rotateleft2("Hi") -> "Hi"
         */

        public string RotateLeft2(string a)
        {
            //return a.Remove(0, 2) + a.Substring(0, 2);
            return a.Remove(0, 2) + a.Substring(0, 2);
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
         * The string length will be at least 2. 

RotateRight2("Hello") -> "loHel"
RotateRight2("java") -> "vaja"
RotateRight2("Hi") -> "Hi"
         */
        public string RotateRight2(string str)
        {
            return str.Substring(str.Length - 2) + str.Remove(str.Length - 2);
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string, return a string length 1 from its front, unless front is false, in which case return a string length 1 from its back. 
         * The string will be non-empty. 

TakeOne("Hello", true) -> "H"
TakeOne("Hello", false) -> "o"
TakeOne("oh", true) -> "o"
         */
        public string TakeOne(string str, bool fromFront)
        {
            // return fromFront ? str.Substring(0, 1) : str.Substring(str.Length - 1);
            if (fromFront == true) return str.Substring(0, 1);
            else return str.Substring(str.Length - 1);
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string of even length, return a string made of the middle two chars, 
         * so the string "string" yields "ri". The string length will be at least 2. 

MiddleTwo("string") -> "ri"
MiddleTwo("code") -> "od"
MiddleTwo("Practice") -> "ct"
         */
        public string MiddleTwo(string str)
        {
            return str.Substring(str.Length / 2 - 1, 2);
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string, return true if it ends in "ly". 

EndsWithLy("oddly") -> true
EndsWithLy("y") -> false
EndsWithLy("oddy") -> false
         */
        public bool EndsWithly(string str)
        {
            return str.Length >= 2 && str.Substring(str.Length - 2) == "ly";
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string and an int n, return a string made of the first and last n chars from the string. The string length will be at least n. 

FrontAndBack("Hello", 2) -> "Helo"
FrontAndBack("Chocolate", 3) -> "Choate"
FrontAndBack("Chocolate", 1) -> "Ce"

         */
        public string FrontAndBack(string str, int n)
        {
            return str.Substring(0, n) + str.Substring(str.Length - n, n);
        }

        //------------------------------------------------------------------------------------------------
        /*
             * Given a string and an index, return a string length 2 starting at the given index. 
             * If the index is too big or too small to define a string length 2, use the first 2 chars. 
             * The string length will be at least 2. 

TakeTwoFromPosition("java", 0) -> "ja"
TakeTwoFromPosition("java", 2) -> "va"
TakeTwoFromPosition("java", 3) -> "ja"
             */
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n + 2 > str.Length) return str.Substring(0, 2);
            else
            {
                return str.Substring(n, 2);
            }
        }

        //------------------------------------------------------------------------------------------------

        /*
         * Given a string, return true if "bad" appears starting at index 0 or 1 in the string, 
         * such as with "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0.

HasBad("badxx") -> true
HasBad("xbadxx") -> true
HasBad("xxbadxx") -> false

         */

        public bool HasBad(string str)
        {
            if(str.Length >= 3)
            {
                string str0 = str.Substring(0, 3);
                string str1 = str.Substring(1, 3);
                if(str0 == "bad" || str1 == "bad")
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string, return a string length 2 made of its first 2 chars. 
         * If the string length is less than 2, use '@' for the missing chars. 

AtFirst("hello") -> "he"
AtFirst("hi") -> "hi"
AtFirst("h") -> "h@"
         */

        public string AtFirst(string str)
        {
            if (str.Length >= 2) return str.Substring(0, 2);
            else if(str.Length < 2 && str.Length > 0)
            {
                return str.Substring(0, 1) + "@";
            }
            else
            {
                return "@@";
            }
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, 
         * so "yo" and "java" yields "ya". If either string is length 0, use '@' for its missing char. 

LastChars("last", "chars") -> "ls"
LastChars("yo", "mama") -> "ya"
LastChars("hi", "") -> "h@"
         */

        public string LastChars(string a, string b)
        {
            if (b.Length == 0 && a.Length == 0) return "@@";
            else if (a.Length == 0) return "@" + b.Substring(b.Length - 1);
            else if (b.Length == 0) return a.Substring(0, 1) + "@";
            else return a.Substring(0, 1) + b.Substring(b.Length - 1);
        }


        //------------------------------------------------------------------------------------------------
        /*
         * Given two strings, append them together (known as "concatenation") and return the result. 
         * However, if the concatenation creates a double-char, then omit one of the chars, so "abc" and "cat" yields "abcat". 

ConCat("abc", "cat") -> "abcat"
ConCat("dog", "cat") -> "dogcat"
ConCat("abc", "") -> "abc"
         */
         public string ConCat(string a, string b)
        {
            if (a.Length == 0) return b;
            else if (b.Length == 0) return a;
            else if (a.Length == 0 && b.Length == 0) return "";
            else if ((a.Substring(a.Length - 1)) == (b.Substring(0, 1)))
            {
                return a + b.Substring(1, (b.Length - 1));
            }
            else return a + b;
        }


        //------------------------------------------------------------------------------------------------
        /*
         * Given a string of any length, return a new string where the last 2 chars, 
         * if present, are swapped, so "coding" yields "codign". 

SwapLast("coding") -> "codign"
SwapLast("cat") -> "cta"
SwapLast("ab") -> "ba"
         */

        public string SwapLast(string str)
        {
            if (str.Length < 2) return str;
            return str.Remove(str.Length - 2, 1) + str.Substring(str.Length - 2, 1);
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given a string, return true if the first 2 chars in the string also appear at the end of the string, such as with "edited". 

FrontAgain("edited") -> true
FrontAgain("edit") -> false
FrontAgain("ed") -> true
         */

        public bool FrontAgain(string str)
        {
            if (str.Length < 2) return false;
            return str.Substring(0, 2) == str.Substring(str.Length - 2, 2);
        }

        //------------------------------------------------------------------------------------------------
        /*
         * Given two strings, append them together (known as "concatenation") and return the result. 
         * However, if the strings are different lengths, omit chars from the longer string so it is the same length
         *  as the shorter string. So "Hello" and "Hi" yield "loHi". The strings may be any length. 

MinCat("Hello", "Hi") -> "loHi"
MinCat("Hello", "java") -> "ellojava"
MinCat("java", "Hello") -> "javaello"
         */

        public string MinCat(string a, string b)
        {
            int x = Math.Min(a.Length, b.Length);
            return a.Substring(a.Length - x) + b.Substring(b.Length - x);
        }
    }
}
