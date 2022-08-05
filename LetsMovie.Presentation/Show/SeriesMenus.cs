using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation.Show
{
    public static class SeriesMenus
    {
        public const string RegistrationTitle = @"
##   Cadastro de Série   ##

Digite o título da série: ";

        public const string RegistrationSeason = @"
Digite a temporada que será adicionada: ";

        public const string RegistrationNumberEpisodes = @"
Digite a quantidade de episódios da temporada: ";

        public const string RegistrationNameEpisode = @"
Digite o nome do episódio da temporada: ";

        public const string RegistrationNumberEpisode = @"
Digite o número do episódio que será cadastrado: ";

        public const string RegistrationEpisodeContinue = "Digite \"fim\" caso queria encerrar o cadastro dos episódios";

        public const string SearchSerie = @"
Digite o nome da série que deseja assistir: ";

    }
}
