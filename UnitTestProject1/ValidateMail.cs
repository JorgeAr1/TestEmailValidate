using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class ValidateMail
    {
        public bool validateMail(String email)
        {
            String expresionRegular = @"^[a-zA-Z0-9_\-\.]{2,}@[a-zA-Z0-9_\-\.]{2,}$";
            Regex regex = new Regex(expresionRegular);
            return regex.IsMatch(email);
        }
    }
}
