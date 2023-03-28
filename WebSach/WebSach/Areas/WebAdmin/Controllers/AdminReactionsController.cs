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
    public class AdminReactionsController : Controller
    {
        private Model1 db = new Model1();

        // GET: WebAdmin/AdminReactions
        public async Task<ActionResult> Index()
        {
            return View(await db.Reaction.ToListAsync());
        }

        // GET: WebAdmin/AdminReactions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reaction reaction = await db.Reaction.FindAsync(id);
            if (reaction == null)
            {
                return HttpNotFound();
            }
            return View(reaction);
        }

        // GET: WebAdmin/AdminReactions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebAdmin/AdminReactions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Reaction_Id,Comment_content,Update_at")] Reaction reaction)
        {
            if (ModelState.IsValid)
            {
                db.Reaction.Add(reaction);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(reaction);
        }

        // GET: WebAdmin/AdminReactions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reaction reaction = await db.Reaction.FindAsync(id);
            if (reaction == null)
            {
                return HttpNotFound();
            }
            return View(reaction);
        }

        // POST: WebAdmin/AdminReactions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Reaction_Id,Comment_content,Update_at")] Reaction reaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reaction).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(reaction);
        }

        // GET: WebAdmin/AdminReactions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reaction reaction = await db.Reaction.FindAsync(id);
            if (reaction == null)
            {
                return HttpNotFound();
            }
            return View(reaction);
        }

        // POST: WebAdmin/AdminReactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Reaction reaction = await db.Reaction.FindAsync(id);
            db.Reaction.Remove(reaction);
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
