using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class GeneralMenus
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Bem-vindo ao Let's Movie.");
            Console.WriteLine("Seu streaming de filmes, séries e documentários.");
        }

        public static void PrincipalMenu()
        {
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1. Cadastrar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Ver catálogo");
            Console.WriteLine("4. Sair");
        }

        public static void RegistrationVideo()
        {
            Console.WriteLine("##   Cadastro    ##");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1. Cadastrar Filme");
            Console.WriteLine("2. Cadastrar Série");
            Console.WriteLine("3. Cadastrar Documentário");
            Console.WriteLine("4. Retornar ao menu principal");
        }

        public static void SearchMenu()
        {
            Console.WriteLine("##   Buscar  ##");
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1. Buscar Filme");
            Console.WriteLine("2. Buscar Série");
            Console.WriteLine("3. Buscar Documentário");
            Console.WriteLine("4. Retornar ao menu principal");
        }

    }
}
