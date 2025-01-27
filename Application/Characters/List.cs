using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Characters;

public class List
{
	public class Query : IRequest<Result<List<Character>>> { }

	public class Handler : IRequestHandler<Query, Result<List<Character>>>
	{
		private readonly DataContext _context;

		public Handler(DataContext context)
		{
			_context = context;

		}

		public async Task<Result<List<Character>>> Handle(Query request, CancellationToken cancellationToken)
		{
			var characters = await _context.Characters!
				.Include(c => c.BaseStats)
				.Include(c => c.CurrentStats)
				.ToListAsync();
			
			return Result<List<Character>>.Success(characters);
		}
	}
}