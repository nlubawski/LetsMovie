using LetsMovie.Infra;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.ProgramFlow
{
    internal class GetDeleteVideo
    {
            public static void DeleteVideo()
            {
                Console.Clear();
                ScreenMenuLogic.ColorLetsMovie();

                bool control = true;

                while (control)
                {
                    Console.Clear();
                    control = true;
                    int answerOption = ScreenMenuLogic.GetOption(
                         GeneralMenus.DeleteMenu, 1, 4);

                    switch (answerOption)
                    {
                        case 1:
                            new DeleteMovie();
                            break;
                        case 2:
                            new DeleteSerie();
                            break;
                        case 3:
                            new DeleteDocumentary(); 
                            break;
                        case 4:
                            control = false;
                            break;
                    }
                }
            }
        
    }
}
