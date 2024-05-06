using AutoMapper;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;

namespace First_App.Server.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Card, GetCardResponse>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description,
                src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.DueDate,
                src => src.MapFrom(x => x.DueDate))
                .ForMember(dest => dest.CardColumnId,
                src => src.MapFrom(x => x.CardColumnId)); ;

            CreateMap<AddCardRequest, Card>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description,
                src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.DueDate,
                src => src.MapFrom(x => x.DueDate))
                .ForMember(dest => dest.CardColumnId,
                src => src.MapFrom(x => x.CardColumnId));

            CreateMap<EditCardRequest, Card>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description,
                src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.DueDate,
                src => src.MapFrom(x => x.DueDate))
                .ForMember(dest => dest.CardColumnId,
                src => src.MapFrom(x => x.CardColumnId));

            CreateMap<Card,EditCardResponse>()
                .ForMember(dest => dest.Id,
                src => src.MapFrom(x => x.Id))
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description,
                src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.DueDate,
                src => src.MapFrom(x => x.DueDate))
                .ForMember(dest => dest.CardColumnId,
                src => src.MapFrom(x => x.CardColumnId));

        }
    }
}
