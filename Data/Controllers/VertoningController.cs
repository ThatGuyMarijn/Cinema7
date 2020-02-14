using Cinema7.Data.Models;
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
    public class VertoningController
    {
        private readonly CinemaDbContext _CinemaDbContext;

        public VertoningController(CinemaDbContext CinemaDbContext)
        {
            _CinemaDbContext = CinemaDbContext;
        }

        public List<FilmVertoningen> SelectById(Guid FilmId)
        {
            return _CinemaDbContext.FilmVertoningen.Where(vert => vert.FilmId == FilmId).ToList();
        }

        public List<FilmVertoningen> SelectAll()
        {
            return _CinemaDbContext.FilmVertoningen.ToList();
        }
    }
}
