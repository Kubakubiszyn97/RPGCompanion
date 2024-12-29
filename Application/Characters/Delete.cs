using Application.Core;
using MediatR;
using Persistence;

namespace Application.Characters;

public class Delete
{
    public class Command : IRequest<Result<Unit>>
    {
        public int Id { get; set; }
    } 

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            var character = await _context.Characters!.FindAsync(request.Id);

            if (character == null) return null!;

            _context.Characters.Remove(character);

            var result = await _context.SaveChangesAsync() > 0;

            if (!result) return Result<Unit>.Failure("Failed to delete character");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}