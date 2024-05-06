using AutoMapper;
using First_App.Server.DataAccess.Interfaces;
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
    }
}
