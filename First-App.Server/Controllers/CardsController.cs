using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCard()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(int id)
        {
            return Ok();
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> EditCard(int id)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            return Ok();
        }
    }
}
