using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disney_Proyect_Akemy.Models
{
    public class Series
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SeriesId { get; set; }
        public string Titulo { get; set; }
        public int Calificacion { get; set; }
        public int Creacion { get; set; }

        public virtual Personajes Personajes { get; set; }
    }


}