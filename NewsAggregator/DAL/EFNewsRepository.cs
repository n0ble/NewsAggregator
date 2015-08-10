using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NewsAggregator.DAL
{
	public class EFNewsRepository : INewsRepository
	{
		AppContext _context;

		public EFNewsRepository(AppContext context)
		{
			_context = context;
		}
		

		public IQueryable<Models.News> GetNews()
		{
			return _context.Newses;
		}
	}
}