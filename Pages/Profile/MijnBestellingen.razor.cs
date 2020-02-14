using Cinema7.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Cinema7.Data.Models;
using Cinema7.Data.Controllers;
using Cinema7.Classes;
using Cinema7.Models;
using Cinema7.Data.Models.LINQ;

namespace Cinema7.Pages.Profile
{
    public partial class MijnBestellingen
    {
        [Inject]
        protected UserManager<IdentityUser> _userManager { get; set; }

        [Inject]
        protected IHttpContextAccessor _httpContext { get; set; }

        [Inject]
        protected CinemaDbContext _CinemaDbContext { get; set; }

        [Inject]
        protected BestellingController bestellingController { get; set; }

        // 'id' is being used to get the currently logged in IdentityUser ID
        Guid id;

        // Reserveringen lijst
        List<Bestellingen> reserveringen = new List<Bestellingen>();

        protected override async Task OnInitializedAsync()
        {
            // roept methode op om UserId te krijgen van AspNetUsers
            InteractIdentity interactIdentity = new InteractIdentity();
            id = await interactIdentity.GetIdentityUserIdAsync(_userManager, _httpContext);

            // haalt alle reserveringen voor de ingelogde gebruiker
            reserveringen = await bestellingController.GetReserveringenAsync(id, reserveringen);
        }
    }
}