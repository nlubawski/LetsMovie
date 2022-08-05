using LetsMovie.Domain;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class GetOptionCountry
    {
        public static EnumCountry OptionsCountry()
        {

            Console.Clear();
            ScreenMenuLogic.ColorLetsMovie();

            bool control = true;
            EnumCountry option = EnumCountry.Brazil;
            while (control)
            {
                Console.Clear();
                control = true;
                int answerOption = ScreenMenuLogic.GetOption(
                     DocumentaryMenus.RegistrationCountry, 1, 6);
                var regitrationMovie = new RegistrationMovie();

                switch (answerOption)
                {
                    case 1:
                        option = EnumCountry.Brazil;
                        break;
                    case 2:
                        option = EnumCountry.USA;
                        break;
                    case 3:
                        option = EnumCountry.LatinAmerica;
                        break;
                    case 4:
                        option = EnumCountry.European;
                        break;
                    case 5:
                        option = EnumCountry.Asiatic;
                        break;
                    case 6:
                        option = EnumCountry.African;
                        break;
                }
                control = false;
            }
            return option;
        }
    }
}
