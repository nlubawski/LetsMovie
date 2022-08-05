using LetsMovie.Presentation;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.ProgramFlow
{
    public class GetOptionVideo
    {
        public static void OptionsVideo()
        {
            Console.Clear();
            ScreenMenuLogic.ColorLetsMovie();

            bool control = true;

            while (control)
            {
                Console.Clear();
                control = true;
                int answerOption = ScreenMenuLogic.GetOption(
                     GeneralMenus.RegistrationVideo, 1, 4);
                RegistrationMovie registrationMovie = new RegistrationMovie();
                RegistrationSerie registrationSerie = new RegistrationSerie();
                RegistrationDocumentary registrationDocumentary = new RegistrationDocumentary();

                switch (answerOption)
                {
                    case 1:
                        registrationMovie.Registration();
                        break;
                    case 2:
                        registrationSerie.Registration();
                        break;
                    case 3:
                        registrationDocumentary.Registration();
                        break;
                    case 4:
                        control = false;
                        break;
                }
            }
        }
    }
}
