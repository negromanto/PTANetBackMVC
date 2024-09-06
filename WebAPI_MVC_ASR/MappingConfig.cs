using AutoMapper;
using WebAPI_MVC_ASR.Models;
using WebAPI_MVC_ASR.Models.DTOs;

namespace WebAPI_MVC_ASR
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Feed, FeedDTO>().ReverseMap();
        }
    }
}
