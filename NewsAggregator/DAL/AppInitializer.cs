using System;
using System.Collections.Generic;
using System.Data.Entity;
using NewsAggregator.Migrations;
using NewsAggregator.Models;


namespace NewsAggregator.DAL
{
	public class AppInitializer : MigrateDatabaseToLatestVersion<AppContext, Configuration>
	{

	}
}