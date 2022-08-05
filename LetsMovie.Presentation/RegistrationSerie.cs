using LetsMovie.Infra;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public class RegistrationSerie
    {
        public void Registration()
        {
            string answerTitle = ScreenMenuLogic.GetInputString(
                SeriesMenus.RegistrationTitle,
                Validation.ValidateString,
                Messages.ErrorGeneric
                );

            int answerSeason = ScreenMenuLogic.GetInputInt(
                SeriesMenus.RegistrationSeason,
                Validation.ValidateInt,
                Messages.ErrorGeneric
                );


            int answerNumberOfEpisode = ScreenMenuLogic.GetInputInt(
                SeriesMenus.RegistrationNumberEpisodes,
                Validation.ValidateInt,
                Messages.ErrorGeneric
                );

            Dictionary<int, string> episodes = ScreenMenuLogic.GetInputDictionary(
                SeriesMenus.RegistrationNumberEpisode,
                SeriesMenus.RegistrationNameEpisode,
                SeriesMenus.RegistrationEpisodeContinue,
                answerNumberOfEpisode,
                Validation.ValidateInt,
                Validation.ValidateString
                );

            new InsertSerie(answerTitle, answerSeason, answerNumberOfEpisode, episodes);
            Console.ReadKey();

        }
    }
}
