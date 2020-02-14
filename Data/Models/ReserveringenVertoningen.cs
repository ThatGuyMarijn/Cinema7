using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinema7.Data.Models
{
    public partial class ReserveringenVertoningen
    {
        [Key]
        public Guid ReserveringsId { get; set; }
        public Guid VertoningsId { get; set; }
        public int AantalTickets { get; set; }
    }
}
