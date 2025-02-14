using Application.Core;
using Application.DTOs;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Characters;

public class Create
{
    public class Command : IRequest<Result<Unit>>
    {
        public CharacterDto? Character { get; set; }
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
            if (request.Character == null) 
                return Result<Unit>.Failure("Character cannot be null");

            var character = _mapper.Map<Character>(request.Character);
            
            if (request.Character.BaseStats != null) 
                character.BaseStats = _mapper.Map<Stats>(request.Character.BaseStats);

            if (request.Character.CurrentStats != null) 
                character.CurrentStats = _mapper.Map<Stats>(request.Character.CurrentStats);

            await _context.Characters!.AddAsync(character);
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;
            
            if (!result) return Result<Unit>.Failure("Failed to create character");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}