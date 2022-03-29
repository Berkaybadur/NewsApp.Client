using MediatR;


namespace NewsApp.Api.Client
{
    public class GetUserQueryRequest : IRequest<UserQueryResponse>
    {
        public string Id { get; set; }
    }
}
