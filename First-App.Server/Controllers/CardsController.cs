using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;
using First_App.Server.Observers;
using First_App.Server.Observers.Interfaces;
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
        private readonly ICardActivity _cardActivity;
        
        public CardsController (ICardRepository cardRepository,
            IMapper mapper,
            ICardActivity cardActivity)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
            _cardActivity = cardActivity;
        }
        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] AddCardRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }
            var card = _mapper.Map<Card>(request);
            await _cardRepository.AddAsync(card);
            return Ok(request);
        }
        [HttpGet]
        public async Task<IActionResult> GetCards()
        {
            var cards = await _cardRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<GetCardResponse>>(cards);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCard(int id)
        {
            var card = await _cardRepository.GetByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            var returnCard = _mapper.Map<GetCardResponse>(card);
            return Ok(returnCard);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> EditCard(int id, [FromBody]EditCardRequest request)
        {
            if(request == null|| id <= 0)
            {
                return BadRequest();
            }
            var updatedCard = _mapper.Map<Card>(request);
            updatedCard.Id = id;
            var result = await _cardRepository.UpdateAsync(updatedCard);
            if (result == true)
            {
                var response = _mapper.Map<EditCardResponse>(updatedCard);
                return Ok(response);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var card = await _cardRepository.GetByIdAsync(id);
            if(card == null)
            {
                return NotFound();
            }
            var result = await _cardRepository.DeleteByIdAsync(id);
            if (result == true)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
