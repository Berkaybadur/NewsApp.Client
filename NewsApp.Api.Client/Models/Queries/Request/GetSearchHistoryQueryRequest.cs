using MediatR;


namespace NewsApp.Api.Client
{
    public class GetSearchHistoryQueryRequest : IRequest<SearchHistoryQueryResponse>
    {
        public string Id { get; set; }
    }
}
