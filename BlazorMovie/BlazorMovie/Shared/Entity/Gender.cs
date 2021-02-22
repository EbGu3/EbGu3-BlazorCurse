using System.ComponentModel.DataAnnotations;

namespace BlazorMovie.Shared.Entity
{
    public class Gender
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
    }
}
