using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Pais
    {

        public Pais()
        {
            Provincias = new List<Provincia>();
        }

        public int Id { get; set; }
        [StringLength(30)]
        public string Nombre { get; set; }
        [Required]
        public List<Provincia> Provincias { get; set; }
    }
}

