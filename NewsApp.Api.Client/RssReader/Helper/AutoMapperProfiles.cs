using AutoMapper;
using NewsApp.Api.Client.RssReader.RssModel;

namespace NewsApp.Api.Client.RssReader.Helper
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<BaseFeedItem, CreateNewsCommandRequest>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Link, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.ImagePaths, opt => opt.MapFrom(src => src.ImageUrls))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language))
                .ForMember(dest => dest.ChannelCategoryMapId, opt => opt.MapFrom(src => src.ChannelCategoryMapId))
                .ForMember(dest => dest.DisplayOrder, opt => opt.MapFrom(src => src.DisplayOrder))
                .ForMember(dest => dest.ProviderNewsId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
