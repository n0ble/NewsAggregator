using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAggregator.Models
{
	public class News
	{
		public int Id { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public string Author { get; set; }
		public int Rate { get; set; }
		public virtual DateTime UpdatedOn { get; set; }
		public virtual Resource Resource { get; set; }
	}
}