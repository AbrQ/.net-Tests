﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        [JsonIgnore]
        public Pais Pais { get; set; }
    }
}
