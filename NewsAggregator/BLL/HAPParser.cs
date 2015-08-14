using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using HAP=HtmlAgilityPack;
using NewsAggregator.Models;

namespace NewsAggregator.BLL
{
	public class HAPParser 
	{

		public string GetSubject(HAP.HtmlDocument doc)
		{

			var res = doc.DocumentNode.SelectNodes("//h1");
			var FirstOrDefault = res.FirstOrDefault();
			if (FirstOrDefault != null)
			{
				string subject = res != null ? FirstOrDefault.InnerText : "";
				return subject;
			}
			else return "";
		}
		
		public string GetBody(HAP.HtmlDocument doc)
		{

			var nodes = doc.DocumentNode.SelectNodes("(//div[@class='story-body'])[1]");
			string body = nodes.Aggregate("", (current, n) => current + n.InnerText);
			return body;
		}

	}
}