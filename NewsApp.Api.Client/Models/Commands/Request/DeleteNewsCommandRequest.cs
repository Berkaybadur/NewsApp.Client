using MediatR;


namespace NewsApp.Api.Client
{
    public class DeleteNewsCommandRequest : IRequest<EmptyResponse>
    {
        public string Id { get; set; }
    }
}
