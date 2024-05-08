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
        
        public CardsController (ICardRepository cardRepository, IMapper mapper, ICardActivity cardActivity)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
            _cardActivity = cardActivity;
        }
        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody] AddCardRequest request, [FromServices] IObserver observer)
        {
            if(request == null)
            {
                return BadRequest();
            }
            var card = _mapper.Map<Card>(request);
            await _cardRepository.AddAsync(card);
            await _cardActivity.AttachAsync(observer);
            await _cardActivity.NotifyAsync("smth", card.Name);
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
            await _cardRepository.UpdateAsync(updatedCard);
            var response = _mapper.Map<EditCardResponse>(updatedCard);
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var card = await _cardRepository.GetByIdAsync(id);
            if(card == null)
            {
                return NotFound();
            }
            await _cardRepository.DeleteByIdAsync(id);
            return NoContent();
        }
    }
}
