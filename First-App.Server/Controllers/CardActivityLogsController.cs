using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Responces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardActivityLogsController : ControllerBase
    {
        private readonly ICardActivityLogsRepository _cardActivityLogsRepository;
        private readonly IMapper _mapper;
        public CardActivityLogsController(ICardActivityLogsRepository cardActivityLogsRepository, IMapper mapper)
        {
            _cardActivityLogsRepository = cardActivityLogsRepository;
            _mapper = mapper;
        }

        [HttpGet("{cardId}")]
        public async Task<IActionResult> GetCardActivity(int cardId, [FromQuery] int page, [FromQuery] int pageSize)
        {
            var activity = await _cardActivityLogsRepository.GetCardActivitiesAsync(cardId, page, pageSize);
            if(activity == null)
            {
                return NotFound();
            }
            return Ok(activity);
        }
    }
}
