using MediatR;


namespace NewsApp.Api.Client
{
    public class GetNewsImageQueryRequest : IRequest<NewsImageQueryResponse>
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
    }
}
