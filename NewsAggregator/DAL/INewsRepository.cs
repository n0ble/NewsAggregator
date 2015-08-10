using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsAggregator.Models;

namespace NewsAggregator.DAL
{
	public interface INewsRepository
	{
		IQueryable<News> GetNews();
	}
}
