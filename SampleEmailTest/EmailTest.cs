using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace SampleEmailTest
{
    class EmailTest
    {
        public string regexEmail = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool RegexEmailTest(string email)
        {
            return Regex.IsMatch(email, regexEmail);
        }
    }
}
