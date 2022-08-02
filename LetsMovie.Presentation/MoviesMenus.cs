using LetsMovie.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public class MoviesMenus : IMoviesMenu
    {
        public void RegistrationTitle()
        {
            Console.WriteLine("##   Cadastro de Filme   ##");
            Console.WriteLine("Digite o título do filme:");
        }

        public void RegistrationGender()
        {
            Console.WriteLine("Digite o gênero:");
            Console.WriteLine("1. Ação");
            Console.WriteLine("2. Aventura");
            Console.WriteLine("3. Heróis");
            Console.WriteLine("4. Comédia");
            Console.WriteLine("5. Comédia Romântica");
            Console.WriteLine("6. Romance");
            Console.WriteLine("7. Terror");
        }

        public void RegistrationDate()
        {
            Console.WriteLine("Digite a data de lançamento no formato (DD/MM/AAAA):");
        }

        public void SearchMovie()
        {
            Console.WriteLine("Digite o nome do filme que deseja assistir:");
        }
    }
}
