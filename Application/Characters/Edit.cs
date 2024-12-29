using Application.Core;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Characters;

public class Edit
{
    public class Command : IRequest<Result<Unit>>
    {
        public Character? Character { get; set; }
    }

    public class Handler : IRequestHandler<Command, Result<Unit>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Handler(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
        {
            var character = await _context.Characters!.FindAsync(request.Character!.Id);
            if (character == null) return null!;

            _mapper.Map(request.Character, character);

            var result = await _context.SaveChangesAsync() > 0;

            if (!result) return Result<Unit>.Failure("Failed to update character");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}