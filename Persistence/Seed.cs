using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence
{
	public class Seed
	{
		public static async Task SeedData(DataContext context, UserManager<AppUser> userManager)
		{
			if (!userManager.Users.Any())
			{
				var users = new List<AppUser>
				{
					new AppUser{DisplayName = "Bob",UserName = "bob", Email ="bob@test.com"},
					new AppUser{DisplayName = "John",UserName = "john", Email ="john@test.com"},
					new AppUser{DisplayName = "Rob",UserName = "rob", Email ="rob@test.com"},
				};
				foreach (var user in users)
				{
					await userManager.CreateAsync(user, "Pa$$w0rd");
				}
			}
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