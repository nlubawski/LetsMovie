﻿using LetsMovie.Presentation.Show;
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
                Messages.ErrorNull);               ;
        }
    }
}
