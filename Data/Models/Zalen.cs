using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema7.Data.Models
{
    public partial class Zalen
    {
        [Key]
        public int ZaalNr { get; set; }
        public string Naam { get; set; }
        public int Capaciteit { get; set; }
        public string Service { get; set; }
    }
}
