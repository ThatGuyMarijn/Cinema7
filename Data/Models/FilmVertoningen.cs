using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema7.Data.Models
{
    public partial class FilmVertoningen
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int ZaalNr { get; set; }

        [Required]
        public Guid FilmId { get; set; }

        [Required]
        public DateTime Datum { get; set; }
    }
}
