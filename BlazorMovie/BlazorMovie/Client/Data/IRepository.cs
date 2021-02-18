using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Client.Data
{
    public interface IRepository<T>
    {
        List<T> GetMovies();
    }
}
