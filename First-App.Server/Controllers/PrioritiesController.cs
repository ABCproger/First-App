using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Responces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrioritiesController : ControllerBase
    {
        private readonly IPriorityRepository _priorityRepository;
        private readonly IMapper _mapper;
        public PrioritiesController(IPriorityRepository priorityRepository, IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCardColumn(int id)
        {
            var priority = await _priorityRepository.GetByIdAsync(id);
            if (priority == null)
            {
                return NotFound();
            }
            var returnCard = _mapper.Map<GetPriorityResponse>(priority);
            return Ok(returnCard);
        }
    }
}
