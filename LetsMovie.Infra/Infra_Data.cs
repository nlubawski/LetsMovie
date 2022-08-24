using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public static class Infra_Data
    {
        public static void ListMovies()
        {
            List<Movies> listMovies = new List<Movies>();
            listMovies.Add(new Movies(1, "O Exorcista", "Terror", "1974-06-29"));
            listMovies.Add(new Movies(2, "Um Dia", "Romance", "2011-10-14"));
        }
    }
}
