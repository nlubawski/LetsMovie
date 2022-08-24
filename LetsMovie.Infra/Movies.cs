using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Infra
{
    public class Movies
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfReleased { get; set; }

        public Movies(int id, string title, string gender, string dateOfReleased)
        {
            Id = id;
            Title = title;
            Gender = gender;
            DateOfReleased = Convert.ToDateTime(dateOfReleased);
        }
    }
}
