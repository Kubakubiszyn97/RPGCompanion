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
        public ActionResult<Character> Get(int id)
        {
            return Ok();
        }
    }
}