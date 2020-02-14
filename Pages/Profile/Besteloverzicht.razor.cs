using Cinema7.Classes;
using Cinema7.Data;
using Cinema7.Data.Controllers;
using Cinema7.Data.Models;
using Cinema7.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Pages.Profile
{
    public partial class Besteloverzicht
    {
        [Inject]
        protected CinemaDbContext _CinemaDbContext { get; set; }

        [Inject]
        protected ReserveringController resController { get; set; }

        [Inject]
        protected NavigationManager navigationManager { get; set; }

        [Inject]
        protected UserManager<IdentityUser> _userManager { get; set; }

        [Inject]
        protected IHttpContextAccessor _httpContext { get; set; }

        [Parameter]
        public Guid VertId { get; set; }

        [Parameter]
        public Guid FilmId { get; set; }

        [Parameter]
        public int ZaalNr { get; set; }

        [Parameter]
        public int AantalTickets { get; set; }

        Films film = null;
        FilmVertoningen vertoning = null;

        private Guid newReserveringsId = Guid.NewGuid();

        protected override void OnInitialized()
        {
            film = _CinemaDbContext.Films.Single(film => film.Id == FilmId);
            vertoning = _CinemaDbContext.FilmVertoningen.Single(vert => vert.Id == VertId);
        }

        public async void OnSubmit()
        {
            InteractIdentity interactIdentity = new InteractIdentity();
            // maakt nieuwe 'reserveringen' gegevens aan
            Reserveringen newRes = new Reserveringen
            {
                ReserveringsId = newReserveringsId,
                KlantId = await interactIdentity.GetIdentityUserIdAsync(_userManager, _httpContext)
            };

            // maakt nieuwe 'ReserveringenVertoningen' gegevens aan
            ReserveringenVertoningen newRVert = new ReserveringenVertoningen
            {
                ReserveringsId = newReserveringsId,
                VertoningsId = vertoning.Id,
                AantalTickets = AantalTickets
            };

            await resController.AddReservering(newRes, newRVert);

            // TODO: Stuurt de gebruiker niet door naar laatste gedeelte bestelling, moet wel
            navigationManager.NavigateTo($"/profile/besteloverzicht/bestelling/{newReserveringsId}");
        }
    }
}
