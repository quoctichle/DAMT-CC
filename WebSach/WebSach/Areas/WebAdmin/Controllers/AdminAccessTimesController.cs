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
    public class AdminAccessTimesController : Controller
    {
        private Model1 db = new Model1();

        // GET: WebAdmin/AdminAccessTimes
        public async Task<ActionResult> Index()
        {
            return View(await db.Access_Times.ToListAsync());
        }

        // GET: WebAdmin/AdminAccessTimes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Access_Times access_Times = await db.Access_Times.FindAsync(id);
            if (access_Times == null)
            {
                return HttpNotFound();
            }
            return View(access_Times);
        }

        // GET: WebAdmin/AdminAccessTimes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebAdmin/AdminAccessTimes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AccessTimes,Update_at")] Access_Times access_Times)
        {
            if (ModelState.IsValid)
            {
                db.Access_Times.Add(access_Times);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(access_Times);
        }

        // GET: WebAdmin/AdminAccessTimes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Access_Times access_Times = await db.Access_Times.FindAsync(id);
            if (access_Times == null)
            {
                return HttpNotFound();
            }
            return View(access_Times);
        }

        // POST: WebAdmin/AdminAccessTimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AccessTimes,Update_at")] Access_Times access_Times)
        {
            if (ModelState.IsValid)
            {
                db.Entry(access_Times).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(access_Times);
        }

        // GET: WebAdmin/AdminAccessTimes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Access_Times access_Times = await db.Access_Times.FindAsync(id);
            if (access_Times == null)
            {
                return HttpNotFound();
            }
            return View(access_Times);
        }

        // POST: WebAdmin/AdminAccessTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Access_Times access_Times = await db.Access_Times.FindAsync(id);
            db.Access_Times.Remove(access_Times);
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
