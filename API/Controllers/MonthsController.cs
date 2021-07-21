using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
	public class MonthsController : BaseApiController
	{
		private readonly DataContext _context;
		public MonthsController(DataContext context)
		{
			this._context = context;
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<List<Day>>> GetDays(Guid id)
		{
            return await _context.Days.FindAsync(id);
		}
}
}