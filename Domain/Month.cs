using System;
using System.Collections.Generic;

namespace Domain
{
	public class Month
	{
		public Guid Id { get; set; }
		public string MonthName { get; set; }
		public int NumberOfDays { get; set; }
		public List<Day> Days { get; set; }
	}
}