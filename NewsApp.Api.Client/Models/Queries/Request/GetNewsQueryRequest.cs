using MediatR;


namespace NewsApp.Api.Client
{
    public class GetNewsQueryRequest : IRequest<NewsQueryResponse>
    {
        public string Id { get; set; }
    }
}
