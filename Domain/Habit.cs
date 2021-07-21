using System;

namespace Domain
{
	public class Habit
	{
		public Guid Id { get; set; }
		public string HabitName { get; set; }
		public bool Completed { get; set; }
	}
}