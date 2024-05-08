using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataAccess.Repositories;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardColumnsController : ControllerBase
    {
        private readonly ICardColumnRepository _cardColumnRepository;
        private readonly IMapper _mapper;
        public CardColumnsController(ICardColumnRepository cardColumnRepository, IMapper mapper)
        {
            _cardColumnRepository = cardColumnRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddCardColumn([FromBody] AddCardColumnRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var card = _mapper.Map<CardColumn>(request);
            await _cardColumnRepository.AddAsync(card);
            return Ok(request);
        }
        [HttpGet]
        public async Task<IActionResult> GetCardColumns()
        {
            var cards = await _cardColumnRepository.GetAllAsync();
            var response = _mapper.Map<IEnumerable<GetCardColumnResponse>>(cards);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCardColumn(int id)
        {
            var card = await _cardColumnRepository.GetByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            var returnCard = _mapper.Map<GetCardColumnResponse>(card);
            return Ok(returnCard);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> EditCardColumn(int id, [FromBody] EditCardColumnRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var cardColumn = _cardColumnRepository.GetByIdAsync(id);
            if (cardColumn == null)
            {
                return NotFound();
            }
            var updatedCard = _mapper.Map<CardColumn>(request);
            updatedCard.Id = id;
            var result = await _cardColumnRepository.UpdateAsync(updatedCard);
            if(result == true)
            {
                var response = _mapper.Map<EditCardColumnResponse>(updatedCard);
                return Ok(response);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCardColumn(int id)
        {
            var card = await _cardColumnRepository.GetByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            var result = await _cardColumnRepository.DeleteByIdAsync(id);
            if (result == true)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
