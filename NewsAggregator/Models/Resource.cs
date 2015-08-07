using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAggregator.Models
{
	public class Resource
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Link { get; set; }
		public string Tag { get; set; }
		public DateTime UpdatedOn { get; set; }
		public virtual ICollection<News> Newses { get; set; }
	}
}