using MediatR;


namespace NewsApp.Api.Client
{
    public class GetUserInterestQueryRequest : IRequest<UserInterestQueryResponse>
    {
        public string Id { get; set; }
    }
}
