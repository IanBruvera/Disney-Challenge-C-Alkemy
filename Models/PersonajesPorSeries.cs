using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Disney_Proyect_Akemy.Models
{
    public class PersonajesPorSeries

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? PersonajesId { get; set; }
        public Personajes Personajes { get; set; }
        public int? SeriesId { get; set; }
        public Series Series { get; set; }
    }

}
