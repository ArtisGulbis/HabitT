using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Habits
{
	public class Details
	{
		public class Query : IRequest<Habit>
		{
			public Guid Id { get; set; }
		}

		public class Handler : IRequestHandler<Query, Habit>
		{
			private readonly DataContext _context;
			public Handler(DataContext context)
			{
				this._context = context;
			}

			public async Task<Habit> Handle(Query request, CancellationToken cancellationToken)
			{
				return await _context.Habits.FindAsync(request.Id);
			}
		}
	}
}