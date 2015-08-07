using System.Data.Entity;
using NewsAggregator.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAggregator.DAL
{
	public class AppContext : DbContext
	{
		public AppContext()
			: base("AppContext") { }

		public DbSet<News> Newses { get; set; }
		public DbSet<Resource> Resources { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}