using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Responces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IMapper _mapper;
        private readonly ICardColumnRepository _cardColumnRepository;
        public BoardsController(IBoardRepository boardRepository,IMapper mapper,ICardColumnRepository cardColumnRepository)
        {
            _boardRepository = boardRepository;
            _mapper = mapper;
            _cardColumnRepository = cardColumnRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBoard(int id)
        {
            var card = await _boardRepository.GetByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            var returnCard = _mapper.Map<GetBoardResponse>(card);
            return Ok(returnCard);
        }
        [HttpGet("{boardId}/columns")]
        public async Task<IActionResult> GetCardColumnsForBoard(int boardId)
        {
            var columns = await _cardColumnRepository.GetColumnsByBoardIdAsync(boardId);
            if(columns == null)
            {
                return NotFound();
            }
            var returnColumns = _mapper.Map<IEnumerable<GetCardColumnResponse>>(columns);
            return Ok(returnColumns);
        }
    }
}
