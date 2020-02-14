using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema7.Data.Models
{
    public partial class Reserveringen
    {
        [Key]
        public Guid ReserveringsId { get; set; }
        public Guid KlantId { get; set; }
    }
}
