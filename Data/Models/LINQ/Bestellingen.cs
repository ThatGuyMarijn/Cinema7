using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Data.Models.LINQ
{
    public class Bestellingen
    {
        public Guid Id { get; set; }
        public string Titel { get; set; }
        public int ZaalNr { get; set; }
        public DateTime Datum { get; set; }
        public int AantalTickets { get; set; }
    }
}
