using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;
        public CardsController (ICardRepository cardRepository, IMapper mapper)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] AddCardRequest request)
        {
            var card = _mapper.Map<Card>(request);
            await _cardRepository.AddAsync(card);
            return Ok(request);
        }
        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            var cards = await _cardRepository.GetAllAsync();
            return Ok(cards);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(int id)
        {
            var card = await _cardRepository.GetByIdAsync(id);
            var returnCard = _mapper.Map<GetCardRequest>(card);
            return Ok(returnCard);
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
