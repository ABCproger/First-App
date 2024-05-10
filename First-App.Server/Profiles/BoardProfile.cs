using AutoMapper;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;

namespace First_App.Server.Profiles
{
    public class BoardProfile : Profile
    {
        public BoardProfile()
        {
            CreateMap<Board, GetBoardResponse>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name));
            CreateMap<AddBoardRequest, Board>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name));
            CreateMap<EditBoardRequest, Board>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name));
            CreateMap<Board, EditBoardResponse>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name));

        }
    }
}
