using LetsMovie.Infra;
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
                     GeneralMenus.Welcome, 1, 4);
                var regitrationMovie = new RegistrationMovie();

                switch (answerOption)
                {
                    case 1:
                        GetOptionVideo.OptionsVideo();
                        break;
                    case 2:
                        new Consult();
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
