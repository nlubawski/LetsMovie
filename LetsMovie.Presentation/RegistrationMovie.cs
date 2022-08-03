﻿using LetsMovie.Domain;
using LetsMovie.Infra;
using LetsMovie.Presentation.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public class RegistrationMovie
    {
        public void Registration()
        {

            //Console.WriteLine(MoviesMenus.RegistrationTitle);
            //string answerTitle = Console.ReadLine();
            //Validation.ValidateString(answerTitle, Validation.MaxSizeTitle);
            string answerTitle = ScreenMenuLogic.GetInput(
                MoviesMenus.RegistrationTitle,
                Validation.ValidateString,
                Messages.ErrorNull);

            EnumGender answerGender = GetOptionsGender.OptionsGender();
            Console.Clear();

            Console.WriteLine(MoviesMenus.RegistrationDate);
            var answerDate = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(PrincipalActorMenu.RegistrationActor);
            var answerPrincipalActor = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(Actmenu.RegistrationAct);
            var answerRole = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(Messages.Registration);
            Console.ReadKey();

            new Insert(answerTitle, answerGender.ToString(), Convert.ToDateTime(answerDate), answerPrincipalActor, answerRole);
            Console.ReadKey();

















        }
    }
}
