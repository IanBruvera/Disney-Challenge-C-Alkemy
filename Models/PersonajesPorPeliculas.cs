using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Disney_Proyect_Akemy.Models
{
    public class PersonajesPorPeliculas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? PersonajesId { get; set; }
        public Personajes Personajes { get; set; }
        public int? PeliculasId { get; set; }
        public Peliculas Peliculas { get; set; }
    }
}
