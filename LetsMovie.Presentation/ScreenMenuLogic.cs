using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class ScreenMenuLogic
    {
        public static int GetOption(int initialMenu, int endMenu)
        {
            bool valid = false;
            string option;
            int number;
            do
            {
                if(valid)
                    Console.WriteLine("Opção inválida.");

                GeneralMenus.WelcomeMessage();
                GeneralMenus.PrincipalMenu();

                option = Console.ReadLine();
                valid = true;

            } while (!int.TryParse(option, out number) ||
                    !(number >= initialMenu && number <= endMenu));

            return number;
        }
    }
}
