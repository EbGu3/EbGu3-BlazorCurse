using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovie.Shared.Entity
{
    public class Movie
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime? LaunchDate { get; set; }

        public int Id { get; set; }
        public string  Summary { get; set; }
        public bool OnBilldBoard { get; set; }
        public string Trailer { get; set; }
 
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
