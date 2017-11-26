using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BussinessLayer.DTO;
using BussinessLayer.Facades;
using BussinessLayer.Filters;
using BussinessLayer.Services.AppUserService;
using BussinessLayer.Services.StatusService;
using Riganti.Utils.Infrastructure.Core;
using SocialSite.Models;

namespace SocialSite.Controllers
{
    public class AppUserController : Controller
    {
        //private static readonly IAppUserService appUserService;
        //private static IUnitOfWorkProvider unitOfWorkProvider;

        //private AppUserFacade appUserFacade = new AppUserFacade(unitOfWorkProvider, appUserService);

        //private ApplicationDbContext db = new ApplicationDbContext();

        private readonly string filterSessionKey = "filter";

        private readonly string categoryTreesSessionKey = "categoryTrees";

        public AppUserFacade AppUserFacade { get; set; }
        // GET: AppUser
       public async Task<ActionResult> Index()
        {
            var result = await AppUserFacade.GetAllAppUsersAsync();
            return View(result.Items);
        }

/*
        public ActionResult Index(int page = 1)
        {
            var filter = Session[filterSessionKey] as AppUserFilterDto ?? new AppUserFilterDto();
            var categoryTrees = Session[categoryTreesSessionKey] as IList<AppUserDTO>;

            var result = AppUserFacade.GetAllAppUsersAsync();

            var model = InitializeProductListViewModel(result, categoryTrees);

            return View("ProductListView", model);
        }*/

        /// <summary>
      /*  /// Initializes new ProductListViewModel according to its parameters
        /// </summary>
        /// <param name="result">Product list query result containing products page and related data</param>
        /// <param name="categories">List of category trees</param>
        /// <returns>Initialized instance of ProductListViewModel</returns>
        private AppUserViewModel InitializeProductListViewModel(ProductListQueryResultDTO result, IList<AppUserDTO> users = null)
        {
            return new AppUserViewModel
            {
                Products = AppUserFacade.GetAllAppUsersAsync();
        };
        }*/


        // GET: AppUser/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = await AppUserFacade.GetByIdAsync(id.Value);

            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        /* // GET: AppUser
        public ActionResult Index()
        {
            return View(db.AppUserDTOes.ToList());
        }*/

        // GET: AppUser/Details/5
        /*public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppUserDTO appUserDTO = db.AppUserDTOes.Find(id);
            if (appUserDTO == null)
            {
                return HttpNotFound();
            }
            return View(appUserDTO);
        }*/

        // GET: AppUser/Create
        public ActionResult Create()
        {
            return View();
        }
        /*
        // POST: AppUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserName,Email,AccessFailedCount,Name,Surname,Gender,Hidden")] AppUserDTO appUserDTO)
        {
            if (ModelState.IsValid)
            {
                db.AppUserDTOes.Add(appUserDTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(appUserDTO);
        }

        // GET: AppUser/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppUserDTO appUserDTO = db.AppUserDTOes.Find(id);
            if (appUserDTO == null)
            {
                return HttpNotFound();
            }
            return View(appUserDTO);
        }

        // POST: AppUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,Email,AccessFailedCount,Name,Surname,Gender,Hidden")] AppUserDTO appUserDTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appUserDTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appUserDTO);
        }

        // GET: AppUser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppUserDTO appUserDTO = db.AppUserDTOes.Find(id);
            if (appUserDTO == null)
            {
                return HttpNotFound();
            }
            return View(appUserDTO);
        }

        // POST: AppUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppUserDTO appUserDTO = db.AppUserDTOes.Find(id);
            db.AppUserDTOes.Remove(appUserDTO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    */


    }
}
