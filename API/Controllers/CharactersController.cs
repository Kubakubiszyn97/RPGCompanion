using Application.Characters;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CharactersController : BaseAPIController
    {
        [HttpGet]
        public async Task<IActionResult> GetCharacters()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CharacterDto character)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Character = character }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, Character character)
        {
            character.Id = id;
            return HandleResult(await Mediator.Send(new Edit.Command { Character = character }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}