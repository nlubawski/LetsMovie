using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class DocumentaryMenus
    {
        public static void RegistrationTitle()
        {
            Console.WriteLine("##   Cadastro de Documentário   ##");
            Console.WriteLine("Digite o título do filme:");
        }

        public static void RegistrationCountry()
        {
            Console.WriteLine("Digite onde foi produzido o documentário:");
            Console.WriteLine("1. Brasil");
            Console.WriteLine("2. Estados Unidos");
            Console.WriteLine("3. Países LatinoAmericanos");
            Console.WriteLine("4. Países Europeus");
            Console.WriteLine("5. Países Asiáticos");
            Console.WriteLine("6. Países Africanos");
        }

        public static void SearchDocumentary()
        {
            Console.WriteLine("Digite o nome do documentário que deseja assistir:");
        }
    }
}
