using Cinema7.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Pages.Movies
{
    public partial class FilmReserveren
    {
        [Parameter]
        public Guid FilmId { get; set; }

        [Parameter]
        public Guid VertId { get; set; }

        [Parameter]
        public int ZaalNr { get; set; }

        [Parameter]
        public DateTime Datum { get; set; }

        [Parameter]
        public DateTime Tijd { get; set; }
    }
}
