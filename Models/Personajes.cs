using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Disney_Proyect_Akemy.Models
{
    public class Personajes
    {
        private Peliculas personajes;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public int Edad { get; set; }
        public int Peso { get; set; }
        public string Historia { get; set; }
        

        public  IList<Peliculas> Peliculas { get; set; }
        public  IList<Series> Series { get; set; }


        /*public virtual Peliculas GetPersonajes()
        {
            return personajes;
        }

        public virtual void SetPersonajes(Peliculas value)
        {
            personajes = value;
        }*/

        //public Personajes(Peliculas peliculas) => this.Peliculas = peliculas;
    }
}
