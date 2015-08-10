

namespace NewsAggregator.Migrations
{
	using System.Data.Entity.Migrations;
	using NewsAggregator.DAL;

	public sealed class Configuration : DbMigrationsConfiguration<NewsAggregator.DAL.AppContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			ContextKey = "NewsAggregator.DAL.AppContext";
		}

		protected override void Seed(AppContext context)
		{
			//var newses = new List<News>
			//{
			//	new News{Id=1, Rate = 3, Subject = "Beyond Carrot Sticks: Serve Great Party Foods That Don’t Pack on Pounds", Body = "When you’re watching what you eat, party can sound like a four letter word. " +
			//																											   "Have no fear: if you’re throwing the shindig yourself—or attending someone else’s— nibbles nutritionist Tanya Zuckerbrot gave us these suggestions to keep you on a nutritious, yet yummy, track.", Author = "Helaina Hovitz", UpdatedOn = new DateTime(2015,8,6)},
			//	new News{Id=1, Subject = "After Wedding, Instead of Fancy Meal Couple Serves 4000 Syrian Refugees", Body = "A young Turkish couple wanted to celebrate their wedding day by bringing happiness to some of the refugees who have fled Syria since the outbreak of the civil war four years ago. Fethullah Üzümcüoğlu and Esra Polat, who married last week in a province near the Syrian border, pooled the money they got from friends and family and used it to host a party for thousands of strangers. “I was shocked when Fethullah first told me about the idea but afterwards I was won over by it. It was such a wonderful experience. I’m happy that we had the opportunity to share our wedding meal with the people who are in real need,” Esra told i100.", Author = "Adriana White", UpdatedOn = new DateTime(2015,7,6)},
			//	new News{Id=1, Subject = "Trophy-Hunted Lion’s Tragedy Leads to Animal Rights Triumphs", Body = "On July 2, Cecil, a 13-year-old male Southwest African lion, was killed in a hunting expedition in Zimbabwe. A main attraction at the Hwange National Park, Cecil was shot with a cross bow by an American dentist who was led by a licensed local game-hunter.", Author = "Ben Shultz", UpdatedOn = new DateTime(2015,6,6)},
			//};

			//newses.ForEach(n => context.Newses.Add(n));
			//context.SaveChanges();

			//var resources = new List<Resource>
			//{
			//	new Resource{Id=1, Name = "goodnewsnetwork", Link = "http://www.goodnewsnetwork.org/", Tag = "good", UpdatedOn = DateTime.Parse("2015-08-01")}

			//};

			//resources.ForEach(r => context.Resources.Add(r));
			//context.SaveChanges();
		}
	}
}
