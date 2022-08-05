using LetsMovie.Domain;
using LetsMovie.Infra;
using LetsMovie.Presentation.Interface;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public class RegistrationDocumentary : IRegistrationVideo
    {

        public void Registration()
        {
            string answerTitle = ScreenMenuLogic.GetInputString(
                DocumentaryMenus.RegistrationTitle,
                Validation.ValidateString,
                Messages.ErrorGeneric);

            EnumCountry answerCountry = GetOptionCountry.OptionsCountry();
            Console.Clear();

            string answerProducer = ScreenMenuLogic.GetInputString(
                DocumentaryMenus.RegistrationProducer,
                Validation.ValidateString,
                Messages.ErrorGeneric);

            new InsertDocumentary(answerTitle, answerCountry.ToString(), answerProducer);

        }

    }
}
