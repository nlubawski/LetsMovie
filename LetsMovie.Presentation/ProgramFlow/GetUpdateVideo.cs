using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsMovie.Infra;
using LetsMovie.Presentation.Show;

namespace LetsMovie.Presentation.ProgramFlow
{
    public class GetUpdateVideo
    {
        public static void UpdateVideo()
        {
            Console.Clear();
            ScreenMenuLogic.ColorLetsMovie();

            bool control = true;

            while (control)
            {
                Console.Clear();
                control = true;
                int answerOption = ScreenMenuLogic.GetOption(
                     GeneralMenus.UpdateMenu, 1, 4);

                switch (answerOption)
                {
                    case 1:
                        new UpdateMovie();
                        break;
                    case 2:
                        new UpdateSerie();
                        break;
                    case 3:
                        new UpdateDocumentary();
                        break;
                    case 4:
                        control = false;
                        break;
                }
            }
        }
    }
}
