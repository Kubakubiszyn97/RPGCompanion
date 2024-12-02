using Domain.Enums;
using Domain;

namespace Persistence;

public class Seed
{
    public static async Task SeedData(DataContext context)
    {
        if (context.Characters.Any()) return;

        var characters = new List<Character>
        {
            new Character
            {
                Name = "Alaric",
                CharacterRace = CharacterRace.Human,
                Gender = Gender.Male,
                Age = 32,
                Weight = 80,
                Height = 175,
                EyeColor = "Brown",
                HairColor = "Black",
                BirthPlace = "Altdorf",
                StarSign = "The Drummer",
                DistinguishingMarks = "Scar across left eye",
                NumberOfSiblings = 1
            },
            new Character
            {
                Name = "Elanor",
                CharacterRace = CharacterRace.Elf,
                Gender = Gender.Female,
                Age = 120,
                Weight = 60,
                Height = 170,
                EyeColor = "Green",
                HairColor = "Blonde",
                BirthPlace = "Ulthuan",
                StarSign = "The Dancer",
                DistinguishingMarks = "Tattoo of a phoenix on her arm",
                NumberOfSiblings = 2
            },
            new Character
            {
                Name = "Thorin",
                CharacterRace = CharacterRace.Dwarf,
                Gender = Gender.Male,
                Age = 85,
                Weight = 90,
                Height = 140,
                EyeColor = "Blue",
                HairColor = "Red",
                BirthPlace = "Karaz-a-Karak",
                StarSign = "The Anvil",
                DistinguishingMarks = "Braided beard",
                NumberOfSiblings = 3
            },
            new Character
            {
                Name = "Lila",
                CharacterRace = CharacterRace.Halfling,
                Gender = Gender.Female,
                Age = 25,
                Weight = 40,
                Height = 100,
                EyeColor = "Hazel",
                HairColor = "Brown",
                BirthPlace = "The Moot",
                StarSign = "The Jester",
                DistinguishingMarks = "Freckles",
                NumberOfSiblings = 4
            },
            new Character
            {
                Name = "Eldrin",
                CharacterRace = CharacterRace.Elf,
                Gender = Gender.Male,
                Age = 150,
                Weight = 65,
                Height = 180,
                EyeColor = "Grey",
                HairColor = "Silver",
                BirthPlace = "Naggaroth",
                StarSign = "The Blade",
                DistinguishingMarks = "Pierced ear",
                NumberOfSiblings = 1
            }
        };
            
        await context.Characters.AddRangeAsync(characters);
        await context.SaveChangesAsync();
    }
}