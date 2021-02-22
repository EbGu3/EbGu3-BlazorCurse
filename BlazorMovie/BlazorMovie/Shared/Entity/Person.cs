using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMovie.Shared.Entity
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime? DateBorn { get; set; }

        public int Id { get; set; }
        public string Biografia { get; set; }
        public string Photo { get; set; }

    }
}
