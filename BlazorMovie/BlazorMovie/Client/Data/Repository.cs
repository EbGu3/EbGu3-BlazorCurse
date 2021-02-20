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
                new Movie()
                {
                    Title = "Spiderman", 
                    LaunchDate = new DateTime(2019, 7,2), 
                    Poster = "https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_UX182_CR0,0,182,268_AL_.jpg"
                },
                new Movie()
                {
                    Title = "Moana",
                    LaunchDate = new DateTime(2019, 7,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_UX182_CR0,0,182,268_AL_.jpg"
                },
                new Movie()
                {
                    Title = "Stich", 
                    LaunchDate = new DateTime(2019, 7,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMTkwOTU5MTA2M15BMl5BanBnXkFtZTYwMjYyNTc3._V1_UX182_CR0,0,182,268_AL_.jpg"
                }
            };
        }
    }
}