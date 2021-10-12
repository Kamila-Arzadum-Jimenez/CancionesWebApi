using System.ComponentModel.DataAnnotations;

namespace CancionesWebApi.Models
{
    public class Cancion
    {
        [Key]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Autor { get; set; }
       
        public string Letra { get; set; }
       
        public string Enlace { get; set; }
    }
}
