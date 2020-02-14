using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Models
{
    public class Films
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public int Duur { get; set; }

        public string Genre { get; set; }

        public string Leeftijd { get; set; }

        [Required]
        public double Prijs { get; set; }

        public string Type { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
