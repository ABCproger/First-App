using AutoMapper;
using First_App.Server.DataTransferObjects.Responces;
using First_App.Server.Entities;

namespace First_App.Server.Profiles
{
    public class CardActivityLogProfile : Profile
    {
        public CardActivityLogProfile()
        {
            CreateMap<CardActivityLog, GetCardActivityResponse>()
                .ForMember(dest => dest.ActivityTime, opt => opt.MapFrom(src => src.ActivityTime))
                .ForMember(dest => dest.Action, opt => opt.MapFrom(src => src.Action));
        }
    }
}
