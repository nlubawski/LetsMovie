using LetsMovie.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class Validation
    {
        public const int MaxSizeTitle = 100;
        public static bool ValidateString(string obj)
        {
            bool validate = false;

            if ((string.IsNullOrWhiteSpace(obj)))
                validate = false;
            else if (!(obj.Length <= 100))
                validate = false;
            else
            {
                validate = true;
            }

            return validate;

        }

    }
}
