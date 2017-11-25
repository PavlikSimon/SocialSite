using BussinessLayer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class AppUserController : Controller
    {
        // AppUserFacade appUserFacade


        // GET: AppUser
        [Authorize]
        public ActionResult Index()
        {
            /*var model = userFacade.GetAllUsers();
            return View(model);*/
        }



    }
}