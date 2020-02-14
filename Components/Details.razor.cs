using Cinema7.Data.Models;
using Cinema7.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Components
{
    public partial class Details
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

        // als 'Details' het op magische wijze niet meer doet, uncomment dit. :-)
        //[Parameter]
        //public RenderFragment ChildContent { get; set; }

        Films film = null;
        FilmVertoningen vertoning = null;

        protected override void OnInitialized()
        {
            film = _CinemaDbContext.Films.Single(film => film.Id == FilmId);
            if(ZaalNr != 0)
            {
                vertoning = _CinemaDbContext.FilmVertoningen.Single(vert => vert.Id == VertId);
            }
        }

        private void Order()
        {
            int AantalTickets = tickets;

            // When finished go to besteloverzicht
            navigationManager.NavigateTo($"profile/besteloverzicht/{vertoning.Id}/{film.Id}/{ZaalNr}/{AantalTickets}");
        }
    }
}
