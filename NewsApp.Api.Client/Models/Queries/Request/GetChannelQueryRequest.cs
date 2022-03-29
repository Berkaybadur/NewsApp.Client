using MediatR;


namespace NewsApp.Api.Client
{
    public class GetChannelQueryRequest : IRequest<ChannelQueryResponse>
    {
        public string Id { get; set; }
    }
}