using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.ProgramFlow
{
    public static class OptionsMenu
    {
        public static int Options(int answerOptions)
        {
            switch (answerOptions)
            {
                case 1:
                    GeneralMenus.RegistrationVideo();
                    Console.ReadKey();
                    break;
                case 2:

                    Console.ReadKey();
                    break;
                case 3:

                    Console.ReadKey();
                    break;
                case 4:
                    break;
            }
                    
                    return answerOptions;
        }
    }
}
