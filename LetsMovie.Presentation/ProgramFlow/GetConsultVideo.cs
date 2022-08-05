using LetsMovie.Infra;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.ProgramFlow
{
    internal class GetConsultVideo
    {
            public static void ConsultVideo()
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
                            new ConsultMovie();
                            break;
                        case 2:
                            new ConsultSerie();
                            break;
                        case 3:
                            new ConsultDocumentary();
                            break;
                        case 4:
                            control = false;
                            break;
                    }
                }
            }
        }
    }

