using Domain.Enums;
using Domain;

namespace Persistence;

public class Seed
{
    public static async Task SeedData(DataContext context)
    {
        if (context.Characters!.Any()) return;

        var characters = new List<Character>
        {
            new Character
            {
                Name = "Karl Franz",
                CharacterRace = CharacterRace.Human,
                Gender = Gender.Male,
                Age = 45,
                Weight = 85,
                Height = 180,
                EyeColor = "Blue",
                HairColor = "Blonde",
                BirthPlace = "Altdorf",
                StarSign = "The Griffon",
                DistinguishingMarks = "Scar on left cheek",
                NumberOfSiblings = 2,
                BaseStats = new Stats { WW = 60, US = 50, K = 55, Odp = 60, Zr = 50, Int = 70, Sw = 65, Ogd = 75, A = 2, Zyw = 15, S = 5, Wt = 5, Sz = 4, Mag = 0, PO = 0, PP = 3 },
                CurrentStats = new Stats { WW = 60, US = 50, K = 55, Odp = 60, Zr = 50, Int = 70, Sw = 65, Ogd = 75, A = 2, Zyw = 15, S = 5, Wt = 5, Sz = 4, Mag = 0, PO = 0, PP = 3 }
            },
            new Character
            {
                Name = "Teclis",
                CharacterRace = CharacterRace.Elf,
                Gender = Gender.Male,
                Age = 300,
                Weight = 70,
                Height = 190,
                EyeColor = "Green",
                HairColor = "Silver",
                BirthPlace = "Ulthuan",
                StarSign = "The Phoenix",
                DistinguishingMarks = "Tattoo on right arm",
                NumberOfSiblings = 1,
                BaseStats = new Stats { WW = 40, US = 60, K = 30, Odp = 50, Zr = 60, Int = 90, Sw = 80, Ogd = 70, A = 1, Zyw = 12, S = 3, Wt = 3, Sz = 5, Mag = 4, PO = 0, PP = 2 },
                CurrentStats = new Stats { WW = 40, US = 60, K = 30, Odp = 50, Zr = 60, Int = 90, Sw = 80, Ogd = 70, A = 1, Zyw = 12, S = 3, Wt = 3, Sz = 5, Mag = 4, PO = 0, PP = 2 }
            },
            new Character
            {
                Name = "Gotrek Gurnisson",
                CharacterRace = CharacterRace.Dwarf,
                Gender = Gender.Male,
                Age = 150,
                Weight = 90,
                Height = 140,
                EyeColor = "Brown",
                HairColor = "Red",
                BirthPlace = "Karak Kadrin",
                StarSign = "The Slayer",
                DistinguishingMarks = "Mohawk hairstyle",
                NumberOfSiblings = 0,
                BaseStats = new Stats { WW = 70, US = 40, K = 60, Odp = 70, Zr = 40, Int = 50, Sw = 80, Ogd = 30, A = 3, Zyw = 18, S = 6, Wt = 6, Sz = 3, Mag = 0, PO = 0, PP = 4 },
                CurrentStats = new Stats { WW = 70, US = 40, K = 60, Odp = 70, Zr = 40, Int = 50, Sw = 80, Ogd = 30, A = 3, Zyw = 18, S = 6, Wt = 6, Sz = 3, Mag = 0, PO = 0, PP = 4 }
            },
            new Character
            {
                Name = "Morathi",
                CharacterRace = CharacterRace.Halfling,
                Gender = Gender.Female,
                Age = 500,
                Weight = 65,
                Height = 175,
                EyeColor = "Black",
                HairColor = "Black",
                BirthPlace = "Naggaroth",
                StarSign = "The Serpent",
                DistinguishingMarks = "Piercing gaze",
                NumberOfSiblings = 0,
                BaseStats = new Stats { WW = 50, US = 70, K = 40, Odp = 60, Zr = 70, Int = 80, Sw = 90, Ogd = 60, A = 2, Zyw = 14, S = 4, Wt = 4, Sz = 5, Mag = 3, PO = 0, PP = 3 },
                CurrentStats = new Stats { WW = 50, US = 70, K = 40, Odp = 60, Zr = 70, Int = 80, Sw = 90, Ogd = 60, A = 2, Zyw = 14, S = 4, Wt = 4, Sz = 5, Mag = 3, PO = 0, PP = 3 }
            }
        };

        await context.Characters!.AddRangeAsync(characters);
        await context.SaveChangesAsync();
    }
}