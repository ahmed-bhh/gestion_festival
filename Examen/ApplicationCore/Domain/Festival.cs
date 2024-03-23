﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Festival
    {
        [Key]
        public int FestivalId { get; set; }
        public int Capacite { get; set; }

        public string Label { get; set; }

        public string Ville { get; set; }

        public ICollection<Artiste> Artists { get; set; }

        

    }
}