using LetsMovie.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Domain
{
    public static class Validation
    {
        public const int MaxSizeTitle = 100;
        public static bool ValidateString(string obj, int size)
        {
            string feedback;
            bool validate = false;

            if (!string.IsNullOrWhiteSpace(obj))
                feedback = Messages.ErrorNull;
            else if (obj.Length > size)
                feedback = Messages.ErrorSize;
            else
            {
                feedback = Messages.RegistrationOk;
                validate = true;
            }

            Console.WriteLine(feedback);
            return validate;

        }

    }
}
