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
			if (context.Days.Any()) return;

			var days = new List<Day>();

			for (int i = 1; i < 25; i++)
			{
				days.Add(new Day
				{
					DayNumber = i,
					Habits = new List<Habit> { new Habit { HabitName = "Workout", Completed = false } }
				});
			}


			await context.Days.AddRangeAsync(days);
			await context.SaveChangesAsync();
		}
	}
}