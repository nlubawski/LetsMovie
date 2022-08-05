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
    public class RegistrationMovie: IRegistrationVideo
    {
        public void Registration()
        {

            string answerTitle = ScreenMenuLogic.GetInputString(
                MoviesMenus.RegistrationTitle,
                Validation.ValidateString,
                Messages.ErrorGeneric);

            EnumGender answerGender = GetOptionsGender.OptionsGender();
            Console.Clear();

            Console.WriteLine(MoviesMenus.RegistrationDate);
            var answerDate = Console.ReadLine();
            Console.Clear();


            string answerPrincipalActor = ScreenMenuLogic.GetInputString(
            PrincipalActorMenu.RegistrationActor,
            Validation.ValidateString,
            Messages.ErrorGeneric);


            string answerRole = ScreenMenuLogic.GetInputString(
            Actmenu.RegistrationAct,
            Validation.ValidateString,
            Messages.ErrorGeneric);


            Console.WriteLine(Messages.Registration);
            Console.ReadKey();

            new InsertMovie(answerTitle, answerGender.ToString(), Convert.ToDateTime(answerDate), answerPrincipalActor, answerRole);

        }
    }
}
