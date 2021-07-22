using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Habits
{
	public class List
	{
		public class Query : IRequest<List<Habit>> { };
		public class Handler : IRequestHandler<Query, List<Habit>>
		{
			private readonly DataContext _context;
			public Handler(DataContext context)
			{
				this._context = context;
			}

			public async Task<List<Habit>> Handle(Query request, CancellationToken cancellationToken)
			{
				return await _context.Habits.ToListAsync();
			}
		}

	}
}