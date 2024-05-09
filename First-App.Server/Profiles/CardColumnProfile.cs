using AutoMapper;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;

namespace First_App.Server.Profiles
{
    public class CardColumnProfile: Profile
    {
        public CardColumnProfile()
        {
            CreateMap<CardColumn, GetCardColumnResponse>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.BoardId,
                src => src.MapFrom(x => x.BoardId));

            CreateMap<AddCardColumnRequest, CardColumn>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.BoardId,
                src => src.MapFrom(x => x.BoardId));

            CreateMap<EditCardColumnRequest, CardColumn>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.BoardId,
                src => src.MapFrom(x => x.BoardId));

            CreateMap<CardColumn, EditCardColumnResponse>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.BoardId,
                src => src.MapFrom(x => x.BoardId));
            
        }
    }
}
