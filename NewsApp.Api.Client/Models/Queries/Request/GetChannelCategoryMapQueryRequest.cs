using MediatR;


namespace NewsApp.Api.Client
{
    public class GetChannelCategoryMapQueryRequest : IRequest<ChannelCategoryMapQueryResponse>
    {
        public string Id { get; set; }
    }
}
