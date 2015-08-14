using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using HtmlAgilityPack;
using NewsAggregator.DAL;
using NewsAggregator.Models;
using NewsAggregator.BLL;

namespace NewsAggregator.Controllers
{
	public class NewsController : Controller
	{
		//private static INewsRepository newsRepository;

		private readonly NewsFinder _finder;

		public NewsController()
		{
		}

		public NewsController(NewsFinder finder)
		{
			this._finder = finder;
		}

		private AppContext db = new AppContext();
	
		

		// GET: News
		public ActionResult Index()
		{
			var scraper = new NewsScraper();
			var resource = new Resource("BBC", "http://www.bbc.com", "Britain");
			var nodes = scraper.GetNodes(resource);
			foreach (HtmlNode n in nodes)
			{
				var doc = scraper.GetDocument(resource.Link + n.Attributes["href"].Value);
				var parser = new HAPParser();
				parser.GetSubject(doc);
				parser.GetBody(doc);
			}

			return View(db.Newses.ToList());
		}

		// GET: News/Details/5
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            News news = db.Newses.Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }

		// GET: News/Details/5

		public ActionResult Find(string q)
		{
			if (q == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			IEnumerable<News> newses = _finder.FindBySubject(q).AsEnumerable();
			if (newses == null)
			{
				return HttpNotFound();
			}
			return View(newses.FirstOrDefault());
		}

		// GET: News/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: News/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Subject,Body,Author,UpdatedOn")] News news)
		{
			if (ModelState.IsValid)
			{
				db.Newses.Add(news);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(news);
		}

		// GET: News/Edit/5
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			News news = db.Newses.Find(id);
			if (news == null)
			{
				return HttpNotFound();
			}
			return View(news);
		}

		// POST: News/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Subject,Body,Author,UpdatedOn")] News news)
		{
			if (ModelState.IsValid)
			{
				db.Entry(news).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(news);
		}

		// GET: News/Delete/5
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			News news = db.Newses.Find(id);
			if (news == null)
			{
				return HttpNotFound();
			}
			return View(news);
		}

		// POST: News/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			News news = db.Newses.Find(id);
			db.Newses.Remove(news);
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
