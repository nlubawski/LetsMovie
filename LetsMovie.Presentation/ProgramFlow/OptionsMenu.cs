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
                     GeneralMenus.Welcome, 1, 5);
                var regitrationMovie = new RegistrationMovie();

                switch (answerOption)
                {
                    case 1:
                        GetOptionVideo.OptionsVideo();
                        break;
                    case 2:
                        GetConsultVideo.ConsultVideo();
                        break;
                    case 3:
                        new Update();
                        break;
                    case 4:
                        GetDeleteVideo.DeleteVideo();
                        break;                      
                    case 5:
                        control = false;
                        break;
                }

            }
        }
    }
}
