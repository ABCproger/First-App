using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;
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
        [HttpPost]
        public async Task<IActionResult> AddBoard([FromBody] AddBoardRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            var board = _mapper.Map<Board>(request);
            await _boardRepository.AddAsync(board);
            return Ok(request);
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> EditBoard(int id, [FromBody] EditBoardRequest request)
        {
            if (request == null || id <= 0)
            {
                return BadRequest();
            }
            var updatedBoard = _mapper.Map<Board>(request);
            updatedBoard.Id = id;
            var result = await _boardRepository.UpdateAsync(updatedBoard);
            if (result == true)
            {
                var response = _mapper.Map<EditBoardResponse>(updatedBoard);
                return Ok(response);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard(int id)
        {
            var card = await _boardRepository.GetByIdAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            var result = await _boardRepository.DeleteByIdAsync(id);
            if (result == true)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
