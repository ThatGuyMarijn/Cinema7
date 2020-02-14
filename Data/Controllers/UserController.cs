using Cinema7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly CinemaDbContext _CinemaDbContext;

        public UserController(CinemaDbContext CinemaDbContext)
        {
            _CinemaDbContext = CinemaDbContext;
        }

        public List<IdentityUser> SelectAll()
        {
            return _CinemaDbContext.Users.ToList();
        }
    }
}
