using Cinema7.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Data.Controllers
{
    public class ReserveringController
    {
        private readonly CinemaDbContext _CinemaDbContext;

        public ReserveringController(CinemaDbContext CinemaDbContext)
        {
            _CinemaDbContext = CinemaDbContext;
        }

        // Add to Database
        #region

        public Task<Reserveringen> AddReservering(Reserveringen res, ReserveringenVertoningen rVert)
        {
            _CinemaDbContext.Entry(res).State = EntityState.Added;
            _CinemaDbContext.Reserveringen.Add(res);
            _CinemaDbContext.SaveChanges();

            _CinemaDbContext.Entry(rVert).State = EntityState.Added;
            _CinemaDbContext.ReserveringenVertoningen.Add(rVert);
            _CinemaDbContext.SaveChanges();

            return Task.FromResult(res);
        }
        #endregion

    }
}
