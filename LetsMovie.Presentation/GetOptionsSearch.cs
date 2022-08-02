using System;
using LetsMovie.Presentation.Show;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public class GetOptionsSearch
    {
        public static void OptionsSearch()
        {
            Console.Clear();
            ScreenMenuLogic.ColorLetsMovie();

            bool control = true;

            while (control)
            {
                Console.Clear();
                control = true;
                int answerOption = ScreenMenuLogic.GetOption(
                     GeneralMenus.SearchMenu, 1, 4);

                switch (answerOption)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        control = false;
                        break;
                }
            }
        }
    }
}