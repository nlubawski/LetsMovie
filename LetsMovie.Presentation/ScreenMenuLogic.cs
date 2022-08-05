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
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static string CaptureValueUserString(string screen, string errorMessage = "", bool isNumber = false, bool toUpper = false)
        {
            var response = string.Empty;
            Console.Clear();
            Console.WriteLine(screen);

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                var defaultBackgroundColor = Console.BackgroundColor;
                var defaultForegroundColor = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n {errorMessage}");
                ColorLetsMovie();

            }

            response = Console.ReadLine().Trim();

            if (toUpper)
                response = response.ToUpper();

            return response;
        }


        public static int CaptureValueUserInt(string screen, string errorMessage = "")
        {
            int number;
            var response = "backing field";

            do
            {
                response = string.Empty;
                Console.Clear();
                Console.WriteLine(screen);

                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    var defaultBackgroundColor = Console.BackgroundColor;
                    var defaultForegroundColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n{errorMessage}");
                    ColorLetsMovie();
                }

                response = Console.ReadLine().Trim();

            } while (!int.TryParse(response, out number));

            return number;
        }



        public static int GetOption(string screen,
            int initialMenu,
            int endMenu)
        {
            string option;
            int number;
            var messages = string.Empty;

            while (!int.TryParse(CaptureValueUserString(screen, messages), out number) ||
            !(number >= initialMenu && number <= endMenu))
                messages = "Opção Inválida";

            return number;

        }

        public static string GetInputString(
            string screen,
            Predicate<string> predicate,
            string customMessage = null)
        {
            string response;
            var messages = string.Empty;

            while (!predicate.Invoke(response = CaptureValueUserString(screen, messages)))
                messages = customMessage;

            return response;
        }

        public static int GetInputInt(
        string screen,
        Predicate<int> predicate,
        string customMessage = null)
        {
            int number;
            var messages = string.Empty;
            messages = string.Empty;
            do
            {
                number = CaptureValueUserInt(screen, messages);
                messages = customMessage;

            } while (!predicate.Invoke(number));            

            return number;
        }

        public static Dictionary<int, string> GetInputDictionary(
        string customMessageInt,
        string customMessageString,
        string screen,
        int NumberOfSeasonsEpisode,
        Predicate<int> predicateInt,
        Predicate<string> predicateString
        )
        
        {
            Dictionary<int, string> answer = new Dictionary<int, string>();
            var messages = string.Empty;  
            var response = string.Empty;
            int number;

            for (int i = 0; i < NumberOfSeasonsEpisode; i++)
            {
                do
                {
                    number = CaptureValueUserInt(customMessageInt, messages);
                    messages = screen;

                } while (!predicateInt.Invoke(number));

                messages = string.Empty;

                while (!predicateString.Invoke(response = CaptureValueUserString(customMessageString, messages)))
                    messages = screen;

                answer.Add(number, response);

                Console.WriteLine();
                Console.WriteLine(SeriesMenus.RegistrationEpisodeContinue);
                string control = Console.ReadLine();

                if (control == "fim")
                    break;

            }
            return answer;
        }

    }
}
