using MediatR;


namespace NewsApp.Api.Client
{
    public class GetTagQueryRequest : IRequest<TagQueryResponse>
    {
        public string Id { get; set; }
    }
}
