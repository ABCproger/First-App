using AutoMapper;
using First_App.Server.DataTransferObjects.Requests;
using First_App.Server.Entities;

namespace First_App.Server.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Card, GetCardRequest>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description,
                src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.DueDate,
                src => src.MapFrom(x => x.DueDate));

            CreateMap<AddCardRequest,Card>()
                .ForMember(dest => dest.Name,
                src => src.MapFrom(x => x.Name))
                .ForMember(dest => dest.Description,
                src => src.MapFrom(x => x.Description))
                .ForMember(dest => dest.DueDate,
                src => src.MapFrom(x => x.DueDate));

        }
    }
}
