using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class ScreenMenuLogic
    {
        public static void ColorLetsMovie()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static string ShowMessage(string screen, string errorMessage = "", bool isSecret = false, bool toUpper = false)
        {
            var response = string.Empty;
            Console.Clear();
            Console.WriteLine(screen);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                var defaultBackgroundColor = Console.BackgroundColor;
                var defaultForegroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(errorMessage);
                ColorLetsMovie();

            }

            response = Console.ReadLine().Trim();

            if (toUpper)
                response = response.ToUpper();

            return response;
        }

        public static int GetOption(string screen,
            int initialMenu,
            int endMenu)
        {
            string option;
            int number;
            var messages = string.Empty;

            while (!int.TryParse(ShowMessage(screen, messages), out number) ||
            !(number >= initialMenu && number <= endMenu))
                messages = "Opção Inválida";

            return number;

        }
    }
}
