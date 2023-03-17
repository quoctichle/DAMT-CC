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

namespace WebSach.Content
{
    public class ReactionsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Reactions
        public async Task<ActionResult> Index()
        {
            return View(await db.Reaction.ToListAsync());
        }

        // GET: Reactions/Details/5
        public async Task<ActionResult> Details(DateTime id)
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

        // GET: Reactions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Update_at,Comment_content")] Reaction reaction)
        {
            if (ModelState.IsValid)
            {
                db.Reaction.Add(reaction);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(reaction);
        }

        // GET: Reactions/Edit/5
        public async Task<ActionResult> Edit(DateTime id)
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

        // POST: Reactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Update_at,Comment_content")] Reaction reaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reaction).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(reaction);
        }

        // GET: Reactions/Delete/5
        public async Task<ActionResult> Delete(DateTime id)
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

        // POST: Reactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(DateTime id)
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
