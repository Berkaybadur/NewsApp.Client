using AutoMapper;
using NewsApp.Api.Client;
using NewsApp.UI.Models.ViewModel;

namespace NewsApp.UI.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            #region CommandRequestViewModelMapping
            CreateMap<CreateCategoryCommandRequest, CreateCategoryCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateCategoryCommandRequestViewModel, CreateCategoryCommandRequest>().ReverseMap();
            //.ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            CreateMap<CreateChannelCategoryMapCommandRequest, CreateChannelCategoryMapCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateChannelCategoryMapCommandRequestViewModel, CreateChannelCategoryMapCommandRequest>().ReverseMap();

            CreateMap<CreateChannelCommandRequest, CreateChannelCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateChannelCommandRequestViewModel, CreateChannelCommandRequest>().ReverseMap();

            CreateMap<CreateNewsCommandRequest, CreateNewsCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateNewsCommandRequestViewModel, CreateNewsCommandRequest>().ReverseMap();

            CreateMap<CreateNewsCommentNPointCommandRequest, CreateNewsCommentNPointCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateNewsCommentNPointCommandRequestViewModel, CreateNewsCommentNPointCommandRequest>().ReverseMap();

            CreateMap<CreateNewsImageCommandRequest, CreateNewsImageCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateNewsImageCommandRequestViewModel, CreateNewsImageCommandRequest>().ReverseMap();

            CreateMap<CreateNewsNewsTagMapCommandRequest, CreateNewsNewsTagMapCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateNewsNewsTagMapCommandRequestViewModel, CreateNewsNewsTagMapCommandRequest>().ReverseMap();

            CreateMap<CreateNewsViewCommandRequest, CreateNewsViewCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateNewsViewCommandRequestViewModel, CreateNewsViewCommandRequest>().ReverseMap();

            CreateMap<CreateSearchHistoryCommandRequest, CreateSearchHistoryCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateSearchHistoryCommandRequestViewModel, CreateSearchHistoryCommandRequest>().ReverseMap();

            CreateMap<CreateTagCommandRequest, CreateTagCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateTagCommandRequestViewModel, CreateTagCommandRequest>().ReverseMap();

            CreateMap<CreateUserCommandRequest, CreateUserCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateUserCommandRequestViewModel, CreateUserCommandRequest>().ReverseMap();

            CreateMap<CreateUserInterestCommandRequest, CreateUserInterestCommandRequestViewModel>().ReverseMap();
            //CreateMap<CreateUserInterestCommandRequestViewModel, CreateUserInterestCommandRequest>().ReverseMap();

            CreateMap<DeleteCategoryCommandRequest, DeleteCategoryCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteCategoryCommandRequestViewModel, DeleteCategoryCommandRequest>().ReverseMap();

            CreateMap<DeleteChannelCategoryMapCommandRequest, DeleteChannelCategoryMapCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteChannelCategoryMapCommandRequestViewModel, DeleteChannelCategoryMapCommandRequest>().ReverseMap();

            CreateMap<DeleteChannelCommandRequest, DeleteChannelCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteChannelCommandRequestViewModel, DeleteChannelCommandRequest>().ReverseMap();

            CreateMap<DeleteNewsCommandRequest, DeleteNewsCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteNewsCommandRequestViewModel, DeleteNewsCommandRequest>().ReverseMap();

            CreateMap<DeleteNewsCommentNPointCommandRequest, DeleteNewsCommentNPointCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteNewsCommentNPointCommandRequestViewModel, DeleteNewsCommentNPointCommandRequest>().ReverseMap();

            CreateMap<DeleteNewsImageCommandRequest, DeleteNewsImageCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteNewsImageCommandRequestViewModel, DeleteNewsImageCommandRequest>().ReverseMap();

            CreateMap<DeleteNewsNewsTagMapCommandRequest, DeleteNewsNewsTagMapCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteNewsNewsTagMapCommandRequestViewModel, DeleteNewsNewsTagMapCommandRequest>().ReverseMap();

            CreateMap<DeleteSearchHistoryCommandRequest, DeleteSearchHistoryCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteSearchHistoryCommandRequestViewModel, DeleteSearchHistoryCommandRequest>().ReverseMap();

            CreateMap<DeleteTagCommandRequest, DeleteTagCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteTagCommandRequestViewModel, DeleteTagCommandRequest>().ReverseMap();

            CreateMap<DeleteUserCommandRequest, DeleteUserCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteUserCommandRequestViewModel, DeleteUserCommandRequest>().ReverseMap();

            CreateMap<DeleteUserInterestCommandRequest, DeleteUserInterestCommandRequestViewModel>().ReverseMap();
            //CreateMap<DeleteUserInterestCommandRequestViewModel, DeleteUserInterestCommandRequest>().ReverseMap();

            CreateMap<UpdateCategoryCommandRequest, UpdateCategoryCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateCategoryCommandRequestViewModel, UpdateCategoryCommandRequest>().ReverseMap();

            CreateMap<UpdateChannelCategoryMapCommandRequest, UpdateChannelCategoryMapCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateChannelCategoryMapCommandRequestViewModel, UpdateChannelCategoryMapCommandRequest>().ReverseMap();

            CreateMap<UpdateChannelCommandRequest, UpdateChannelCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateChannelCommandRequestViewModel, UpdateChannelCommandRequest>().ReverseMap();

            CreateMap<UpdateNewsCommandRequest, UpdateNewsCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateNewsCommandRequestViewModel, UpdateNewsCommandRequest>().ReverseMap();

            CreateMap<UpdateNewsImageCommandRequest, UpdateNewsImageCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateNewsImageCommandRequestViewModel, UpdateNewsImageCommandRequest>().ReverseMap();

            CreateMap<UpdateNewsNewsTagMapCommandRequest, UpdateNewsNewsTagMapCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateNewsNewsTagMapCommandRequestViewModel, UpdateNewsNewsTagMapCommandRequest>().ReverseMap();

            CreateMap<UpdateSearchHistoryCommandRequest, UpdateSearchHistoryCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateSearchHistoryCommandRequestViewModel, UpdateSearchHistoryCommandRequest>().ReverseMap();

            CreateMap<UpdateTagCommandRequest, UpdateTagCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateTagCommandRequestViewModel, UpdateTagCommandRequest>().ReverseMap();

            CreateMap<UpdateUserCommandRequest, UpdateUserCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateUserCommandRequestViewModel, UpdateUserCommandRequest>().ReverseMap();

            CreateMap<UpdateUserInterestCommandRequest, UpdateUserInterestCommandRequestViewModel>().ReverseMap();
            //CreateMap<UpdateUserInterestCommandRequestViewModel, UpdateUserInterestCommandRequest>().ReverseMap();

            CreateMap<BaseResponse, BaseResponseCommandViewModel>().ReverseMap();
            //CreateMap<BaseResponseCommandViewModel, BaseResponse>().ReverseMap();

            CreateMap<EmptyResponse, EmptyResponseViewModel>().ReverseMap();
            //CreateMap<EmptyResponseViewModel, EmptyResponse>().ReverseMap();
            #endregion

            #region QueriesViewModelMapping
            CreateMap<GetCategoryQueryRequest, GetCategoryQueryRequestViewModel>().ReverseMap();

            CreateMap<GetChannelCategoryMapQueryRequest, GetChannelCategoryMapQueryRequestViewModel>().ReverseMap();

            CreateMap<GetChannelQueryRequest, GetChannelQueryRequestViewModel>().ReverseMap();

            CreateMap<GetNewsImageQueryRequest, GetNewsImageQueryRequestViewModel>().ReverseMap();

            CreateMap<GetNewsNewsTagMapQueryRequest, GetNewsNewsTagMapQueryRequestViewModel>().ReverseMap();

            CreateMap<GetNewsQueryRequest, GetNewsQueryRequestViewModel>().ReverseMap();

            CreateMap<GetSearchHistoryQueryRequest, GetSearchHistoryQueryRequestViewModel>().ReverseMap();

            CreateMap<GetTagQueryRequest, GetTagQueryRequestViewModel>().ReverseMap();

            CreateMap<GetUserInterestQueryRequest, GetUserInterestQueryRequestViewModel>().ReverseMap();

            CreateMap<GetUserQueryRequest, GetUserQueryRequestViewModel>().ReverseMap();

            CreateMap<ListCategoryQueryRequest, ListCategoryQueryRequestViewModel>().ReverseMap();

            CreateMap<ListChannelCategoryMapQueryRequest, ListChannelCategoryMapQueryRequestViewModel>().ReverseMap();

            CreateMap<ListChannelQueryRequest, ListChannelQueryRequestViewModel>().ReverseMap();

            CreateMap<ListNewsCommentNPointQueryRequest, ListNewsCommentNPointQueryRequestViewModel>().ReverseMap();

            CreateMap<ListNewsImageQueryRequest, ListNewsImageQueryRequestViewModel>().ReverseMap();

            CreateMap<ListNewsNewsTagMapQueryRequest, ListNewsNewsTagMapQueryRequestViewModel>().ReverseMap();

            CreateMap<ListNewsQueryRequest, ListNewsQueryRequestViewModel>().ReverseMap();

            CreateMap<ListNewsViewQueryRequest, ListNewsViewQueryRequestViewModel>().ReverseMap();

            CreateMap<ListSearchHistoryQueryRequest, ListSearchHistoryQueryRequestViewModel>().ReverseMap();

            CreateMap<ListTagQueryRequest, ListTagQueryRequestViewModel>().ReverseMap();

            CreateMap<ListUserInterestQueryRequest, ListUserInterestQueryRequestViewModel>().ReverseMap();

            CreateMap<ListUserQueryRequest, ListUserQueryRequestViewModel>().ReverseMap();

            CreateMap<CategoryQueryResponse, CategoryQueryResponseViewModel>().ReverseMap();

            CreateMap<ChannelCategoryMapQueryResponse, ChannelCategoryMapQueryResponseViewModel>().ReverseMap();

            CreateMap<ChannelQueryResponse, ChannelQueryResponseViewModel>().ReverseMap();

            CreateMap<ListCategoryQueryResponse, ListCategoryQueryResponseViewModel>().ReverseMap();

            CreateMap<ListChannelCategoryMapQueryResponse, ListChannelCategoryMapQueryResponseViewModel>().ReverseMap();

            CreateMap<ListChannelQueryResponse, ListChannelQueryResponseViewModel>().ReverseMap();

            CreateMap<ListNewsCommentNPointQueryResponse, ListNewsCommentNPointQueryResponseViewModel>().ReverseMap();

            CreateMap<ListNewsImageQueryResponse, ListNewsImageQueryResponseViewModel>().ReverseMap();

            CreateMap<ListNewsNewsTagMapQueryResponse, ListNewsNewsTagMapQueryResponseViewModel>().ReverseMap();

            CreateMap<ListNewsQueryResponse, ListNewsQueryResponseViewModel>().ReverseMap();

            CreateMap<ListNewsViewQueryResponse, ListNewsViewQueryResponseViewModel>().ReverseMap();

            CreateMap<ListSearchHistoryQueryResponse, ListSearchHistoryQueryResponseViewModel>().ReverseMap();

            CreateMap<ListTagQueryResponse, ListTagQueryResponseViewModel>().ReverseMap();

            CreateMap<ListUserInterestQueryResponse, ListUserInterestQueryResponseViewModel>().ReverseMap();

            CreateMap<ListUserQueryResponse, ListUserQueryResponseViewModel>().ReverseMap();

            CreateMap<NewsImageQueryResponse, NewsImageQueryResponseViewModel>().ReverseMap();

            CreateMap<NewsNewsTagMapQueryResponse, NewsNewsTagMapQueryResponseViewModel>().ReverseMap();

            CreateMap<NewsQueryResponse, NewsQueryResponseViewModel>().ReverseMap();

            CreateMap<SearchHistoryQueryResponse, SearchHistoryQueryResponseViewModel>().ReverseMap();

            CreateMap<TagQueryResponse, TagQueryResponseViewModel>().ReverseMap();

            CreateMap<UserInterestQueryResponse, UserInterestQueryResponseViewModel>().ReverseMap();

            CreateMap<UserQueryResponse, UserQueryResponseViewModel>().ReverseMap();

            #endregion

            #region KeyValueViewModelMapping
            CreateMap<ListCategoryQueryResponse, KeyValueViewModel>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Name)).ReverseMap();

            CreateMap<ListChannelQueryResponse, KeyValueViewModel>()
                .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Name)).ReverseMap();

            CreateMap<ListTagQueryResponse, KeyValueViewModel>()
               .ForMember(dest => dest.Key, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Name)).ReverseMap();
            #endregion

        }
    }
}
