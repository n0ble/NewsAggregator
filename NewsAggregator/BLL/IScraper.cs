using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAggregator.Models;
using HAP = HtmlAgilityPack;

namespace NewsAggregator.BLL
{
	interface IScraper
	{
		IQueryable<HAP.HtmlNode> GetNodes(Resource resource);
	}
}
