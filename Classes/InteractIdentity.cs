using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema7.Classes
{
    public class InteractIdentity
    {
        public async Task<Guid> GetIdentityUserIdAsync(UserManager<IdentityUser> _userManager, 
                                                       IHttpContextAccessor _httpContext)
        {
            var user = _userManager.FindByNameAsync(_httpContext.HttpContext.User.Identity.Name);
            IdentityUser idUser = await user;

            IdentityUser currentUser = await _userManager.FindByNameAsync(idUser.Email);
            Guid id = Guid.Parse(currentUser.Id);
            return await Task.FromResult(id);
        }
    }
}
