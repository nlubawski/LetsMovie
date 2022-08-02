using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.ProgramFlow
{
    public static class OptionsMenu
    {



        public static void MainMenu()
        {

            Console.Clear();
            ScreenMenuLogic.ColorLetsMovie();

            bool control = true;

            while (control)
            {
                Console.Clear();
                control = true;
                int answerOption = ScreenMenuLogic.GetOption(
                     GeneralMenus.GeneralMenu, 1, 4);

                switch (answerOption)
                {
                    case 1:
                        Console.ReadKey();
                        break;
                    case 2:

                        Console.ReadKey();
                        break;
                    case 3:

                        Console.ReadKey();
                        break;
                    case 4:
                        control = false;
                        break;
                }

            }
        }
    }
}
