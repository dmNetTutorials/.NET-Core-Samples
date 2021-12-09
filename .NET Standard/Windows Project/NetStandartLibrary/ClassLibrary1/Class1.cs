using System;
using System.Text.RegularExpressions;

namespace TestNetStandard
{
    public class Validation
    {
        public Validation()
        {

        }

        public static bool Validate(string email, Action Success, Action Fail)
        {
            bool isValidated = false;
            string searchPattern = @"[a-zA-Z0-9_\.-]+\@[a-zA-Z0-9]+\.[a-zA-Z]+";
            if (Regex.IsMatch(email, searchPattern, RegexOptions.Compiled |
                                                RegexOptions.IgnoreCase |
                                                RegexOptions.Singleline))
            {
                Success();
                isValidated = true;
            }
            else
            {
                Fail();
                isValidated = false;
            }

            return isValidated;
        }

    }
}
