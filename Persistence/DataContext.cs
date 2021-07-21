using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions options) : base(options)
		{
		}


		public DbSet<Day> Days { get; set; }
		public DbSet<Habit> Habits { get; set; }
	}
}