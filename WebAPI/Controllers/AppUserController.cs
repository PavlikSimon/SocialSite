using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BussinessLayer.DTO;
using BussinessLayer.Facades;

namespace WebAPI.Controllers
{
    public class AppUserController : ApiController
    {
        private AppUserFacade appUserFacade;

        
        // GET: api/AppUser
        public async Task<IEnumerable<AppUserDTO>> Get()
        {
            var res = await appUserFacade.GetAllAppUsersAsync();
            return res.Items;
                


    }

        // GET: api/AppUser/5
        public async Task<AppUserDTO> Get(string email)
        {
            var res = await appUserFacade.GetCustomerAccordingToEmailAsync(email);
            
            return res;
        }

        // POST: api/AppUser
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AppUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AppUser/5
        public void Delete(int id)
        {
        }
    }
}
