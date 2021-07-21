using System;
using System.Collections.Generic;

namespace Domain
{
	public class Day
	{
		public Guid Id { get; set; }
		public int DayNumber { get; set; }
		public List<Habit> Habits { get; set; }
	}
}