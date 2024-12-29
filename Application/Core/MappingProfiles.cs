using Application.Characters;
using AutoMapper;
using Domain;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CharacterDto, Character>();
        CreateMap<Character, Character>();
    }
}