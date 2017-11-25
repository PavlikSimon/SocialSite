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
using SocialSite.Models;

namespace SocialSite.Controllers
{
    public class AppUserController : Controller
    {
        
        //public AppUserFacade appUserFacade { get; set; }
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AppUser
        /*public async Task<ActionResult> Index()
        {
            var result = await appUserFacade.GetAllAppUsersAsync();
            return View(result);
        }*/

        // GET: AppUser
        public ActionResult Index()
        {
            return View(db.AppUserDTOes.ToList());
        }

        // GET: AppUser/Details/5
        public ActionResult Details(int? id)
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

        /*
        // GET: AppUser/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = await appUserFacade.GetByIdAsync(id.Value);
            // db.AppUserDTOes.Find(id);

            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }*/



        // GET: AppUser/Create
        public ActionResult Create()
        {
            return View();
        }

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
    }
}
