using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Habits
{
	public class Edit
	{
		public class Command : IRequest
		{
			public Habit Habit { get; set; }
		}

		public class Handler : IRequestHandler<Command>
		{
			private readonly DataContext _context;
			private readonly IMapper _mapper;
			public Handler(DataContext context, IMapper mapper)
			{
				this._mapper = mapper;
				this._context = context;
			}

			public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
			{
				var habit = await _context.Habits.FindAsync(request.Habit.Id);
				_mapper.Map(request.Habit, habit);
				await _context.SaveChangesAsync();
				return Unit.Value;
			}
		}
	}
}