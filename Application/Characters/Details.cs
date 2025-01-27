using Application.Core;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Characters;

public class Details
{
    public class Query : IRequest<Result<Character>>
    {
        public int Id { get; set; }
    }

    public class Handler : IRequestHandler<Query, Result<Character>>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<Character>> Handle(Query request, CancellationToken cancellationToken)
        {
            var character = await _context.Characters!
                .Include(c => c.BaseStats)
                .Include(c => c.CurrentStats)
                .FirstOrDefaultAsync(c => c.Id == request.Id);

            if (character == null)
                return Result<Character>.Failure("Character not found.");

            return Result<Character>.Success(character);
        }
    }
}