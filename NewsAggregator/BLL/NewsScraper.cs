using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsAggregator.Models;
using HAP = HtmlAgilityPack;

namespace NewsAggregator.BLL
{
	public class NewsScraper : IScraper
	{
		private HAP.HtmlWeb _web;

		public NewsScraper()
		{
			_web = new HAP.HtmlWeb();
		}

		public IQueryable<HAP.HtmlNode> GetNodes(Resource resource)
		{

			var document = _web.Load(resource.Link + "/news");
			var aTags = document.DocumentNode.SelectNodes("//a[@class='title-link']");
			return aTags.AsQueryable();
		}

		public HAP.HtmlDocument GetDocument(string url)
		{
			
			return _web.Load(url);
		}
	}
}