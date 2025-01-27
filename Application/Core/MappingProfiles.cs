using Application.Characters;
using Application.DTOs;
using AutoMapper;
using Domain;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CharacterDto, Character>();
        CreateMap<Character, Character>();
        CreateMap<StatsDto, Stats>();
        CreateMap<Stats, Stats>();
    }
}