using MediatR;


namespace NewsApp.Api.Client
{
    public class GetNewsNewsTagMapQueryRequest : IRequest<NewsNewsTagMapQueryResponse>
    {
        public string Id { get; set; }
        public string NewsId { get; set; }
    }
}
