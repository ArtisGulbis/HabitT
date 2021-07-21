using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Linq;

namespace API.Controllers
{
	public class DaysController : BaseApiController
	{

		private readonly DataContext _context;
		public DaysController(DataContext context)
		{
			this._context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<Day>>> GetDays()
		{
			return await _context.Days.OrderBy(d => d.DayNumber).ToListAsync();
		}
	}
}