using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsMovie.Domain;

namespace LetsMovie.Presentation
{
    public static class GetOptionsGender
    {
            public  static EnumGender OptionsGender()
            {

                Console.Clear();
                ScreenMenuLogic.ColorLetsMovie();

                bool control = true;
                EnumGender option = EnumGender.Action;
            while (control)
            {
                Console.Clear();
                control = true;
                int answerOption = ScreenMenuLogic.GetOption(
                     MoviesMenus.RegistrationGender, 1, 7);
                var regitrationMovie = new RegistrationMovie();

                switch (answerOption)
                {
                    case 1:
                        option = EnumGender.Action;
                        break;
                    case 2:
                        option = EnumGender.Adventure;
                        break;
                    case 3:
                        option = EnumGender.Heroes;
                        break;
                    case 4:
                        option = EnumGender.Comedy;
                        break;
                    case 5:
                        option = EnumGender.Romantic_Comedy;
                        break;
                    case 6:
                        option = EnumGender.Romance;
                        break;
                    case 7:
                        option = EnumGender.Horror;
                        break;
                }
                control = false;
            }
            return option;
            } 
     }
}
