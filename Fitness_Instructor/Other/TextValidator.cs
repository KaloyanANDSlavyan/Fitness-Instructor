using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Fitness_Instructor
{
    class TextValidator
    {
        String strRegex { get; set; }
        String data { get; set; }

        public TextValidator(String strRegex, String data)
        {
            this.strRegex = strRegex;
            this.data = data;
        }

        public bool regexValidator()     // @"(^[А-ЯA-Z][а-яa-z]{2,}$)"
        {

            Regex re = new Regex(strRegex);
            if (re.IsMatch(data))
                return (true);
            else
                return (false);
        }
    }
}
