using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string? EyeColor { get; set; }
        public string? HairColor {get; set;}
        public string? BirthPlace {get; set;}
        public string? StarSign {get; set;}
        public string? DistinguishingMarks {get; set;}
        public int NumberOfSiblings {get; set;}
    }
}