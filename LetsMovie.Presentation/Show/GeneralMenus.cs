using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.Show
{
    public static class GeneralMenus
    {
        public const string Welcome = @"
==== Bem-vindo ao Lets Movie ====
==== Seu streaming de filmes, séries e documentários ====

Digite a opção desejada:

1. Cadastrar vídeo
2. Buscar vídeo
3. Atualizar
4. Deletar
5. Sair";

//1. Cadastrar
//2. Buscar
//3. Ver catálogo
//4. Sair";


        public const string RegistrationVideo = @"
##   Cadastro    ##

Digite a opção desejada:

1. Cadastrar Filme
2. Cadastrar Série
3. Cadastrar Documentário
4. Retornar ao menu principal";


        public const string SearchMenu = @"
##   Buscar  ##

Digite a opção desejada:

1. Buscar Filme
2. Buscar Série
3. Buscar Documentário
4. Retornar ao menu principal";

    }
}
