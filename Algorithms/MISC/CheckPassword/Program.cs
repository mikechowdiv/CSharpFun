using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your password.  The password should have: ");
            Console.WriteLine("min 6 char and max 12 char. No two similar chars consecutively. 1 lower case. 1 upper case. 1 special char. No white space ");
            string pw = Console.ReadLine();
            Console.WriteLine(PasswordChecker.CheckPassword(pw));
        }
    }

    //Write password checker method - must contain min 6 char and max 12 char,
    //No two similar chars consecutively, 1 lower case, 1 upper case, 1 special char, no white space 
    public static class PasswordChecker
    {
        public static bool CheckPassword(string pass)
        {
            //min 6 chars, max 12 chars
            if (pass.Length < 6 || pass.Length > 12)
                return false;

            //No white space
            if (pass.Contains(" "))
                return false;

            //At least 1 upper case letter
            if (!pass.Any(char.IsUpper))
                return false;

            //At least 1 lower case letter
            if (!pass.Any(char.IsLower))
                return false;

            //No two similar chars consecutively
            for (int i = 0; i < pass.Length - 1; i++)
            {
                if (pass[i] == pass[i + 1])
                    return false;
            }

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (pass.Contains(c))
                    return true;
            }
            return false;
        }
    }
}
