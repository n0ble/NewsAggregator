using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HAP=HtmlAgilityPack;
using NewsAggregator.Models;

namespace NewsAggregator.BLL
{
	interface IParser
	{
		IQueryable<News> ParseNews(IQueryable<HAP.HtmlNode> nodes);
	}
}
