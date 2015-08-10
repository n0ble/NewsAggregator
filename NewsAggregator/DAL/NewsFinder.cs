using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsAggregator.Models;

namespace NewsAggregator.DAL
{
	public class NewsFinder
	{
		private INewsRepository _repository;

		public NewsFinder(INewsRepository repository)
		{
			_repository = repository;
		}

		public IEnumerable<News> FindBySubject(string q)
		{
			return _repository
				.GetNews()
				.Where(n => n.Subject.Contains(q));
		}
	}
}