using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Areas.WebAdmin.Controllers
{
    public class AdminPermissionsController : Controller
    {
        private Model1 db = new Model1();

        // GET: WebAdmin/AdminPermissions
        public async Task<ActionResult> Index()
        {
            return View(await db.Permission.ToListAsync());
        }

        // GET: WebAdmin/AdminPermissions/Details/5
        public async Task<ActionResult> Details(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permission permission = await db.Permission.FindAsync(id);
            if (permission == null)
            {
                return HttpNotFound();
            }
            return View(permission);
        }

        // GET: WebAdmin/AdminPermissions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebAdmin/AdminPermissions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Permission_Id,Name,Noted,Status")] Permission permission)
        {
            if (ModelState.IsValid)
            {
                db.Permission.Add(permission);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(permission);
        }

        // GET: WebAdmin/AdminPermissions/Edit/5
        public async Task<ActionResult> Edit(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permission permission = await db.Permission.FindAsync(id);
            if (permission == null)
            {
                return HttpNotFound();
            }
            return View(permission);
        }

        // POST: WebAdmin/AdminPermissions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Permission_Id,Name,Noted,Status")] Permission permission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(permission).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(permission);
        }

        // GET: WebAdmin/AdminPermissions/Delete/5
        public async Task<ActionResult> Delete(bool? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permission permission = await db.Permission.FindAsync(id);
            if (permission == null)
            {
                return HttpNotFound();
            }
            return View(permission);
        }

        // POST: WebAdmin/AdminPermissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(bool id)
        {
            Permission permission = await db.Permission.FindAsync(id);
            db.Permission.Remove(permission);
            await db.SaveChangesAsync();
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
