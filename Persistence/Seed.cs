using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
	public class Seed
	{
		public static async Task SeedData(DataContext context)
		{
			if (context.Months.Any()) return;

			var days = new List<Day>();

			for (int i = 0; i < 25; i++)
			{
				days.Add(new Day
				{
					DayNumber = i,
					Habits = new List<Habit>()
				});
			}

			var month = new Month
			{
				Days = days,
				MonthName = "January",
				NumberOfDays = days.Count
			};

			await context.Months.AddAsync(month);
			await context.SaveChangesAsync();
		}
	}
}