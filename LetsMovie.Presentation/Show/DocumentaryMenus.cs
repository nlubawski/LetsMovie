using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.Show
{
    public static class DocumentaryMenus
    {
        public const string RegistrationTitle = @"
##   Cadastro de Documentário   ##

Digite o título do documentário: ";

        public const string RegistrationCountry = @"
Digite onde foi produzido o documentário:

1. Brasil
2. Estados Unidos
3. Países LatinoAmericanos
4. Países Europeus
5. Países Asiáticos
6. Países Africanos";

        public const string RegistrationProducer = @"
Digite o nome da produtora ou do produtor(a) independente: ";


        public const string SearchDocumentary = @"
Digite o nome do documentário que deseja assistir:";

    }
}
