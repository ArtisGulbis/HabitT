using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Habits
{
	public class Delete
	{
		public class Command : IRequest
		{
			public Guid Id { get; set; }
		}

		public class Handler : IRequestHandler<Command>
		{
			private readonly DataContext _context;
			public Handler(DataContext context)
			{
				this._context = context;

			}

			public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
			{
				var habit = await _context.Habits.FindAsync(request.Id);
				_context.Remove(habit);
				await _context.SaveChangesAsync();
				return Unit.Value;
			}
		}
	}
}