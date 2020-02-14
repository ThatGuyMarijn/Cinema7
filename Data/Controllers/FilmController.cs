using Cinema7.Data.Models;
using Cinema7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : Controller
    {
        private readonly CinemaDbContext _CinemaDbContext;

        public FilmController(CinemaDbContext CinemaDbContext)
        {
            _CinemaDbContext = CinemaDbContext;
        }

        // Select From Database
        #region

        public List<Films> SelectAll()
        {
            return _CinemaDbContext.Films.OrderBy(x => x.Genre).ThenBy(x => x.Status).ToList();
        }

        public List<Films> SelectFilmStatus(string status)
        {
            return _CinemaDbContext.Films.Where(film => film.Status == status).OrderBy(x => x.Genre).ToList();
        }
        #endregion

        // Modify Database
        #region 

        public Task<Films> DeleteFilm(Guid Id)
        {
            Films film = _CinemaDbContext.Films.Find(Id);
            _CinemaDbContext.Films.Remove(film);
            _CinemaDbContext.SaveChanges();
            return Task.FromResult(film);
        }

        public Task<Films> AddMovie(Films film)
        {
            _CinemaDbContext.Entry(film).State = EntityState.Added;
            _CinemaDbContext.Films.Add(film);
            _CinemaDbContext.SaveChanges();
            return Task.FromResult(film);
        }

        public Task<Films> EditMovie(Films film)
        {
            // find movies that are linked with 'film.Id'
            var original = _CinemaDbContext.Films.Find(film.Id);
            if(original != null)
            {
                // if it finds something, give it the new values from 'film'
                _CinemaDbContext.Entry(film).CurrentValues.SetValues(film);
                _CinemaDbContext.SaveChanges();
            }
            return Task.FromResult(film);
        }
        #endregion
    }
}
