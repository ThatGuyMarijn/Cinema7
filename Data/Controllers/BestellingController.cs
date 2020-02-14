using Cinema7.Data.Models;
using Cinema7.Data.Models.LINQ;
using Cinema7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Data.Controllers
{
    public class BestellingController
    {
        private readonly CinemaDbContext _CinemaDbContext;

        public BestellingController(CinemaDbContext CinemaDbContext)
        {
            _CinemaDbContext = CinemaDbContext;
        }

        public List<Reserveringen> SelectAllVertoningen(Guid id)
        {
            // AspNetUsers.Id == KlantId
            return _CinemaDbContext.Reserveringen.Where(x => x.KlantId == id).ToList();
        }

        public List<Bestellingen> GetReserveringen(Guid id, List<Bestellingen> reserveringen)
        {
            var result = (from film in _CinemaDbContext.Films
                          join filmVert in _CinemaDbContext.FilmVertoningen on film.Id equals filmVert.FilmId
                          join resVert in _CinemaDbContext.ReserveringenVertoningen on filmVert.Id equals resVert.VertoningsId
                          join res in _CinemaDbContext.Reserveringen on resVert.ReserveringsId equals res.ReserveringsId
                          where res.KlantId == Guid.Parse("bfe1524b-2be9-4337-8832-96ddc56c2ea7")
                          orderby filmVert.Datum ascending
                          select new { film.Id, film.Titel, filmVert.ZaalNr, filmVert.Datum, resVert.AantalTickets });
            // looped tot hij alles uit de query heeft gehaald
            foreach (var row in result)
            {
                if (row.Titel != null)
                {
                    var tempResult = new Bestellingen
                    {
                        Id = row.Id,
                        Titel = row.Titel,
                        ZaalNr = row.ZaalNr,
                        Datum = row.Datum,
                        AantalTickets = row.AantalTickets,
                    };
                    // voegt de record toe aan de lijst
                    reserveringen.Add(tempResult);
                }
            }
            // geeft de lijst met reserveringen terug
            return reserveringen;
        }

        public async Task<List<Bestellingen>> GetReserveringenAsync(Guid id, List<Bestellingen> reserveringen)
        {
            // Guid.Parse("bfe1524b-2be9-4337-8832-96ddc56c2ea7"
            var result = (from film in _CinemaDbContext.Films
                          join filmVert in _CinemaDbContext.FilmVertoningen on film.Id equals filmVert.FilmId
                          join resVert in _CinemaDbContext.ReserveringenVertoningen on filmVert.Id equals resVert.VertoningsId
                          join res in _CinemaDbContext.Reserveringen on resVert.ReserveringsId equals res.ReserveringsId
                          where res.KlantId == id
                          orderby filmVert.Datum ascending
                          select new { film.Id, film.Titel, filmVert.ZaalNr, filmVert.Datum, resVert.AantalTickets });
            // looped tot hij alles uit de query heeft gehaald
            foreach (var row in result)
            {
                if (row.Titel != null)
                {
                    var tempResult = new Bestellingen
                    {
                        Id = row.Id,
                        Titel = row.Titel,
                        ZaalNr = row.ZaalNr,
                        Datum = row.Datum,
                        AantalTickets = row.AantalTickets,
                    };
                    // voegt de record toe aan de lijst
                    reserveringen.Add(tempResult);
                }
            }
            // geeft de lijst met reserveringen terug
            return await Task.FromResult(reserveringen);
        }
    }
}
