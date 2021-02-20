using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovie.Shared.Entity
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime LaunchDate { get; set; }
        public string Poster { get; set; }

        public string CutTitle
        {
            get
            {
                if(string.IsNullOrWhiteSpace(Title))
                {
                    return null;
                }
                if(Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }
    }
}
