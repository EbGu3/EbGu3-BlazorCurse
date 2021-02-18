using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMovie.Shared.Entity;

namespace BlazorMovie.Client.Data
{
    public class Repository : IRepository<Movie>
    {
        public List<Movie> GetMovies()
        {
            return  new List<Movie>()
            {
                new Movie(){Title = "Spiderman", LaunchDate = new DateTime(2019, 7,2)},
                new Movie(){Title = "Moana", LaunchDate = new DateTime(2019, 7,2)},
                new Movie(){Title = "Stich", LaunchDate = new DateTime(2019, 7,2)}
            };
        }
    }
}
